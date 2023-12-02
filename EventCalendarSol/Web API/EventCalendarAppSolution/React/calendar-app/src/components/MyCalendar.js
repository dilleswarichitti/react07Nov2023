import React, { useState } from 'react';
import { Calendar, momentLocalizer } from 'react-big-calendar';
import 'react-big-calendar/lib/css/react-big-calendar.css';
import moment from 'moment';
import DisplayEvents from './DisplayEvents';
import Popup from 'reactjs-popup';
import AddEvent from './AddEvent';

const localizer = momentLocalizer(moment);

function MyCalendar({ events }) {
  const [selectedEvent, setSelectedEvent] = useState(null);
  const [showAddEventPopup, setShowAddEventPopup] = useState(false);

  const openPopup = (event) => {
    setSelectedEvent(event);
  };

  const closePopup = () => {
    setSelectedEvent(null);
    setShowAddEventPopup(false);
  };

  const renderPopup = () => {
    if (selectedEvent) {
      return (
        <Popup open={selectedEvent !== null} onClose={closePopup} position="right center">
          <DisplayEvents event={selectedEvent} />
          <button onClick={closePopup}>Close</button>
        </Popup>
      );
    } else if (showAddEventPopup) {
      return (
        <Popup open={showAddEventPopup} onClose={closePopup} position="right center">
          <AddEvent />
          <button onClick={closePopup}>Close</button>
        </Popup>
      );
    }

    return null;
  };

  const handleSelectSlot = () => {
    setShowAddEventPopup(true);
  };

  const formatDate = (date) => {
    return moment(date).format('MM DD, YYYY hh:mm A');
  };

  const eventStyle = (event) => {
    const colorMap = {
      1: "orange",
      2: "red",
      3: "blue",
    };

    const formattedStartDate = formatDate(event.startDateTime);
    const formattedEndDate = formatDate(event.endDateTime);

    const backgroundColor = colorMap[event.categoryId] || 'green'; // Access categoryId property

    return {
      style: {
        backgroundColor,
        color: 'white', // Text color
      },
      content: (
        <div>
          <p>{`Start: ${formattedStartDate}`}</p>
          <p>{`End: ${formattedEndDate}`}</p>
        </div>
      ),
    };
  };

  return (
    <div>
      <h2>Event Calendar</h2>
      <Calendar
        localizer={localizer}
        events={events}
        views={['month', 'week', 'day', 'agenda']}
        defaultView="month"
        startAccessor="startDateTime"
        endAccessor="endDateTime"
        selectable
        onSelectEvent={(event) => openPopup(event)}
        onSelectSlot={handleSelectSlot}
        eventPropGetter={(event) => eventStyle(event)}
        style={{ height: 500, width: 1200 }}
      />
      {renderPopup()}
    </div>
  );
}

export default MyCalendar;

import React, { useState } from 'react';
import { Calendar, momentLocalizer } from 'react-big-calendar';
import 'react-big-calendar/lib/css/react-big-calendar.css';
import moment from 'moment';
import Year from './Year';  
import Popup from 'reactjs-popup';
import AddEvent from './AddEvent';
import PutEvent from './PutEvents';

const localizer = momentLocalizer(moment);

function MyCalendar({ events }) {
  const [selectedEvent, setSelectedEvent] = useState(null);
  const [showAddEventPopup, setShowAddEventPopup] = useState(false);
  const [searchInput, setSearchInput] = useState('');


  const openPopup = (event) => {
    setSelectedEvent(event);
  };

  const closePopup = () => {
    setSelectedEvent(null);
    setShowAddEventPopup(false);
  };

  const handleAddEvent = (newEvent) => {
    // Handle adding the new event to your events array or backend
    // You might need to pass the newEvent to your calendar component
    // to trigger a re-render with the added data
    // For example:
    // addEventFunction(newEvent);

    // Close the popup or reset the form, etc.
    closePopup();
  };

  const handleUpdateEvent = (updatedEvent) => {
    // Handle updating the event in your events array or backend
    // You might need to pass the updatedEvent to your calendar component
    // to trigger a re-render with the updated data
    // For example:
    // updateEventFunction(updatedEvent);

    // Close the popup or reset the form, etc.
    closePopup();
  };

  const renderPopup = () => {
    if (showAddEventPopup) {
      return (
        <Popup open={showAddEventPopup} onClose={closePopup} position="right center">
          <AddEvent onAddEvent={handleAddEvent} />
          <button onClick={closePopup}>Close</button>
        </Popup>
      );
    } else if (selectedEvent) {
      return (
        <Popup class="crollspy-example" data-bs-spy="scroll" open={selectedEvent !== null} onClose={closePopup} position="right center">
          
          <PutEvent event={selectedEvent} />
          <button onClick={closePopup}>Close</button>
        </Popup>
      );
    }
  
    return null;
  };

  const formatDate = (date, view) => {
    if (view === 'day') {
      return moment(date).format('MM DD, YYYY hh:mm A');
    } else if (view === 'week') {
      return moment(date).format('MM DD, YYYY');
    } else {
      // Handle other views if needed
      return moment(date).format('MM DD, YYYY hh:mm A');
    }
  };
  
  const handleSelectSlot = (slotInfo) => {
    const { start, end, action } = slotInfo;
    if (action === 'click' || action === 'select') {
      setShowAddEventPopup(true);
    }
  };
  
  const eventStyle = (event) => {
    const colorMap = {
      "work": "#12eff3",
      "family": "#ffc0cb",
      "personal": "#41d60a",
    };

    const formattedStartDate = formatDate(event.startDateTime);
    const formattedEndDate = formatDate(event.endDateTime);
    const backgroundColor = colorMap[event.category] || 'green'; // Access categoryId property

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
        defaultView="month"
        startAccessor="startDateTime"
        endAccessor="endDateTime"
        selectable
        onSelectEvent={(event) => openPopup(event)}
        onSelectSlot={handleSelectSlot}
        eventPropGetter={(event) => eventStyle(event)}
        style={{ height: 500, width: 900 }}
        views={{
          day: true,
          week: true,
          month: true,
          year: Year,
        }}
        messages={{ year: 'Year' }}
        formats={{ dayFormat: 'D', weekdayFormat: 'ddd' }} // Add this line for day and week format customization
      />
      {renderPopup()}
    </div>
  );
}

export default MyCalendar;
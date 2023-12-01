import React from 'react';

const DisplayEvents = ({ eventList }) => (
  <div>
    {eventList ? (
      eventList.map((group) => (
        <div key={group.key} className="group-container">
          {group.key}
          {group.map((event) => (
            <div key={event.eventId} className="alert alert-success">
              Event title: {event.title}
              <br />
              Event startdatetime: {event.startdatetime}
              <br />
              Event enddatetime: {event.enddatetime}
              <br />
              Event location: {event.location}
            </div>
          ))}
        </div>
      ))
    ) : (
      <p>No events available.</p>
    )}
  </div>
);

export default DisplayEvents;

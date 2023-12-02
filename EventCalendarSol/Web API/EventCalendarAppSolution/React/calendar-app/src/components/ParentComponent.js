import React, { useState } from 'react';
import MyCalendar from './MyCalendar'; // Adjust the path accordingly

function ParentComponent() {
  const [events, setEvents] = useState([
    // Your initial events go here
    {
      title: 'Technical Discussion',
      start: new Date('2023-12-03T09:00:00'),
      end: new Date('2023-12-03T18:00:00'),
      // ... other event details
    },
    {
        title: 'Discussion',
      start: new Date('2023-12-06T09:00:00'),
      end: new Date('2023-12-06T18:00:00'),
    },
    // Add more events as needed
  ]);

  const handleSelect = (event) => {
    // Handle event selection if needed
    console.log('Selected Event:', event);
  };

  return (
    <div>
         {/* Your other components */}
      <MyCalendar events={events} handleSelect={handleSelect} />
    </div>
  );
}

export default ParentComponent;
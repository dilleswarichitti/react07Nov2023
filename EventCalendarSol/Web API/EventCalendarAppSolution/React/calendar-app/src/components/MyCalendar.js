import React from 'react';
   import { Calendar, momentLocalizer } from 'react-big-calendar';
   import 'react-big-calendar/lib/css/react-big-calendar.css';
   import moment from 'moment';

   const localizer = momentLocalizer(moment);

   function MyCalendar ({ events, handleSelect }) {
     return (
       <div>
       <Calendar
           localizer={localizer}
           events={events}
           views={['month', 'week', 'day','agenda']}
           defaultView="month"
           startAccessor="start"
           endAccessor="end"
           onSelectEvent={handleSelect}
           style={{ height: 500 , width: 800}}
         />
       </div>
     );
   };

export default MyCalendar;
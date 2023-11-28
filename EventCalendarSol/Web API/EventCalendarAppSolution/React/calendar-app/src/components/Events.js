import axios from "axios";
import { useState } from "react";

function Events(){
    const [email,setEmail]=useState("");
    const [eventList,setEventList]=useState([])
    var getEvents = (event)=>{
        event.preventDefault();
        console.log(email);
        axios.get('https://localhost:7117/api/event',{
            params: {
                userId : email
            }
          })
          .then((response) => {
            const posts = response.data;
            console.log(posts);
            setEventList(posts);
            console .log(eventList);
        })
        .catch(function (error) {
            console.log(error);
        })
    }
    var checkEvents = eventList.length>0?true:false;
return(
      <div className="searchBox">
      <h1 className="alert alert-success">Events</h1>
      
      <form>      
        <br/>   
        <div class="row"> 
          <input id="pemail" type="text" class="form-control" value={email} onChange={(e)=>{setEmail(e.target.value)}}/>
        </div>
        <div class="row">
            <button className="btn btn-success" onClick={getEvents}>Get All Events</button>
        </div>
        </form>
      {checkEvents ? (
        <div>
          {eventList.map((group)=>(
            <div key={group.key} className="group-container">
               {group.key}
                {group.map((event)=>
                    <div key={event.eventId} className="alert alert-success">
                    Event title: {event.title}
                    <br />
                    Event description: {event.description}
                    <br />
                    Event start datetime: {event.startDateTime}
                    <br />
                    Event end datetime: {event.endDateTime}
                    <br />
                    Event notification datetime: {event.notificationDateTime}
                    <br />
                    Event location: {event.location}
                    <br />
                    Event IsRecurring: {event.isRecurring ? 'Yes' : 'No'}
                    <br />
                    Event recurring frequency: {event.recurring_Frequency}
                    <br />
                    Event ShareEventWith: {event.shareEventWith}
                    <br/>
                    Event Access : {event.access}
                    <br/>
                    Event categoryId: {event.categoryId}
                    <br />
                    Event email: {event.email}
                </div>
                )}
            </div>
          ))}
        </div>

      ) : (
        <div>No events available yet</div>
      )}
    </div>
  );
}

export default Events;
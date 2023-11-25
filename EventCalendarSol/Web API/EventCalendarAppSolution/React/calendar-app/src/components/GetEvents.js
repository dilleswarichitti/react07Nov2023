import { useState } from "react";
import axios from "axios";

function GetEvents(){
    const [email,setEmail]=useState('');
    const [eventList,setEventList]=useState([])
    var getEvents = ()=>{
        axios.get('https://localhost:7117/api/Event',{
            method:'GET',
            headers:{
                'Accept':'application/json',
                'Content-Type':'application/json'
            }
        }).then(
            async (data)=>{
                var myData = await data.json();
                await console.log(myData);
                await setEventList(myData);
            }
        ).catch((e)=>{
            console.log(e)
        })
    }
    
    var getEvents = eventList.email;
return(
    <div>
        <h1 className="alert alert-success">Events</h1>
        <button className="btn btn-success" onClick={getEvents}>Get All Events</button>
            <div >
                {eventList.map((event)=>
                    <div key={event.id} className="alert alert-primary">
                         Event title : {event.title}
                        <br/>
                        Event description : {event.description}
                        <br/>
                        Event startdatetime : {event.startdatetime}
                        <br/>
                        Event enddatetime : {event.enddatetime}
                        <br/>
                        Event notificationdatetime : {event.notificationdatetime}
                        <br/>
                        Event location : {event.location}
                        <br/>
                        Event IsRecurring : {event.IsRecurring}
                        <br/>
                        Event recurring_frequency : {event.recurring_frequency}
                        <br/>
                        Event shareeventwith : {event.shareeventwith}
                        <br/>
                        Event categoryId : {event.categoryId}
                        <br/>
                        Event email : {event.email}
                    </div>)}
            </div>
    </div>
);
}
export default GetEvents;   	
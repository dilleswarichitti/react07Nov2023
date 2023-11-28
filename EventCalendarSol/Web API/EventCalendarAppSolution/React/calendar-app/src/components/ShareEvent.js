import { useState } from "react";
import axios from "axios";

function ShareEvent(){
    const[eventId,setEventId]=useState("");
    const[string,setString]=useState("");
    var event;
    var clickAdd = (event)=>{
        event.preventDefault();
        alert('You clicked the button');
        event={
        "string":string,     
        }
        console.log(event);
        axios.post('https://localhost:7117/api//Event/ShareEvent',{
            params: {
                eventId : eventId
            },
            body:JSON.stringify(event)
        }).then(
            ()=>{
                alert("Event Shared");
            }
        ).catch((e)=>{
            console.log(e)
        })
    }

    return(
    <div className="searchBox">
      <h1 className="alert alert-success">ShareEventWith</h1>
      <form>      
        <br/>   
        <div class="row"> 
          <input id="peventid" type="text" class="form-control" value={eventId} onChange={(e)=>{setEventId(e.target.value)}}/>
        </div>
        <label className="form-control"  for="pstring">String</label>
        <input id="pstring" type="text" className="form-control" value={string} onChange={(e)=>{setString(e.target.value)}}/>
        <br/>
        <div class="row">
            <button className="btn btn-success" onClick={clickAdd}>Share Event</button>
        </div>
        </form>
    </div>
    );
}

export default ShareEvent;
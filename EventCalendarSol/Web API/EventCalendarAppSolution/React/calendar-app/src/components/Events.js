import axios from "axios";
import { useState } from "react";

function Events(){
    const [email,setEmail]=useState('');
    const [eventList,setEventList]=useState([])
    var getEvents = ()=>{
        axios.get('https://localhost:7117/api/event',{
            params: {
              Email: email
            }
        })
        .then(function(response){
            console.log(response);
            setEventList(response);
        })
        .catch(function(error){
            console.log(error);
        })
    }
    var checkEvents = eventList.length>0?true:false;
return(
        <div className="searchBox">
            <form>
                <div class="row">
                    <input id="psearch" type="text" class="form-control" value={email} onChange={(e)=>{setEmail(e.target.value)}}/>
                </div>
            </form>   
            <h1 className="alert alert-success">Events</h1>
            <button className="btn btn-success" onClick={getEvents}>Get All Events</button>

       </div>
);
}
export default Events; 
import { useState } from "react";
import './AddEvent.css';

function AddCategory(){
    const [name,setName]= useState("");
    const [color,setColor] = useState("");
    var category;
    var clickAdd = ()=>{
        alert('You clicked the button');
       category={
        "name":name,
        "color":color
        }
        console.log(category);
        fetch('https://localhost:7117/api/Category',{
            method:'POST',
            headers:{
                'Accept':'application/json',
                'Content-Type':'application/json'
            },
            body:JSON.stringify(category)
        }).then(
            ()=>{
                alert("Category Added");
            }
        ).catch((e)=>{
            console.log(e)
        })
    }

    return(
        <div className="inputcontainer">
            <h1>Category</h1>
            <br/>
            <label className="form-control" for="pname">Name</label>
            <input id="pname" type="text" className="form-control" value={name} onChange={(e)=>{setName(e.target.value)}}/>
            <br/>
            <label className="form-control" for="pcolor">Color</label>
            <input id="pcolor" type="color" className="form-control" value={color} onChange={(e) => {setColor(e.target.value)}}/>
            <br/>
            <button onClick={clickAdd} className="btn btn-primary">Add Category</button>
        </div>
    );
}

export default AddCategory;
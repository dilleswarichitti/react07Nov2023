import { useState } from "react";
import './AddEvent.css';

function AddCategory(){
    const [category,setCategory]= useState("");
    const [color,setColor] = useState("");
    var Category;
    var clickAdd = ()=>{
        alert('You clicked the button');
       Category={
        "category":category,
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
            <label className="form-control" for="pname">category</label>
            <input id="pcategory" type="text" className="form-control" value={category} onChange={(e)=>{setCategory(e.target.value)}}/>
            <br/>
            <label className="form-control" for="pcolor">Color</label>
            <input id="pcolor" type="color" className="form-control" value={color} onChange={(e) => {setColor(e.target.value)}}/>
            <br/>
            <button onClick={clickAdd} className="btn btn-primary">Add Category</button>
        </div>
    );
}

export default AddCategory;
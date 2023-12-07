import { Link } from "react-router-dom";
import './Menu.css';

function Menu(){
  const logout=()=>{
    localStorage.clear();
   // navigate('/Home');
    window.location.reload();

}
    return (
      <nav className="navbar navbar-expand-lg navbar-light bg-light">
  
        <div className="collapse navbar-collapse" id="navbarNav">
          <ul className="navbar-nav">
            {localStorage.getItem("token")? "" : <div> <li className="nav-item active">
              <Link className="nav-link" to="/" >Register</Link>
            </li><span><li className="nav-item ">
              <Link className="nav-link" to="login" >Login</Link>
            </li></span>
            </div>}
            {/* <div className="collapse navbar-collapse" id="navbarNav">
            <ul className="navbar-nav">
            <li className="nav-item active">
              <Link className="nav-link" to="/" >Register</Link>
            </li>
            <li className="nav-item ">
              <Link className="nav-link" to="login" >Login</Link>
            </li> */}
            {/* <li className="nav-item ">
              <Link className="nav-link" to="mycalendar">MyCalendar</Link>
            </li> */}
            <li className="nav-item">
              <Link className="nav-link" to="/events" >Events</Link>
            </li>
            {localStorage.getItem("token")? <li className="nav-item">
              <Link className="nav-link" to="/profile" >Profile</Link>
            </li> : "" }
            {localStorage.getItem("token")? <li className="nav-item">
            <Link class="dropdown-item" onClick={logout}>logout</Link>
            </li> :"" }
          </ul>
        </div>
      </nav>
    );
}

export default Menu;
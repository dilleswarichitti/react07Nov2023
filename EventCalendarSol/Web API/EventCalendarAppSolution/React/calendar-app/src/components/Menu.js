import { Link } from "react-router-dom";
import './Menu.css';

function Menu(){
    return (
      <nav className="navbar navbar-expand-lg navbar-light bg-light">
  
        <div className="collapse navbar-collapse" id="navbarNav">
          <ul className="navbar-nav">
            <li className="nav-item active">
              <Link className="nav-link" to="/" >Register</Link>
            </li>
            <li className="nav-item ">
              <Link className="nav-link" to="login" >Login</Link>
            </li>
            <li className="nav-item ">
              <Link className="nav-link" to="mycalendar">MyCalendar</Link>
            </li>
            <li className="nav-item">
              <Link className="nav-link" to="/events" >Events</Link>
            </li>
            <li className="nav-item">
              <Link className="nav-link" to="/categories" >Categories</Link>
            </li>
          </ul>
        </div>
      </nav>
    );
}

export default Menu;
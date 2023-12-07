import './App.css';
import { BrowserRouter, Route, Routes } from 'react-router-dom';
import Register from './components/Register';
import Events from './components/Events';
import Categories from './components/Categories';
import Menu from './components/Menu';
import Login from './components/Login';
import MyCalendar from './components/MyCalendar';
import AddCategory from './components/AddCategory';
import UserProfile from './components/UserProfile';

function App() {

  return (
    <div>
      
     <BrowserRouter>
     <Menu/>
     {localStorage.getItem("token")? <Menu/> : <Register/>} 
        <Routes>
          <Route path="register" element={<Register/>} /> 
          <Route path="login" element={<Login/>} /> 
          <Route path="events" element={<Events/>} />
          <Route path="profile" element={<UserProfile/>} />
        </Routes>  
      </BrowserRouter>
    </div>
  );
}

export default App;
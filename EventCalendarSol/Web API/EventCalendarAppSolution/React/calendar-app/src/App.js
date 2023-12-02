import './App.css';
import { BrowserRouter, Route, Routes } from 'react-router-dom';
import Register from './components/Register';
import Events from './components/Events';
import Categories from './components/Categories';
import Menu from './components/Menu';
import Login from './components/Login';
import MyCalendar from './components/MyCalendar';
import DisplayEvents from './components/DisplayEvents';
import ParentComponent from './components/ParentComponent';

function App() {

  return (
    <div>
    {/* <BrowserRouter>
      <Menu/>
        <Routes>
          <Route path="/" element={<Register/>} />
          <Route path="login" element={<Login/>} />
          <Route path="mycalendar" element={<MyCalendar/>} />
          <Route path="events" element={<Events/>} />
          <Route path="categories" element={<Categories/>} />
        </Routes>  
      </BrowserRouter> */}
      <Events/>
    </div>
  );
}

export default App;
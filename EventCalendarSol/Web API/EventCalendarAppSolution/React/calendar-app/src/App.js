
import './App.css';
import { BrowserRouter, Route, Routes } from 'react-router-dom';
import Register from './components/Register';
import Events from './components/Events';
import Categories from './components/Categories';
import Menu from './components/Menu';
import Protected from './Protected';
import AddEvent from './components/AddEvent';

function App() {

  return (
    <div>
      <BrowserRouter>
      <Menu/>
        <Routes>
          <Route path="/" element={<Register/>} />
          <Route path="events" element={<Events/>} />
          <Route path="categories" element={<Categories/>} />
          <Route path="AddEvent" element={<Protected><AddEvent/></Protected>}/>
        </Routes>  
      </BrowserRouter>
    </div>
  );
}

export default App;
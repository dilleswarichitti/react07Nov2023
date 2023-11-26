import logo from './logo.svg';
import './App.css';
import Login from './components/Login';
import Register from './components/Register';
//import GetEvents from './components/GetEvents';

function App() {
  return (
    <div className="App">
     {/* <div className="container text-center">
        <div className="row">
          <div className="col">
            <GetEvents/> 
          </div>
          <div className="col">
            <AddEvent/>
          </div>
        </div>
    </div>
      <div>
      </div>   */}
      <div>
        <Register/>
      </div>
    </div>
);
}

export default App;
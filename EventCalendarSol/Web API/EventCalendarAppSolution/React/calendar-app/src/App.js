import logo from './logo.svg';
import './App.css';
import AddCategory from './components/AddCategory';
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
        <AddCategory/>
      </div>
    </div>
);
}

export default App;
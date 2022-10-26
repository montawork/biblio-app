import './App.css';
import Register from './components/Register';
import { Routes, Route } from 'react-router-dom';
import UserDashboard from './pages/UserDashboard';
import Login from './pages/Login';

function App() {
  return (
    <div className="App">
      <Routes>
        <Route path="/" element={<Register />} />
        <Route path="/dashboard" element={<UserDashboard />} />
        <Route path="/login" element={<Login />} />
      </Routes>
    </div>
  );
}

export default App;

import React, { useState } from 'react';
import axios from 'axios';
import { useNavigate } from 'react-router-dom';

const Login = () => {
  const navigate = useNavigate();
  const [userData, setUserData] = useState({
    LoginEmail: '',
    LoginPassword: '',
  });

  const onChangeHandler = (e) => {
    setUserData({
      ...userData,
      [e.target.name]: e.target.value,
    });
  };

  const submitHandler = (e) => {
    e.preventDefault();
    axios
      .post('http://localhost:5279/api/Users/login', userData)
      .then(() => {
        navigate('/dashboard');
      })
      .catch((e) => console.log('=> ', e));
  };

  return (
    <>
      <h1>Login</h1>
      <form onSubmit={submitHandler}>
        <div>
          <label>Email</label>
          <input
            type="text"
            name="LoginEmail"
            onChange={onChangeHandler}
            value={userData.LoginEmail}
          />
        </div>
        <div>
          <label>Password</label>
          <input
            type="password"
            name="LoginPassword"
            onChange={onChangeHandler}
            value={userData.LoginPassword}
          />
        </div>
        <input type="submit" value="Login" />
      </form>
    </>
  );
};

export default Login;

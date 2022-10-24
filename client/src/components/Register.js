import React, { useState } from 'react';
import axios from 'axios';

const Register = () => {
  const [userData, setUserData] = useState({
    FirstName: '',
    LastName: '',
    Email: '',
    PhoneNumber: '',
    Score: 0,
    Cin: 0,
    Password: '',
    ConfirmPassword: '',
  });
  const [adressData, setAdressData] = useState({
    Street: '',
    City: 'Tunis',
    ZipCode: 1001,
  });

  const onChangeHandler = (e) => {
    setUserData({
      ...userData,
      [e.target.name]: e.target.value,
    });
  };

  const addressHandler = (e) => {
    setAdressData({
      ...adressData,
      [e.target.name]: e.target.value,
    });
  };

  const submitHandler = (e) => {
    e.preventDefault();
    axios
      .post('http://localhost:5279/api/Users', userData)
      .then((res) => console.log(res))
      .catch((e) => console.log('=> ', e));

    axios
      .post('http://localhost:5279/api/Addresses', adressData)
      .then((res) => console.log(res))
      .catch((e) => console.log('=> ', e));
  };

  return (
    <>
      <h1>Register</h1>
      <form onSubmit={submitHandler}>
        <div>
          <label>First Name</label>
          <input
            type="text"
            name="FirstName"
            onChange={onChangeHandler}
            value={userData.FirstName}
          />
        </div>
        <div>
          <label>Last Name</label>
          <input
            type="text"
            name="LastName"
            onChange={onChangeHandler}
            value={userData.LastName}
          />
        </div>
        <div>
          <label>Email</label>
          <input
            type="text"
            name="Email"
            onChange={onChangeHandler}
            value={userData.Email}
          />
        </div>
        <div>
          <label>PhoneNumber</label>
          <input
            type="text"
            name="PhoneNumber"
            onChange={onChangeHandler}
            value={userData.PhoneNumber}
          />
        </div>
        <div>
          <label>Score</label>
          <input
            type="number"
            name="Score"
            onChange={onChangeHandler}
            value={userData.Score}
          />
        </div>
        <div>
          <label>Cin</label>
          <input
            type="number"
            name="Cin"
            onChange={onChangeHandler}
            value={userData.Cin}
          />
        </div>
        <div>
          <label>Password</label>
          <input
            type="password"
            name="Password"
            onChange={onChangeHandler}
            value={userData.Password}
          />
        </div>
        <div>
          <label>ConfirmPassword</label>
          <input
            type="password"
            name="ConfirmPassword"
            onChange={onChangeHandler}
            value={userData.ConfirmPassword}
          />
        </div>

        <h2>Adress Section</h2>
        <div>
          <label>Street</label>
          <input
            type="text"
            name="Street"
            onChange={addressHandler}
            value={adressData.Street}
          />
        </div>
        <div>
          <label>City</label>
          <select
            name="City"
            id=""
            onChange={addressHandler}
            value={adressData.City}
          >
            <option value="Tunis">Tunis</option>
            <option value="Nabeul">Nabeul</option>
          </select>
        </div>
        <div>
          <label>Zip Code</label>
          <input
            type="number"
            name="ZipCode"
            onChange={addressHandler}
            value={adressData.ZipCode}
          />
        </div>
        <input type="submit" value="Register" />
      </form>
    </>
  );
};

export default Register;

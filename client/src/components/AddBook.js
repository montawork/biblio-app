import React, { useState, useEffect } from 'react';
import axios from 'axios';

const AddBook = () => {
  const [bookData, setBookData] = useState({
    Picture: '',
    Title: '',
    Pages: 0,
    Description: '',
    CreationDate: '',
    Author: '',
    Language: '',
  });

  const [bookCategories, setBookCategories] = useState([]);

  useEffect(() => {
    axios
      .get('http://localhost:5279/api/Categories')
      .then((res) => setBookCategories(res.data));
  }, []);

  const onChangeHandler = (e) => {
    setBookData({
      ...bookData,
      [e.target.name]: e.target.value,
    });
  };

  const submitHandler = (e) => {
    e.preventDefault();
    axios
      .post('http://localhost:5279/api/Books', bookData)
      .then((res) => console.log(res))
      .catch((e) => console.log('=> ', e));
  };

  return (
    <>
      <h1>Add Book</h1>
      <form onSubmit={submitHandler}>
        <div>
          <label>Picture</label>
          <input
            type="text"
            name="Picture"
            onChange={onChangeHandler}
            value={bookData.Picture}
          />
        </div>
        <div>
          <label>Title</label>
          <input
            type="text"
            name="Title"
            onChange={onChangeHandler}
            value={bookData.Title}
          />
        </div>
        <div>
          <label>Pages</label>
          <input
            type="number"
            name="Pages"
            onChange={onChangeHandler}
            value={bookData.Pages}
          />
        </div>
        <div>
          <label>Description</label>
          <input
            type="text"
            name="Description"
            onChange={onChangeHandler}
            value={bookData.Description}
          />
        </div>
        <div>
          <label>CreationDate</label>
          <input
            type="date"
            name="CreationDate"
            onChange={onChangeHandler}
            value={bookData.CreationDate}
          />
        </div>
        <div>
          <label>Author</label>
          <input
            type="text"
            name="Author"
            onChange={onChangeHandler}
            value={bookData.Author}
          />
        </div>
        <div>
          <label>Language</label>
          <input
            type="text"
            name="Language"
            onChange={onChangeHandler}
            value={bookData.Language}
          />
        </div>
        <select name="Category" id="">
          {bookCategories.map((category) => {
            return (
              <option key={category.categoryID} value="">
                {category.name}
              </option>
            );
          })}
        </select>
        <input type="submit" value="Register" />
      </form>
    </>
  );
};

export default AddBook;

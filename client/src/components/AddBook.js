import React, { useState, useEffect } from 'react';
import axios from 'axios';

const AddBook = () => {
  const mainStyle = {
    display: 'flex',
    gap: '50px',
    alignItems: 'center',
    justifyContent: 'center',
  };
  const [bookData, setBookData] = useState({
    Picture: '',
    Title: '',
    Pages: 0,
    Description: '',
    CreationDate: '',
    Author: '',
    Language: '',
  });

  const [myBookData, setMyBookData] = useState({
    Picture: '',
    Status: '',
    SerialNumber: 0,
    Description: '',
    UserID: 1,
    BookID: 2,
  });

  const [categoryData, setCategoryData] = useState({
    CategoryID: 1,
    BookID: 2,
  });

  const [bookCategories, setBookCategories] = useState([]);
  const [books, setBooks] = useState([]);

  useEffect(() => {
    axios
      .get('http://localhost:5279/api/Categories')
      .then((res) => setBookCategories(res.data));
  }, []);

  useEffect(() => {
    axios
      .get('http://localhost:5279/api/Books')
      .then((res) => setBooks(res.data));
  }, []);

  const onChangeHandler = (e) => {
    setBookData({
      ...bookData,
      [e.target.name]: e.target.value,
    });
  };

  const onChangeBook = (e) => {
    setMyBookData({
      ...myBookData,
      [e.target.name]: e.target.value,
    });
  };

  const onChangeCategory = (e) => {
    setCategoryData({
      ...categoryData,
      [e.target.name]: e.target.value,
    });
  };

  const submitHandler = (e) => {
    e.preventDefault();
    axios
      .post('http://localhost:5279/api/Books', bookData)
      .then((res) => console.log(res))
      .catch((e) => console.log('=> ', e));

    axios
      .post('http://localhost:5279/api/BookCategories', categoryData)
      .then((res) => console.log(res))
      .catch((e) => console.log('=> ', e));
  };

  const myBookHandler = (e) => {
    e.preventDefault();
    axios
      .post('http://localhost:5279/api/UserBooks', myBookData)
      .then((res) => console.log(res))
      .catch((e) => console.log('=> ', e));
  };

  return (
    <div style={mainStyle}>
      <div>
        <h1>Choose From Exist Books</h1>
        <form onSubmit={myBookHandler}>
          <div>
            <label>Title</label>
            <select
              name="BookID"
              value={myBookData.BookID}
              onChange={onChangeBook}
            >
              {books.map((book) => {
                return (
                  <option key={book.bookID} value={book.bookID}>
                    {book.title}
                  </option>
                );
              })}
              <option value="">Other</option>
            </select>
          </div>
          <div>
            <label>Serial Number</label>
            <input
              type="text"
              name="SerialNumber"
              onChange={onChangeBook}
              value={myBookData.SerialNumber}
            />
          </div>
          <div>
            <label>Status</label>
            <select
              name="Status"
              onChange={onChangeBook}
              value={myBookData.Status}
            >
              <option value="New">New</option>
              <option value="Midway">Midway</option>
              <option value="Ancient">Ancient</option>
            </select>
          </div>
          <div>
            <label>Copy Description</label>
            <input
              type="text"
              name="Description"
              onChange={onChangeBook}
              value={myBookData.Description}
            />
          </div>
          <div>
            <label>Copy Picture</label>
            <input
              type="text"
              name="Picture"
              onChange={onChangeBook}
              value={myBookData.Picture}
            />
          </div>
          <input type="submit" value="Add Book" />
        </form>
      </div>
      <div>
        <h1>Or Add New One</h1>
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
            <label>Category</label>
            <select
              name="CategoryID"
              onChange={onChangeCategory}
              value={categoryData.CategoryID}
            >
              {bookCategories.map((category) => {
                return (
                  <option key={category.categoryID} value={category.categoryID}>
                    {category.name}
                  </option>
                );
              })}
            </select>
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
          <input type="submit" value="Add Book" />
        </form>
      </div>
    </div>
  );
};

export default AddBook;

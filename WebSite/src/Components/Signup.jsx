import React, { useEffect, useState } from 'react';
import { AiOutlineEye, AiOutlineEyeInvisible } from "react-icons/ai";
import styles from "../Styles/Style";
import { Link, useNavigate } from "react-router-dom";
import { RxAvatar } from "react-icons/rx";

import { ToastContainer, toast } from "react-toastify";
import "react-toastify/dist/ReactToastify.css";

import axios from 'axios';

axios.defaults.xsrfHeaderName = "X-CSRFTOKEN";
axios.defaults.xsrfCookieName = "csrftoken";

const Signup = () => {
  const navigate = useNavigate();
  const [visible, setVisible] = useState(false);

  // const [url, setUrl] = useState(null);
  // const [avatar, setAvatar] = useState(null);

    const [data, setData] = useState({
        firstName: "",
        lastName: "",
        userName: "",
        fullName: "",
        password: "",
        passwordReType: "",
        email: "",
        phoneNumber: "",
        gender: "",
        role:"USER",
        hobby: ""
        // avatar: null,
        // url:null,
    });

  const handleChange = (e) => {
    const value = e.target.value;
    setData({
      ...data,
      [e.target.name]: value
    });
  };

  const handleFileInputChange = (e) => {
    const file = e.target.files[0];
    const url = URL.createObjectURL(file);
    setUrl(url);
    setAvatar(file);
  };

  const handleFormSubmit = (e) => {
    e.preventDefault();

    const userData = {
      firstName: data.firstName,
      lastName: data.lastName,
      userName: data.userName,
      fullName: data.firstName + " " + data.lastName,
      password: data.password,
      passwordReType: data.passwordReType,
      email: data.email,
      phoneNumber: data.phoneNumber,
      gender: data.gender,
      // avatar: data.avatar,
      // url: data.url,
      role:"USER",
      hobby: ""
    };

    if(data.password != data.passwordReType)
    {
      toast.error(`Password-s doesn-t match!`);      
    }
    else
    {
      axios.get('https://localhost:8080/api/v1.1/authentication/email?email=' + userData.email)
      .then(response => {
          
          if(response.data === true)
          {
            toast.error(`The "${userData.email}" already registered, Please try to different email!`);
          }
          else
          {
            axios.post('https://localhost:8080/api/v1.1/authentication/register', userData)
            .then(response => {  
  
              console.log(response);
              if(response.status === 201)
              {
                toast.success("Your account successfully created, Now login!");

                  //clean all fields
                  setData({
                      firstName: "",
                      lastName: "",
                      userName: "",
                      fullName: "",
                      password: "",
                      passwordReType: "",
                      email: "",
                      phoneNumber: "",
                      gender: "",
                      role: "USER",
                      hobby: ""
                      // avatar: null,
                      // url:null,
                  });

                navigate("/");  
              }
              else
              {
                toast.error(`Error:"${response.data}"`);
              }
            })
            .catch(error => {
              console.log(error);
            });
          }
      })
      .catch(error => {
        console.log(error);
      });
    }
  };

  return (
    <div className="min-h-screen bg-gray-50 flex flex-col justify-center py-12 sm:px-6 lg:px-8">
      <div className="sm:mx-auto sm:w-full sm:max-w-md">
        <h2 className="mt-6 text-center text-3xl font-extrabold text-gray-900">
          Register as a new user
        </h2>
      </div>
      <div className="mt-8 mx-auto w-[90%] 800px:w-[45%]">
        <div className="bg-white py-8 px-4 shadow sm:rounded-lg sm:px-10">
          <form className="space-y-6" onSubmit={handleFormSubmit}>

            <div>
              <label
                htmlFor="email"
                className="block text-sm font-medium text-gray-700">
                First Name
              </label>
              <div className="mt-1">
                <input
                  type="text"
                  name="firstName"
                  autoComplete="firstName"
                  required
                  value={data.firstName}
                  onChange={handleChange}
                  className="appearance-none block w-full px-3 py-2 border border-gray-300 rounded-md shadow-sm placeholder-gray-400 focus:outline-none focus:ring-blue-500 focus:border-blue-500 sm:text-sm"
                />
              </div>
            </div>

            <div>
              <label
                htmlFor="email"
                className="block text-sm font-medium text-gray-700">
                Last Name
              </label>
              <div className="mt-1">
                <input
                  type="text"
                  name="lastName"
                  autoComplete="lastName"
                  required
                  value={data.lastName}
                  onChange={handleChange}
                  className="appearance-none block w-full px-3 py-2 border border-gray-300 rounded-md shadow-sm placeholder-gray-400 focus:outline-none focus:ring-blue-500 focus:border-blue-500 sm:text-sm"
                />
              </div>
            </div>

            <div>
              <label
                htmlFor="email"
                className="block text-sm font-medium text-gray-700">
                Full Name
              </label>
              <div className="mt-1">
                <input
                  type="text"
                  name="fullName"
                  autoComplete="name"
                  required
                  value={data.firstName + " " + data.lastName}
                  className="appearance-none block w-full px-3 py-2 border border-gray-300 rounded-md shadow-sm placeholder-gray-400 focus:outline-none focus:ring-blue-500 focus:border-blue-500 sm:text-sm"
                  disabled
                />
              </div>
            </div>

            <div>
              <label
                htmlFor="email"
                className="block text-sm font-medium text-gray-700">
                UserName
              </label>
              <div className="mt-1">
                <input
                  type="text"
                  name="userName"
                  autoComplete="userName"
                  required
                  value={data.userName}
                  onChange={handleChange}
                  className="appearance-none block w-full px-3 py-2 border border-gray-300 rounded-md shadow-sm placeholder-gray-400 focus:outline-none focus:ring-blue-500 focus:border-blue-500 sm:text-sm"
                />
              </div>
            </div>

            <div>
              <label
                htmlFor="password"
                className="block text-sm font-medium text-gray-700">
                Password
              </label>
              <div className="mt-1 relative">
                <input
                  type={visible ? "text" : "password"}
                  name="password"
                  autoComplete="current-password"
                  required
                  value={data.password}
                  onChange={handleChange}
                  className="appearance-none block w-full px-3 py-2 border border-gray-300 rounded-md shadow-sm placeholder-gray-400 focus:outline-none focus:ring-blue-500 focus:border-blue-500 sm:text-sm"
                />
                {visible ? (
                  <AiOutlineEye
                    className="absolute right-2 top-2 cursor-pointer"
                    size={25}
                    onClick={() => setVisible(false)}
                  />
                ) : (
                  <AiOutlineEyeInvisible
                    className="absolute right-2 top-2 cursor-pointer"
                    size={25}
                    onClick={() => setVisible(true)}
                  />
                )}
              </div>
            </div>

            <div>
              <label
                htmlFor="password"
                className="block text-sm font-medium text-gray-700">
                Re-type Password
              </label>
              <div className="mt-1 relative">
                <input
                  type={visible ? "text" : "password"}
                  name="passwordReType"
                  autoComplete="current-password"
                  required
                  value={data.passwordReType}
                  onChange={handleChange}
                  className="appearance-none block w-full px-3 py-2 border border-gray-300 rounded-md shadow-sm placeholder-gray-400 focus:outline-none focus:ring-blue-500 focus:border-blue-500 sm:text-sm"
                />
                {visible ? (
                  <AiOutlineEye
                    className="absolute right-2 top-2 cursor-pointer"
                    size={25}
                    onClick={() => setVisible(false)}
                  />
                ) : (
                  <AiOutlineEyeInvisible
                    className="absolute right-2 top-2 cursor-pointer"
                    size={25}
                    onClick={() => setVisible(true)}
                  />
                )}
              </div>
            </div>

            <div>
              <label
                htmlFor="email"
                className="block text-sm font-medium text-gray-700">
                Email address
              </label>
              <div className="mt-1">
                <input
                  type="email"
                  name="email"
                  autoComplete="email"
                  required
                  value={data.email}
                  onChange={handleChange}
                  className="appearance-none block w-full px-3 py-2 border border-gray-300 rounded-md shadow-sm placeholder-gray-400 focus:outline-none focus:ring-blue-500 focus:border-blue-500 sm:text-sm"
                />
              </div>
            </div>

            <div>
              <label
                htmlFor="email"
                className="block text-sm font-medium text-gray-700">
                Phone Number
              </label>
              <div className="mt-1">
                <input
                  type="tel"
                  name="phoneNumber"
                  required
                  value={data.phoneNumber}
                  onChange={handleChange}
                  className="appearance-none block w-full px-3 py-2 border border-gray-300 rounded-md shadow-sm placeholder-gray-400 focus:outline-none focus:ring-blue-500 focus:border-blue-500 sm:text-sm"
                />
              </div>
            </div>

            <div>
              <label
                htmlFor="email"
                className="block text-sm font-medium text-gray-700">
                Gender
              </label>
              <div className="mt-1">
                <select name="gender" id="gender" required onChange={handleChange} className="appearance-none block w-full px-3 py-2 border border-gray-300 rounded-md shadow-sm placeholder-gray-400 focus:outline-none focus:ring-blue-500 focus:border-blue-500 sm:text-sm">
                  <option value="">-Select Gender-</option>
                  <option value="M">Male</option>
                  <option value="F">Female</option>
                  <option value="O">Other</option>
                </select>
              </div>
            </div>

            {/* <div className={`${styles.noramlFlex}`}>
              <span className="inline-block h-10 w-10 rounded-full overflow-hidden">
                {data.avatar ? (
                  <img
                    src={URL.createObjectURL(avatar)}
                    alt="avatar"
                    className="w-full h-full object-cover"
                  />
                ) : (
                  <RxAvatar className="w-10 h-10" />
                )}
              </span>

              <label
                htmlFor="file-input"
                className="ml-5 flex items-center justify-center px-4 py-2 border border-gray-300 rounded-md shadow-sm text-sm font-medium text-gray-700 bg-white hover:bg-gray-50">
                <span>Upload file</span>
                <input
                  type="file"
                  name="avatar"
                  id="file-input"
                  accept=".jpg,.jpeg,.png"
                  onChange={handleFileInputChange}
                  className="sr-only"
                />
              </label>
            </div> */}

            <div>
              <button
                type="submit"
                className="group relative w-full h-[40px] flex justify-center py-2 px-4 border border-transparent text-sm font-medium rounded-md text-white bg-blue-600 hover:bg-blue-700">
                Submit
              </button>

              {/* toast message */}
              <ToastContainer
                position="top-right"
                autoClose={2000}
                hideProgressBar={false}
                newestOnTop={false}
                closeOnClick
                rtl={false}
                pauseOnFocusLoss
                draggable
                pauseOnHover={false}
                theme="light"
              />
            </div>
            <div className={`${styles.noramlFlex} w-full`}>
              <h4>Already have an account?</h4>
              <Link to="/login" className="text-blue-600 pl-2">
                Sign in
              </Link>
            </div>
          </form>
        </div>
      </div>
    </div>
  );
};

export default Signup;

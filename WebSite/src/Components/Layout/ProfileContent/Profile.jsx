import React, { useState } from "react";

import avatar from "../../../Assets/avatar.jpg";
import { AiOutlineCamera } from "react-icons/ai";
import styles from "../../../Styles/Style";

import { motion } from "framer-motion";

import { ToastContainer, toast } from "react-toastify";
import "react-toastify/dist/ReactToastify.css";
import axios from 'axios';

axios.defaults.xsrfHeaderName = "X-CSRFTOKEN";
axios.defaults.xsrfCookieName = "csrftoken";

const Profile = ({ setViewProfile }) => {

  // localStorage user data
  const user = JSON.parse(localStorage.getItem("user"));

  const [photoUrl, setPhotoUrl] = useState(Number ? Number : null);
  // photo url
  const profileLogo = JSON.parse(localStorage.getItem("PhotoUrl"));

  const [data, setData] = useState({
    fullName: user.fullName,
    userName: user.userName,
    email: user.email,
    phoneNumber: user.phoneNumber,
    gender: user.gender,
    birthday: user.birthday
  });

  const handleChange = (e) => {
    const value = e.target.value;
    setData({
      ...data,
      [e.target.name]: value
    });
  };

  // handleImageChange
  const handleImageChange = (e) => {
    e.preventDefault();
    const file = e.target.files[0];
    const url = URL.createObjectURL(file);
    setPhotoUrl(url);
  };

  // handle password change
  const handlePasswordChange = (e) => {
    const value = e.target.value;
    console.log(value.length);
    if (value.legnth !== 0) {
      setPassword(value);
    }
  };

  // handle form onSubmit
  const handleSubmit = (e) => {
  e.preventDefault();

    console.log(user);

    const userUpdate = {
      id: user.id,
      gender: data.gender,
      birthday: data.birthday,
      phoneNumber: data.phoneNumber
    };

    console.log(userUpdate);

    axios.put('https://localhost:8080/api/v1.1/users/' + user.id, userUpdate)
    .then(response => {

      console.log(response.data);

      localStorage.setItem("user", JSON.stringify(user));

      toast.success("Your information update successful!");

      //window.location.reload();
    })
    .catch(error => {
      console.log(error);
    });
    
  };

  function formatDate(date) {
    var d = new Date(date),
        month = '' + (d.getMonth() + 1),
        day = '' + d.getDate(),
        year = d.getFullYear();

    if (month.length < 2) 
        month = '0' + month;
    if (day.length < 2) 
        day = '0' + day;

    return [year, month, day].join('-');
}

  return (
    <motion.div
      initial={{ opacity: 0, x: -500 }}
      animate={{ opacity: 1, x: 0 }}
      exit={{ opacity: 0, x: -500 }}>
      <div className="flex justify-center w-full">
        <div className="relative h-[150px]">
          <div className="relative h-[150px]">
            <img
              src={photoUrl ? photoUrl : profileLogo ? profileLogo : avatar}
              alt="profile/image"
              className="w-[150px] h-[150px] object-cover rounded-full border-[3px] border-[#3957db]"
              onClick={() => setViewProfile(true)}
            />

            <div className="absolute w-[30px] h-[30px] bg-[#e3e9ee] bottom-[5px] rounded-full flex items-center justify-center right-[5px] cursor-pointer">
              <input
                type="file"
                id="profile/image"
                className="hidden"
                onChange={handleImageChange}
              />

              <label htmlFor="profile/image">
                <AiOutlineCamera className="cursor-pointer" />
              </label>
            </div>
          </div>
        </div>
      </div>
      <br />
      <br />
      <div className="w-full px-5">
        <form onSubmit={handleSubmit}>
          <div className="flex w-full flex-wrap pb-3">

            {/* fullName input */}
            <div className="w-full 800px:w-[50%] pb-4">
              <label htmlFor="fullName" className="block pb-2">
                Full Name
              </label>
              <input
                type="text"
                name="fullName"
                id="fullName"
                disabled
                required
                value={data.fullName}
                onChange={handleChange}
                className={`${styles.input} !w-[95%] focus:border-[#3957db]`}
              />
            </div>

            {/* username input */}
            <div className="w-full 800px:w-[50%] pb-4">
              <label htmlFor="userName" className="block pb-2">
                User Name
              </label>
              <input
                type="text"
                name="userName"
                id="userName"
                disabled
                required
                value={data.userName}
                onChange={handleChange}
                className={`${styles.input} !w-[95%] focus:border-[#3957db]`}
              />
            </div>

            {/* email input */}
            <div className="w-full 800px:w-[50%] 800px:pb-4 pb-6">
              <label htmlFor="email" className="block pb-2">
                Email Address
              </label>
              <input
                type="email"
                name="email"
                id="email"
                value={data.email}
                required
                disabled
                onChange={handleChange}
                className={`${styles.input} !w-[95%] focus:border-[#3957db]`}
              />
            </div>

            {/* phone number input */}
            <div className="w-full 800px:w-[50%] 800px:pb-4 pb-6">
              <label htmlFor="phoneNumber" className="block pb-2">
                Phone Number
              </label>
              <input
                type="number"
                name="phoneNumber"
                id="phoneNumber"
                required
                value={data.phoneNumber}
                onChange={handleChange}
                className={`${styles.input} !w-[95%] focus:border-[#3957db]`}
              />
            </div>

              <div className="w-full 800px:w-[50%] 800px:pb-4 pb-6">
              <label htmlFor="gender" className="block pb-2">
                Gender
              </label>
                <select className={`${styles.input} !w-[95%] focus:border-[#3957db]`} value={data.gender} onChange={handleChange} name="gender" id="gender" required>
                <option value="">-Select Gender-</option>
                    <option value="M">Male</option>
                    <option value="F">Female</option>
                    <option value="O">Other</option>
                </select>
            </div>
            
            {/* birthday input */}
            <div className="w-full 800px:w-[50%] 800px:pb-4 pb-6">
              <label htmlFor="birthday" className="block pb-2">
                Birthday
              </label>
              <input
                type="date"
                name="birthday"
                id="birthday"
                required
                value={ formatDate(data.birthday) }
                onChange={handleChange}
                className={`${styles.input} !w-[95%] focus:border-[#3957db]`}
              />
            </div>

            {/* button */}
            <div
                className={`${styles.button} hover:text-white !rounded-[5px] w-[30%] transition !h-11 border bg-transparent border-[#3957db] hover:bg-[#3957db]`}>
              <button type="submit">Update</button>
            </div>
          </div>
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
        </form>
      </div>
    </motion.div>
  );
};

export default Profile;

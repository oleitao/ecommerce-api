import React, { useState, useEffect } from "react";

import styles from "../../../Styles/Style";
import { AiOutlineDelete } from "react-icons/ai";
import { Country, State } from "country-state-city";
import { motion } from "framer-motion";

import { ToastContainer, toast } from "react-toastify";
import "react-toastify/dist/ReactToastify.css";
import axios from 'axios';
import { json } from "react-router-dom";

axios.defaults.xsrfHeaderName = "X-CSRFTOKEN";
axios.defaults.xsrfCookieName = "csrftoken";

const Address = ({ setViewAddresses }) => {

    // localStorage user data
    const user = JSON.parse(localStorage.getItem("user"));

    const [country, setCountry] = useState("");
    const [city, setCity] = useState("");
    const [address1, setAddress1] = useState("");
    const [address2, setAddress2] = useState("");
    const [zipCode, setZipCode] = useState();

    useEffect(() => {

      const data = {
        id: user.id,
        tag: 'url'
      };

      axios.post('https://localhost:8080/api/v1.1/roles', data)
      .then(response => {

          axios.get('https://localhost:8080/api/v1.1/' + response.data + '/details?id=' + user.id)
          .then(response => {

            const data = JSON.parse(JSON.stringify(response.data));

            const jsonData = {
              country: data.country,
              city: data.city,
              address1: data.address1,
              address2: data.address2,
              zipCode: data.zipCode
            };

            setCountry(jsonData.country);
            setCity(jsonData.city);
            setAddress1(jsonData.address1);
            setAddress2(jsonData.address2);
            setZipCode(jsonData.zipCode);

          })
          .catch(error => {
            console.log(error);
          });

      })
      .catch(error => {
          console.log(error);
      });


    }, []);


  // handle form onSubmit
  const handleSubmit = (e) => {
    e.preventDefault();

    const userAddressUpdate = {
      country: country,
      city: city,
      address1: address1,
      address2: address2,
      zipCode: zipCode
    };

    console.log(userAddressUpdate);
    
    axios.put('https://localhost:8080/api/v1.1/users/address?id=' + user.id, userAddressUpdate)
    .then(response => {

      toast.success("Your address information update successful!");
    })
    .catch(error => {
      console.log(error);
    });
      
  };


  return (
    <motion.div
      initial={{ opacity: 0, x: -500 }}
      animate={{ opacity: 1, x: 0 }}
      exit={{ opacity: 0, x: -500 }}>
      <br />
      <br />
      <div className="w-full px-5">
      <h1 className="text-[18px] text-center 800px:text-[25px] font-[600] pb-2 text-[#000000ba]">
        Address
      </h1>
      
        <form onSubmit={handleSubmit}>
          <div className="flex w-full flex-wrap pb-3">

            {/* choose country */}
            <div className="w-full 800px:w-[50%] 800px:pb-4 pb-6">
            <label htmlFor="city" className="block pb-2">
                Country
              </label>
              <select
                className={`${styles.input} !w-[95%] focus:border-[#3957db]`}
                value={country}
                required
                onChange={(e) => setCountry(e.target.value)}>
                <option
                  value="Select your country"
                  className="w-full overflow-hidden">
                  Select your country
                </option>
                {Country?.getAllCountries().map((Country) => (
                  <option
                    value={Country.isoCode}
                    key={Country.isoCode}
                    className="w-full overflow-hidden">
                    {Country.name}
                  </option>
                ))}
              </select>
            </div>

            {/* city input */}
            <div className="w-full 800px:w-[50%] pb-4">
              <label htmlFor="city" className="block pb-2">
                City
              </label>
              <input
                type="text"
                name="city"
                id="city"
                required
                value={city}
                onChange={(e) => setCity(e.target.value)}
                className={`${styles.input} !w-[95%] focus:border-[#3957db]`}
              />
            </div>

            {/* address1 input */}
            <div className="800px:w-[100%]">
              <label htmlFor="address1" className="block text-sm font-medium text-gray-700">
                Address1
              </label>
              <input
                type="text"
                name="address1"
                id="address1"
                value={address1}
                required
                onChange={(e) => setAddress1(e.target.value)}
                className={`${styles.input} !w-[95%] focus:border-[#3957db]`}
              />
            </div>

            {/* address2 input */}
            <div className="800px:w-[100%]">
              <label htmlFor="address2" className="block text-sm font-medium text-gray-700">
              Address2
              </label>
              <input
                type="text"
                name="address2"
                id="address2"
                required
                value={address2}
                onChange={(e) => setAddress2(e.target.value)}
                className={`${styles.input} !w-[95%] focus:border-[#3957db]`}
              />
            </div>

            {/* zipCode input */}
            <div className="w-full 800px:w-[50%] 800px:pb-4 pb-6">
              <label htmlFor="zipCode" className="block pb-2">
              Zip-Code
              </label>
              <input
                type="numeric"
                name="zipCode"
                id="zipCode"
                required
                value={zipCode}
                onChange={(e) => setZipCode(e.target.value)}
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

export default Address;

import React, { useState, useEffect } from "react";
import styles from "../../../Styles/Style";
import { AiOutlineEye, AiOutlineEyeInvisible } from "react-icons/ai";
import { ToastContainer, toast } from "react-toastify";
import "react-toastify/dist/ReactToastify.css";

import { motion } from "framer-motion";

import axios from 'axios';

axios.defaults.xsrfHeaderName = "X-CSRFTOKEN";
axios.defaults.xsrfCookieName = "csrftoken";


const Inbox = () => {
  const isUser = localStorage.getItem("user");
  const [data, setData] = useState([]);
  /*
  const [data, setData] = useState({
    from: "",
    id:"",    
    message: "",
    stamp: ""
  });
*/
  const numbers = [1, 2, 3];

  useEffect(() => {

      if (isUser !== null) {
          
        const id = JSON.parse(isUser).id;
        console.log(id);

        axios.get('https://localhost:8080/api/v1.1/admins/inbox?from='+ id)
        .then(response => {
          
          setData(response.data);

          console.log(response.data);    
        })
        .catch(error => {
          console.log(error);
        });
      }

  }, []);



  return (
    <div className="w-full px-5">
      <h1 className="text-[18px] text-center 800px:text-[25px] font-[600] pb-2 text-[#000000ba]">
        Inbox
      </h1>    
      <div>
        
        <ul>
          {data.map(message => (
            <li key={message.id}>
              <p>{message.from}</p>
              {message.message}
              <br></br>
              <hr></hr>
              <br></br>
            </li>            
          ))}
        </ul>

      </div>
    </div>
  );
};

export default Inbox;

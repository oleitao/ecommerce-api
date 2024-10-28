import React, {useEffect, useState} from "react";
import { useNavigate } from "react-router-dom";

// icons
import { RxPerson } from "react-icons/rx";
import { HiOutlineShoppingBag, HiOutlineReceiptRefund } from "react-icons/hi";
import { AiOutlineLogout, AiOutlineMessage } from "react-icons/ai";
import { RiLockPasswordLine } from "react-icons/ri";
import { MdOutlineTrackChanges } from "react-icons/md";
import { TbAddressBook } from "react-icons/tb";
import { toast, ToastContainer } from "react-toastify";
import axios from 'axios';

axios.defaults.xsrfHeaderName = "X-CSRFTOKEN";
axios.defaults.xsrfCookieName = "csrftoken";

const ProfileSideBar = ({ active, setActive }) => {
  const navigate = useNavigate();

  // logout functionality
  const handleLogout = () => {
    navigate("/login");

    localStorage.clear();

    toast("Logout Success");
  };

  // localStorage user data
  const isUser = localStorage.getItem("user");
  const [profileData, setProfileData] = useState('');

  useEffect(() => {

      if (isUser !== null) {
          
        const id = JSON.parse(isUser).id;
        const data = { 
          id: id, 
          tag: 'profileSideBar' 
        };
  
        axios.post('https://localhost:8080/api/v1.1/roles', data)
        .then(response => {
    
          setProfileData(response.data.split(","));
    
        })
        .catch(error => {
          console.log(error);
        });
      }

  }, []);

  return (
    <div className="p-4 z-30 pt-8 bg-white shadow-sm rounded-[10px] w-full">
  
      { profileData.includes('profile') ? 
      <div 
        className="flex items-center mb-8 w-full cursor-pointer "
        onClick={() => setActive(1)}>
        <RxPerson size={20} color={active === 1 ? "#3957db" : ""} />
        <span
          className={`pl-3 ${
            active === 1 ? "text-[#3957db]" : ""
          } hidden 800px:block`}>
          Profile
        </span>
      </div> : <div/>
      }

      { profileData.includes('orders') ? 
        <div
        className="flex items-center mb-8 w-full cursor-pointer "
        onClick={() => setActive(2)}>
        <HiOutlineShoppingBag size={20} color={active === 2 ? "#3957db" : ""} />
        <span
          className={`pl-3 ${
            active === 2 ? "text-[#3957db]" : ""
          }  hidden 800px:block`}>
          Orders
        </span>
      </div> : <div/>
      }


      { profileData.includes('refunds') ? 
      <div
        className="flex items-center mb-8 w-full cursor-pointer "
        onClick={() => setActive(3)}>
        <HiOutlineReceiptRefund
          size={20}
          color={active === 3 ? "#3957db" : ""}
        />
        <span
          className={`pl-3 ${
            active === 3 ? "text-[#3957db]" : ""
          }  hidden 800px:block`}>
          Refunds
        </span>
      </div> : <div/>
      }

      { profileData.includes('inbox') ? 
      <div
        className="flex items-center mb-8 w-full cursor-pointer "
        onClick={() => setActive(4) || navigate("/inbox")}>
        <AiOutlineMessage size={20} color={active === 4 ? "#3957db" : ""} />
        <span
          className={`pl-3 ${
            active === 4 ? "text-[#3957db]" : ""
          }  hidden 800px:block`}>
          Inbox
        </span>
      </div> : <div/>
      }

      { profileData.includes('trackOrders') ? 
      <div
        className="flex items-center mb-8 w-full cursor-pointer "
        onClick={() => setActive(5)}>
        <MdOutlineTrackChanges
          size={20}
          color={active === 5 ? "#3957db" : ""}
        />
        <span
          className={`pl-3 ${
            active === 5 ? "text-[#3957db]" : ""
          }  hidden 800px:block`}>
          Track Orders
        </span>
      </div> : <div/>
      }

      { profileData.includes('changePassword') ? 
      <div
        className="flex items-center mb-8 w-full cursor-pointer "
        onClick={() => setActive(6)}>
        <RiLockPasswordLine size={20} color={active === 6 ? "#3957db" : ""} />
        <span
          className={`pl-3 ${
            active === 6 ? "text-[#3957db]" : ""
          }  hidden 800px:block`}>
          Change Password
        </span>
      </div> : <div/>
      }

      { profileData.includes('address') ? 
      <div
        className="flex items-center mb-8 w-full cursor-pointer "
        onClick={() => setActive(7)}>
        <TbAddressBook size={20} color={active === 7 ? "#3957db" : ""} />
        <span
          className={`pl-3 ${
            active === 7 ? "text-[#3957db]" : ""
          } hidden 800px:block`}>
          Address
        </span>
      </div> : <div/>
      }

      { profileData.includes('logout') ? 
      <div
        className="flex items-center mb-8 w-full cursor-pointer "
        onClick={() => setActive(8) || handleLogout()}>
        <AiOutlineLogout size={20} color={active === 8 ? "#3957db" : ""} />
        <span
          className={`pl-3 ${
            active === 8 ? "text-[#3957db]" : ""
          } hidden 800px:block`}>
          Logout
        </span>
      </div> : <div/>
      }

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
  );
};

export default ProfileSideBar;

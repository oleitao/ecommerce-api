import React, { useEffect, useState } from "react";
import styles from "../../Styles/Style";
import { Link } from "react-router-dom";
import ProductReview from "./ProductReview";

import { motion } from "framer-motion";

// images
import reviewImage1 from "../../Assets/reviewImage1.jpg";
import reviewImage2 from "../../Assets/reviewImage2.jpg";
import reviewImage3 from "../../Assets/reviewImage3.jpg";

import { AiFillStar, AiOutlineStar } from "react-icons/ai";
import { useNavigate, useParams } from "react-router-dom";
import axios from 'axios';

axios.defaults.xsrfHeaderName = "X-CSRFTOKEN";
axios.defaults.xsrfCookieName = "csrftoken";

const ProductDetailsInfo = ({ data }) => {
  const [active, setActive] = useState(1);
  const { id } = useParams();

  // localStorage user data
  const isUser = localStorage.getItem("user");
  const user = JSON.parse(isUser);

  const [product,setProduct] = useState(null);
  const [seller,setSeller] = useState(null);
  const [usr,setUsr] = useState(null);
  const [review,setReview] = useState(null);
  const [productsNumber, setProductsNumber] = useState(null);
  const [loaded,setLoaded] = useState(false);

  useEffect(() => {

    console.log(user);

    if(loaded === false)
    {
      axios.get('https://localhost:8080/api/v1.1/products/details?id=' + id)
      .then(prod => {
        setProduct(prod.data);

        console.log(product);
        console.log(prod.data.shop.id);

          axios.get('https://localhost:8080/api/v1.1/sellers/details?sellerId=' + prod.data.shop.id)
          .then(sell => {   
            setSeller(sell.data);            
            console.log(sell.data);

            axios.get('https://localhost:8080/api/v1.1/users/details?id=' + sell.data.userId)
            .then(response => {   
              setUsr(response.data);              
              console.log(response.data);
  
              axios.get('https://localhost:8080/api/v1.1/reviews/product?id=' + id)
              .then(rev => {   
                setReview(rev.data);
                
                console.log(rev.data);
    
                axios.get('https://localhost:8080/api/v1.1/users/numberproducts?shopId=' + sell.data.userId)
                .then(num => {   
                  setProductsNumber(num.data);
                  
                  console.log(num.data);
      
                  setLoaded(true);
                })
                .catch(error => {
                  console.log(error);
                }); 

              })
              .catch(error => {
                console.log(error);
              }); 
              

            })
            .catch(error => {
              console.log(error);
            }); 

          })
          .catch(error => {
            console.log(error);
          }); 
        
      })
      .catch(error => {
        console.log(error);
      });
    }   
    
});

  return (
    <div className="bg-[#f5f6fb] px-3 py-2 800px:px-10 rounded mt-10">
      <div className="flex items-center justify-between w-full border-b pt-10 pb-2 ">
        <div className="relative">
          <h5
            className="text-[18px] px-1 leading-5 text-[#000] font-[600] cursor-pointer 800px:text-[20px]"
            onClick={() => setActive(1)}>
            Product Details
          </h5>
          {active === 1 ? (
            <div className={`${styles.active_indicator}`} />
          ) : null}
        </div>

        <div className="relative">
          <h5
            className="text-[18px] px-1 leading-5 text-[#000] font-[600] cursor-pointer 800px:text-[20px]"
            onClick={() => setActive(2)}>
            Product Reviews
          </h5>
          {active === 2 ? (
            <div className={`${styles.active_indicator}`} />
          ) : null}
        </div>

        <div className="relative">
          <h5
            className="text-[18px] px-1 leading-5 text-[#000] font-[600] cursor-pointer 800px:text-[20px]"
            onClick={() => setActive(3)}>
            Seller Information
          </h5>
          {active === 3 ? (
            <div className={`${styles.active_indicator}`} />
          ) : null}
        </div>
      </div>

      {active === 1 ? (
        <motion.div
          initial={{ opacity: 0, y: -50 }}
          animate={{ opacity: 1, y: 0 }}
          exit={{ opacity: 0, y: -50 }}
          transition={{ duration: 0.6 }}
          className="mt-5">
          <p className="text-[18px] pb-5 py-2 whitespace-pre-line leading-8">
            { loaded ? product.description : "" }
          </p>
        </motion.div>
      ) : null}

      {active === 2 ? (
        <>
        {review?.map((item, index) => (
            

            <motion.div initial="0" animate="1" exit="0" transition="0.6">
            <ProductReview
              authorName="Naim Mia"
              reviewImage={reviewImage2}
              comment={ item.comment }
              thardStar={
                <AiFillStar
                  size={ 20 }
                  color="#f6Ba00"
                  className="mr-2 cursor-pointer"
                />
              }
              fourthStar={
                <AiFillStar
                  size={ 20 }
                  color="#f6Ba00"
                  className="mr-2 cursor-pointer"
                />
              }
              fifthStar={
                <AiFillStar
                  size={ 20 }
                  color="#f6Ba00"
                  className="mr-2 cursor-pointer"
                />
              }
              publishDate="3 day ago"
            />
          </motion.div>

        ))}
        </>
      ) : null}

      {active === 3 ? (
        <div className="w-full block 800px:flex pt-5 pb-6">
          <motion.div
            initial={{ opacity: 0, x: -30 }}
            animate={{ opacity: 1, x: 0 }}
            exit={{ opacity: 0, x: -30 }}
            transition={{ duration: 0.6 }}
            className="w-full 800px:w-[50%]">
            <div className="flex items-center">
              <img
                src={data.shop.shop_avatar.url}
                alt="avatar/image"
                className="w-[50px] h-[50px] rounded-full"
              />

              <div className="pl-3">
                <h3 className={`${styles.shop_name}`}>{data.shop.name}</h3>
                <h5 className="text-[15px] pb-2">{data.shop.ratings}</h5>
              </div>
            </div>
            <p className="mt-4">
              {seller.shopDescription}
            </p>
          </motion.div>

          <motion.div
            initial={{ opacity: 0, x: 30 }}
            animate={{ opacity: 1, x: 0 }}
            exit={{ opacity: 0, x: 30 }}
            transition={{ duration: 0.6 }}
            className="w-full 800px:w-[50%] mt-5 800px:mt-0 800px:flex items-end  flex-col">
            <div className="text-left">
              <h5 className="font-[700]">
                Joined on: <span className="font-[500]">{ loaded ? usr.birthday : "" }</span>                
              </h5>

              <h5 className="font-[700] pt-3">
                Total Products: <span className="font-[500]">{ productsNumber }</span>
              </h5>

              <h5 className="font-[700] pt-3">
                Total Reviews: <span className="font-[500]">{ review.length }</span>
              </h5>

              <Link to="/shop">
                <button
                  className={`${styles.button} !h-11 !rounded text-white !mt-3`}>
                  Visit Shop
                </button>
              </Link>
            </div>
          </motion.div>
        </div>
      ) : null}
    </div>
  );
};

export default ProductDetailsInfo;

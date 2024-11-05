import React, { useEffect, useState } from "react";
import Header from "../Components/Layout/Header";
import { useSearchParams } from "react-router-dom";
import Product from "../Components/Layout/Product";
import Footer from "../Components/Layout/Footer";
import styles from "../Styles/Style";

import { motion } from "framer-motion";
import axios from 'axios';

axios.defaults.xsrfHeaderName = "X-CSRFTOKEN";
axios.defaults.xsrfCookieName = "csrftoken";

const ProductPage = () => {
  const [searchParams] = useSearchParams();
  const categoryData = searchParams.get("category");
  const [data, setData] = useState();
  const [images, setImages] = useState();
  const [shops, setShops] = useState();
  
  // localStorage user data
  const isUser = localStorage.getItem("user");
  
  useEffect(() => {
    window.scrollTo(0, 0);
  }, []);

  useEffect(() => {

    axios.get('https://localhost:8080/api/v1.1/products/top')
    .then(response => {

      const productData = JSON.parse(JSON.stringify(response.data));

      if (categoryData === null) {
        const d = productData.sort((a, b) => a.total_sell - b.total_sell);
        setData(d);
      } else {
        const d = productData.filter((productData) => productData.category === categoryData);
        setData(d);
      }
      
    })
    .catch(error => {
      console.log(error);
    });

  }, []);

  return (
    <>
      <Header activeHeading={3} />

      <motion.div
        initial={{ opacity: 0, x: -500 }}
        animate={{ opacity: 1, x: 0 }}
        exit={{ opacity: 0, x: -500 }}
        transition={{ duration: 0.5 }}
        className={styles.section}>
        <div className="grid grid-cols-1 gap-[20px] md:grid-cols-2 md:gap-[25px] lg:grid-cols-4 lg:gap-[25px] xl:grid-cols-5 xl:gap-[30px] mb-12 border-0 mt-12">
          {data?.map((item, index) => (
            <Product data={item} key={index} />
          ))}
        </div>

        {data?.length === 0 ? (
          <h1 className="text-center font-bold md:text-2xl text-gray-600 mb-16">
            Product not found!
          </h1>
        ) : null}
      </motion.div>

      <Footer />
    </>
  );
};

export default ProductPage;

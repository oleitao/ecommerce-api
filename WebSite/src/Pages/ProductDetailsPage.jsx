import React, { useEffect, useState } from "react";
import styles from "../Styles/Style";
import { useNavigate, useParams } from "react-router-dom";
import Header from "../Components/Layout/Header";
import Footer from "../Components/Layout/Footer";
import ProductDetails from "../Components/Layout/ProductDetails";
import SuggestedProduct from "../Components/Layout/SuggestedProduct";

import axios from 'axios';

axios.defaults.xsrfHeaderName = "X-CSRFTOKEN";
axios.defaults.xsrfCookieName = "csrftoken";

const ProductDetailsPage = () => {
  const { id } = useParams();
  const [data, setData] = useState(null);
  const [productData, setProductData] = useState(null);
  
  const productId = id;



  useEffect(() => {

      if(productData === null)
      {
        axios.get('https://localhost:8080/api/v1.1/products/details?id=' + productId)
        .then(response => {
          setProductData(response.data);
  
          setData(data);
        })
        .catch(error => {
          console.log(error);
        });
      }     
      
  });

  useEffect(() => {
    window.scrollTo(0, 0);
  }, []);

  return (
    <>
      <Header />
      <ProductDetails data={data} />
      {data && <SuggestedProduct data={data} />}
      <Footer />
    </>
  );
};

export default ProductDetailsPage;

import React, { useEffect, useState } from 'react';
import styles from "../../Styles/Style";
import { brandingData } from "../../Static/data";
import { useNavigate } from "react-router-dom";
import axios from 'axios';

axios.defaults.xsrfHeaderName = "X-CSRFTOKEN";
axios.defaults.xsrfCookieName = "csrftoken";

const Categories = () => {
  const Navigate = useNavigate();

  const [categoriesData, setCategoriesData] = useState('');
  useEffect(() => {
    axios.get('https://localhost:8080/api/v1.1/categories')
      .then(response => {
        setCategoriesData(response.data);
        //console.log(response.data);
      })
      .catch(error => {
        console.log(error);
      });
  }, []);
  
  return (
    <>
      <div className={`${styles.section} hidden sm:block`}>
        <div className="flex justify-between items-center w-full rounded-md bg-white my-12 p-5 shadow-sm">
          {brandingData &&
            brandingData.map((data, index) => (
              <div className="flex items-start" key={index}>
                {data.icon}

                <div className="px-3">
                  <h3 className="text-sm font-bold md:text-base">
                    {data.title}
                  </h3>
                  <p className="text-xs md:text-sm">{data.Description}</p>
                </div>
              </div>
            ))}
        </div>
      </div>

      {/* categories */}
      <div
        className={`${styles.section} bg-white mb-12 p-6 rounded-lg`}
        id="categories">
        <div className="grid grid-cols-1 gap-[5px] md:grid-cols-2 md:gap-[10px] lg:grid-cols-4 lg:gap-[20px] xl:grid-cols-5 xl:gap-[30px]">
         {categoriesData &&
            categoriesData.map((data) => {
              const handleSubmit = (data) => {
                Navigate(`/products?category=${data.title}`);
              };

              return (
                <div
                  className="w-full h-[100px] flex  items-center justify-between cursor-pointer overflow-hidden"
                  key={data.id}
                  onClick={() => handleSubmit(data)}>
                  <h4 className="text-[18px] leading-[1.2]">{data.title}</h4>
                  <img
                    src={data.image_Url}
                    alt="product/image"
                    className="w-[120px] object-cover"
                  />
                </div>
              );
            })}
        </div>
      </div>
    </>
  );
};

export default Categories;

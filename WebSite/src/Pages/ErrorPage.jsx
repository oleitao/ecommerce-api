import React from "react";

//import gif from "../../../../Assets/processing.gif";
import gif from "../../src/assets/processing.gif";

const ErrorPage = () => {
  return (
    <div className="w-full flex items-center flex-col justify-center h-full">
      <img src={gif} alt="image" className="w-[150px] h-[150px]" />
      <h1 className="text-4xl font-[700]">Error</h1>
    </div>
  );
};

export default ErrorPage;
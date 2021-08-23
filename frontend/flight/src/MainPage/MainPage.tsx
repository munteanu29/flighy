import React, { Component, useState } from "react";
import { useEffect } from "react";
import { Header } from "../Header/Header";
import "../MainPage/MainPage.css";

const MainPage = () => {
  const [selectedPage, setSelectedPage] = useState();
  useEffect(() => {
    console.log(selectedPage);
  }, [selectedPage]);
  return (
    <div>
      <div></div>
      <div>
        <Header setSelectedPage={setSelectedPage} />
      </div>
      <div></div>
    </div>
  );
};

export default MainPage;

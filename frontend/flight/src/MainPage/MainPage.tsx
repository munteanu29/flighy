import Grid from "@material-ui/core/Grid";
import React, { Component, useState } from "react";
import { useEffect } from "react";
import { Header } from "../Header/Header";
import "../MainPage/MainPage.css";
import { ProductCard } from "../Product/ProductCard";
import { ProductPage } from "../Product/ProductPage";
import { UserPage } from "../User/UserPage";

const MainPage = () => {
  const [selectedPage, setSelectedPage] = useState(1);

  return (
    <div className="body">
      <div>
        <Header setSelectedPage={setSelectedPage} />
      </div>
      <div>{selectedPage == 1 && <UserPage />}</div>
      <div>{selectedPage == 2 && <ProductPage />}</div>
    </div>
  );
};

export default MainPage;

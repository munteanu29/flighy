import Grid from "@material-ui/core/Grid";
import React, { Component, FC, useState } from "react";
import { useHistory } from "react-router-dom";
import { Header } from "../Header/Header";
import "../MainPage/MainPage.css";
import { ProductCard } from "../Product/ProductCard";
import { ProductPage } from "../Product/ProductPage";
import { UserPage } from "../User/UserPage";
export interface MainPageProps {
  selectedPage: number;
}
const MainPage: FC<MainPageProps> = ({ selectedPage }) => {
  return (
    <div className="body">
      <div>{selectedPage == 1 && <UserPage />}</div>
      <div>{selectedPage == 2 && <ProductPage />}</div>
    </div>
  );
};

export default MainPage;

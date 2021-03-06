import React from "react";
import ReactDOM from "react-dom";
import App from "./App";
import "./index.css";
import MainPage from "./MainPage/MainPage";
import { BrowserRouter as Router, Route } from "react-router-dom";
import reportWebVitals from "./reportWebVitals";
import { Dummy } from "./Dummy";
import { Header } from "./Header/Header";

ReactDOM.render(
  <React.StrictMode>
    <App />
  </React.StrictMode>,
  document.getElementById("root")
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();

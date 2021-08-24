import { useState } from "react";
import { BrowserRouter as Router, Route, useHistory } from "react-router-dom";
import { Dummy } from "./Dummy";
import { Header } from "./Header/Header";
import MainPage from "./MainPage/MainPage";

export default function App() {
  const [selectedPage, setSelectedPage] = useState(1);
  return (
    <>
      <Router>
        <Header setSelectedPage={setSelectedPage} />
        <Route path="/artist" component={Dummy} />
        <Route
          path="/Main"
          children={<MainPage selectedPage={selectedPage} />}
        />
      </Router>
    </>
  );
}

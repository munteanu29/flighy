import "./Header.css";
import logo from "../Header/logo.png";


export const Header = () => {
  return (
    <div>
      <div className="col-md-4">
        <img src={logo} className="logo"></img>
        <div className="mainButtons">
          <button className="mainButton"> Marketplace </button>
          <button className="mainButton"> Artisti </button>
        </div>
      </div>
    </div>
  );
};
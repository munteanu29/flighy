import { FC } from "react";
import "./Header.css";

export interface HeaderProps {
  setSelectedPage: any;
}
export const Header: FC<HeaderProps> = ({ setSelectedPage }) => {
  const changePage = (id: any) => {
    setSelectedPage(id);
  };
  return (
    <div>
      <div className="col-md-4">
        <div className="mainButtons">
          <button
            className="mainButton"
            onClick={() => {
              changePage(1);
            }}
          >
            Marketplace
          </button>
          <button
            className="mainButton"
            onClick={() => {
              changePage(2);
            }}
          >
            Artisti
          </button>
        </div>
      </div>
    </div>
  );
};

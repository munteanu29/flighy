import { FC } from "react";

import "../User/Card.css";
export interface ProductCardProps {
  id: number;
  price: number;
  avatar: string;
  description: string;
  category: string;
  name: string;
  artistId: number;
}

export const ProductCard: FC<ProductCardProps> = ({
  id,
  price,
  avatar,
  description,
  category,
  name,
  artistId,
}) => {
  return (
    // <div className="container">
    <div className="card">
      <div className="card-header">
        <img
          // src="https://c0.wallpaperflare.com/preview/483/210/436/car-green-4x4-jeep.jpg"
          src={avatar}
          alt="rover"
        />
      </div>
      <div className="card-body">
        <span className="tag tag-teal">{category}</span>
        <h4>{name}</h4>
        <p>{description}</p>
        <div className="price">Price: {price} RON</div>
      </div>
    </div>
    // </div>
  );
};

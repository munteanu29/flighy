import { FC, useEffect } from "react";
import AddShoppingCartIcon from "@material-ui/icons/AddShoppingCart";
import { useHistory } from "react-router-dom";
import IconButton from "@material-ui/core/IconButton";
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
    <div className="card">
      <div className="card-header">
        <img src={avatar} alt={name} />
      </div>
      <div className="card-body">
        <span className="tag tag-teal">{category}</span>
        <h4>{name}</h4>
        <p>{description}</p>
        <div className="price">Price: {price} RON</div>
      </div>
      <div className="">
        <IconButton color="primary" aria-label="add to shopping cart">
          <AddShoppingCartIcon />
        </IconButton>
      </div>
    </div>
  );
};

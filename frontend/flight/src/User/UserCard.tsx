import { FC } from "react";
import "./UserCard.css";

export interface UserCardProps {
  id: number;
  avatar: string;
  description: string;
  category: string;
  firstName: string;
  lastName: string;
}

export const UserCard: FC<UserCardProps> = ({
  id,
  avatar,
  description,
  category,
  firstName,
  lastName,
}) => {
  return (
    <div className="container">
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
          <h4>
            {firstName} {lastName}
          </h4>
          <p>{description}</p>
        </div>
      </div>
    </div>
  );
};

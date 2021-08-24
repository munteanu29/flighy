import { FC } from "react";
import { useHistory } from "react-router-dom";
import "./Card.css";

export interface UserCardProps {
  id: string;
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
  let history = useHistory();
  const handleHistory = () => history.push(`/artist/${id}`);
  return (
    <div className="card" onClick={handleHistory}>
      <div className="card-header">
        <img src={avatar} alt={firstName + " " + lastName} />
      </div>
      <div className="card-body">
        <span className="tag tag-teal">{category}</span>
        <h4>
          {firstName} {lastName}
        </h4>
        <p>{description}</p>
      </div>
    </div>
  );
};

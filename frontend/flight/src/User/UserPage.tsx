import Grid from "@material-ui/core/Grid";
import axios from "axios";
import { useEffect, useState } from "react";
import { GetArtists } from "../Api-Service";
import { ProductCard } from "../Product/ProductCard";

export const UserPage = () => {
  const [artists, setArtists] = useState([]);

  useEffect(() => {
    const artist = GetArtists();
  }, []);

  return <div>Nothing here</div>;
};

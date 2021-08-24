import Grid from "@material-ui/core/Grid";
import { useHistory } from "react-router-dom";
import { ProductCard } from "./ProductCard";

export const ProductPage = () => {
  const history = useHistory();

  return (
    <Grid container spacing={3}>
      <Grid item sm={6} md={4}>
        <ProductCard
          id={1}
          artistId={1}
          avatar={
            "https:c0.wallpaperflare.com/preview/483/210/436/car-green-4x4-jeep.jpg"
          }
          name={"Monalisa"}
          price={10000000}
          category={"Painting"}
          description={
            "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."
          }
        />
      </Grid>
      <Grid item sm={6} md={4}>
        <ProductCard
          id={1}
          artistId={1}
          avatar={
            "https:c0.wallpaperflare.com/preview/483/210/436/car-green-4x4-jeep.jpg"
          }
          name={"Monalisa"}
          price={10000000}
          category={"Painting"}
          description={
            "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."
          }
        />
      </Grid>
      <Grid item sm={6} md={4}>
        <ProductCard
          id={1}
          artistId={1}
          avatar={
            "https:c0.wallpaperflare.com/preview/483/210/436/car-green-4x4-jeep.jpg"
          }
          name={"Monalisa"}
          price={10000000}
          category={"Painting"}
          description={
            "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."
          }
        />
      </Grid>
      <Grid item sm={6} md={4}>
        <ProductCard
          id={1}
          artistId={1}
          avatar={
            "https:c0.wallpaperflare.com/preview/483/210/436/car-green-4x4-jeep.jpg"
          }
          name={"Monalisa"}
          price={10000000}
          category={"Painting"}
          description={
            "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."
          }
        />
      </Grid>
      <Grid item sm={6} md={4}>
        <ProductCard
          id={1}
          artistId={1}
          avatar={
            "https:c0.wallpaperflare.com/preview/483/210/436/car-green-4x4-jeep.jpg"
          }
          name={"Monalisa"}
          price={10000000}
          category={"Painting"}
          description={
            "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."
          }
        />
      </Grid>
    </Grid>
  );
};

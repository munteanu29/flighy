import axios from "axios";

const sendRequest = (method: "get" | "post", url: string, data?: any) =>
  axios({
    method,
    url: url,
    ...(data && { data }),
  });
export const GetArtists = async () =>
  sendRequest("get", "http://localhost:5000/api/Artist/GetArtists");

import axios from "axios";

const sendRequest = (method: "get" | "post", url: string, data?: any) =>
  axios({
    method,
    url: url,
    ...(data && { data }),
    mode: "no-cors",
    headers: {
      "Access-Control-Allow-Origin": "*",
      "Content-Type": "application/json",
    },
    withCredentials: true,
    credentials: "same-origin",
  });
export const GetArtists = async () =>
  sendRequest("get", "http://localhost:5000/api/Artist/GetArtists");

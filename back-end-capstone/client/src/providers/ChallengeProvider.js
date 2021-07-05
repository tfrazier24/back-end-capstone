import React, { useState, useContext } from "react";
// import { Spinner } from "reactstrap";
import firebase from "firebase/app";
import "firebase/auth";
import { UserContext } from "./UserProvider";

export const ChallengeContext = React.createContext();

export function ChallengeProvider(props){
//   const apiUrl = "/api/challenge";

  const { getToken } = useContext(UserContext);

  const [challenge, setChallenges] = useState([]);

  const getChallengeByLevelId = (id) => {
    return getToken().then((token) =>
      fetch(`/api/challenge/${id}`, {
        headers: {
          Authorization: `Bearer ${token}`,
        },
      })
        .then((res) => res.json())
        .then(setChallenges)
    );
  };

  return (
    <ChallengeContext.Provider
      value={{
      challenge, getChallengeByLevelId
      }}
    >
      {props.children}
    </ChallengeContext.Provider>
  );
}
import React, { useContext, useEffect, useState } from "react";
import { ChallengeContext } from "../providers/ChallengeProvider";
import Challenge from "./Challenge";
// import { useHistory } from "react-router-dom";

const BeginnerPhase = () => {
//   const history = useHistory();
  const { challenge, getChallengeByLevelId } = useContext(ChallengeContext);

  useEffect(() => {
    getChallengeByLevelId(1);
  }, []);

//   function handleClick() {
//     history.push("/category/create");
//   }

  return (
    <div className="container">
      {/* <div>
        <button className="btn btn-primary" onClick={handleClick}>
          Create Category
        </button>
      </div> */}
      <div className="row justify-content-center">
        <div className="cards-column">
          {challenge.map((singleChallenge) => (
              <Challenge key={singleChallenge.id} singleChallenge={singleChallenge} />
            ))}
        </div>
      </div>
    </div>
  );
};

export default BeginnerPhase;

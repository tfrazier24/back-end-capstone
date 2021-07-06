import React, { useContext, useEffect, useState } from "react";
import { Card, CardImg, CardBody } from "reactstrap";
import { useHistory, useParams } from "react-router-dom";

export default function Challenge(singleChallenge) {
  //   const { challengeId } = useParams();
  const history = useHistory();

    function handleClick() {
      history.push("/challenge/attemptForm");
    }

  return (
    <Card className="m-4">
      <p className="text-left px-2">{singleChallenge.singleChallenge.name}</p>
      <p className="text-left px-2">
        {singleChallenge.singleChallenge.description}
      </p>
      <button onClick={handleClick} >Record Attempt </button>
    </Card>
  );
}

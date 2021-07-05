import React, { useContext } from "react";
import { Switch, Route, Redirect } from "react-router-dom";
import { UserContext } from "./providers/UserProvider";
// import { ChallengeContext } from "./providers/ChallengeProvider";
import BeginnerPhase from "./components/BeginnerPhaseList";
import WelcomeMessage from "./WelcomeMessage";
import Login from "./components/Login";
import Register from "./components/Register";


export default function ApplicationViews() {
  const { isLoggedIn } = useContext(UserContext);

  return (
    <main>
      <Switch>
        <Route path="/" exact>
          {isLoggedIn ? <WelcomeMessage /> : <Redirect to="/login" />}
        </Route>
        <Route path="/" exact>
          {isLoggedIn ? <BeginnerPhase /> : <Redirect to="/login"/>}
        </Route>

        <Route path="/login">
          <Login />
        </Route>

        <Route path="/register">
          <Register />
        </Route>
      </Switch>
    </main>
  );
}

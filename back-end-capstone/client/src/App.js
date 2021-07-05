import React from "react";
import { BrowserRouter as Router } from "react-router-dom";
import "./App.css";
import { UserProvider } from "./providers/UserProvider";
import Header from "./components/Header";
import ApplicationViews from "./ApplicationViews";
import { ChallengeProvider } from "./providers/ChallengeProvider";
import BeginnerPhase from "./components/BeginnerPhaseList";

function App() {
  return (
    <Router>
      <UserProvider>
        <ChallengeProvider>
          <Header />
          <BeginnerPhase />
          <ApplicationViews />
        </ChallengeProvider>
      </UserProvider>
    </Router>
  );
}

export default App;

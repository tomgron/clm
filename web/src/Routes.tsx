import React from "react";
import { BrowserRouter as Router, Route, Link } from "react-router-dom";

export const Routes = (props:any) => (
  <Router>
    <Route children={props.children} />
  </Router>
)

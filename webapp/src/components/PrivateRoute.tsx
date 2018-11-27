import { Route, Redirect } from "react-router-dom";
import React, { Component } from "react";
import { inject, observer } from "mobx-react";
import Login from "../pages/Login";

@inject("allStores")
@observer
class PrivateRoute extends Component<any, any> {
  render() {
    const { component: Component, ...rest } = this.props;
    const { ...stores } = this.props.allStores;

    return (
      <Route
        {...rest}
        render={props => {
          stores.userStore.loggedInReturnUrl = this.props.path;

          return stores.userStore.loggedInUser ? <Component {...props} /> : <Login />;
        }}
      />
    );
  }
}

export default PrivateRoute;

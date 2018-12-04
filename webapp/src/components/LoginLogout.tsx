import React, { Component } from "react";
import { inject, observer } from "mobx-react";
import { allStores } from "../store";
import { Link } from "react-router-dom";

@inject("allStores")
@observer
export default class LoginLogout extends Component<any, any> {
  render() {
    const { ...store } = this.props.allStores;

    const logout = () => store.userStore.logout();

    return store.userStore.loggedInUser ? (
      <Link to="#" onClick={logout}>
        Logout
      </Link>
    ) : (
      <Link to="/login">Login</Link>
    );
  }
}

import React, { Component } from "react";
import { inject, observer } from "mobx-react";
import { allStores } from "../store";
import { Link } from "react-router-dom";
import auth0 from "auth0-js";

@inject("allStores")
@observer
export default class LoginLogout extends Component<any, any> {
  render() {
    const { ...store } = this.props.allStores;

    const logout = () => store.userStore.logout();

    const auth = new auth0.WebAuth({
      domain: "clmauth.eu.auth0.com",
      clientID: "ia8aukJCf48sPHWB6uCAjkOlW-lhtCq4",
      redirectUri: "http://localhost:3000/callback",
      responseType: "token id_token",
      scope: "openid"
    });

    const doLogin = () => {
      auth.authorize();
    };

    return store.userStore.loggedInUser ? (
      <Link to="#" onClick={logout}>
        Logout
      </Link>
    ) : (
      <Link to="#" onClick={doLogin}>
        Login
      </Link>
    );
  }
}

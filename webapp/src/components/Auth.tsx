import auth0 from "auth0-js";
import React, { Component } from "react";
import { Redirect } from 'react-router'

export class Auth extends Component<any, any, any> {
  render() {
    const auth = new auth0.WebAuth({
      domain: "clmauth.eu.auth0.com",
      clientID: "ia8aukJCf48sPHWB6uCAjkOlW-lhtCq4",
      redirectUri: "http://localhost:3000/callback",
      responseType: "token id_token",
      scope: "openid"
    });

    const ret = auth.parseHash((err, authResult) => {
      if (authResult && authResult.accessToken && authResult.idToken) {
        localStorage.setItem("access_token", authResult.accessToken);
        localStorage.setItem("id_token", authResult.idToken);
        localStorage.setItem("expires_at", authResult.expiresAt);

        return <Redirect to="/" />;
      } else if (err) {
        return <div>Error in login</div>
      }
    });

    console.log(ret)
    return ret;

  }
}

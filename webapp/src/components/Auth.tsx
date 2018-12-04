import auth0 from "auth0-js";
import React, { Component } from "react";

export class Auth extends Component<any, any, any> {
  render() {
    const auth = new auth0.WebAuth({
      domain: "clmauth.eu.auth0.com",
      clientID: "ia8aukJCf48sPHWB6uCAjkOlW-lhtCq4",
      redirectUri: "http://localhost:3000/callback",
      responseType: "token id_token",
      scope: "openid"
    });

    auth.parseHash((err, authResult) => {
      if (authResult && authResult.accessToken && authResult.idToken) {
        console.log("wohoo", authResult);
        console.log(authResult.idToken.toString());
        localStorage.setItem("access_token", authResult.accessToken);
        localStorage.setItem("id_token", authResult.idToken);
        localStorage.setItem("expires_at", authResult.expiresAt);
        //setSession(authResult);
        //history.replace('/home');
      } else if (err) {
        //history.replace('/home');
        console.log(err);
      }
    });

    return null;
  }
}

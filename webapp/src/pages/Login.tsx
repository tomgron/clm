import React, { Component } from "react";
import { inject, observer } from "mobx-react";
import { Redirect } from "react-router-dom";

@inject("allStores")
@observer
export default class Login extends Component<any, any> {
  constructor(props) {
    super(props);
    this.state = {
      redirectToReferrer: false
    };
  }

  render() {
    const { ...store } = this.props.allStores;

    const login = (e: any) => {
      e.preventDefault();
      store.userStore.login("foo", "bar")
      this.setState({
        redirectToReferrer: true
      });
    };

    if (this.state.redirectToReferrer === true) {
      const returnUrl = store.userStore.loggedInReturnUrl ? store.userStore.loggedInReturnUrl : "/";

      return <Redirect to={store.userStore.loggedInUser ? returnUrl : "/"} />;
    } else {
      return (
        <div>
          <div>username</div>
          <div>password</div>
          <button onClick={login}>login</button>
        </div>
      );
    }
  }
}

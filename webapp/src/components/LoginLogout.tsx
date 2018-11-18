import React, { Component } from "react";
import { inject, observer } from "mobx-react";
import { allStores } from "../store";
import { Link } from "react-router-dom";

@inject("allStores")
@observer
export default class LoginLogout extends Component<any, any> {
    render() {
        const {...userStore} = this.props.allStores

        return userStore.loggedInUser ? <div>Logout</div> : <Link to="/login">Login</Link>;
  }
}

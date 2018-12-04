import React, { Component } from "react";
import { AllStoresInterface } from "../store";
import { UserInterface, User, UserStoreInterface } from "../store/userStore";
import { inject, observer } from "mobx-react";
import "./Header.scss";
import LoginLogout from "./LoginLogout";

@inject("allStores")
@observer
export default class Header extends Component<any, any> {
  render() {

    const { ...store } = this.props.allStores;

    console.log(store);

    return (
      <div className="header-container">
        <div>CERTIFICATE LIFECYCLE MANAGER</div>
        <div className="options">
          <div>LoggedinUser {store.userStore.loggedInUser !== null ? <span>someone</span> : <span>foo</span>} | <LoginLogout /></div>
        </div>
      </div>
    );
  }
}

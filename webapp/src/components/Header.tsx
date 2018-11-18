import React, { Component } from "react";
import { AllStoresInterface } from "../store";
import { UserInterface, User, UserStoreInterface } from "../store/userStore";
import { inject, observer } from "mobx-react";
import "./Header.scss";

@inject("allStores")
@observer
export default class Header extends Component<any, any> {
  render() {
    return <div className="header-container">HEADER AREA - LOGGED IN USER?</div>;
  }
}

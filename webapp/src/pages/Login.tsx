import React, { Component } from "react";
import { AllStoresInterface } from "../store";
import { UserInterface, User, UserStoreInterface } from "../store/userStore";
import { inject, observer } from "mobx-react";

@inject("allStores")
@observer
export default class Login extends Component<any> {
  render() {
    return <div>LOGIN PAGE</div>;
  }
}

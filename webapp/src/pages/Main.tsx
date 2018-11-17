import React, { Component } from "react";
import { IAllStores } from "../store";
import { IUser, User, IUserStore } from "../store/userStore";
import { inject, observer } from "mobx-react";
import { ICertificate } from "../store/certificateStore";
import Certificate from "../components/Certificate";

@inject("allStores")
@observer
export default class Main extends Component<any, any> {
  render() {
    const { ...allStores } = this.props.allStores;

    return (
      <div>
        {allStores.certificateStore.certificates.map((i: ICertificate) => {
          return <Certificate key={i.thumbprint} {...i} />;
        })}
      </div>
    );
  }
}

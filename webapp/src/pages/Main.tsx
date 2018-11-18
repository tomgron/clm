import React, { Component } from "react";
import { AllStoresInterface } from "../store";
import { UserInterface, User, UserStoreInterface } from "../store/userStore";
import { inject, observer } from "mobx-react";
import { CertificateInterface } from "../store/certificateStore";
import Certificate from "../components/Certificate";

@inject("allStores")
@observer
export default class Main extends Component<any, any> {
  render() {
    const { ...allStores } = this.props.allStores;

    return (
      <div>
        {allStores.certificateStore.certificates.map((i: CertificateInterface) => {
          return <Certificate key={i.thumbprint} {...i} />;
        })}
      </div>
    );
  }
}

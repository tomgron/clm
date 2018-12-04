import React, { Component } from "react";
import { AllStoresInterface } from "../store";
import { UserInterface, User, UserStoreInterface } from "../store/userStore";
import { inject, observer } from "mobx-react";
import { CertificateInterface } from "../store/certificateStore";
import Certificate from "../components/Certificate";
import { Link } from "react-router-dom";

@inject("allStores")
@observer
export default class Main extends Component<any, any> {
  render() {
    const { ...allStores } = this.props.allStores;

    const removeCertificate = (certificate: CertificateInterface) => {
      allStores.certificateStore.removeCertificate(certificate.thumbprint);
    };
    return (
      <div className="certificateList">
        {allStores.certificateStore.certificates.map((i: CertificateInterface) => {
          return (
            <div key={i.thumbprint}>
              <Certificate {...i} />
              <button onClick={() => removeCertificate(i)}>Remove</button>
            </div>
          );
        })}
        <div>
          <Link to="Colors">Colors</Link>
        </div>
      </div>
    );
  }
}

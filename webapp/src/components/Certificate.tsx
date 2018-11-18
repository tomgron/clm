import React, { Component } from "react";
import { CertificateInterface } from "../store/certificateStore";
import "./Certificate.scss";
import CertIcon from '../images/cert.svg'
import { inject, observer } from "mobx-react";

@inject("allStores")
@observer
export default class Certificate extends Component<any,any> {

  render() {

    const { ...allStores } = this.props.allStores;


    const onClick = (e:any) => {
      e.preventDefault()
      allStores.certificateStore.removeCertificate(this.props.thumbprint);
       
    }
  
    return (
      <div className="certificate" onClick={onClick}>
        <img src={CertIcon} width={40}/>
        <div>Name: {this.props.name}</div>
        <div>Thumbprint: {this.props.thumbprint}</div>
        <div>Valid from: {new Date(this.props.validFrom).toLocaleDateString()}</div>
        <div>Valid to: {new Date(this.props.validTo).toLocaleDateString()}</div>
      </div>
    );
  }
}

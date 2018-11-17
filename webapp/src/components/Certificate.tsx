import React, { Component } from "react";
import { ICertificate } from "../store/certificateStore";
import "./Certificate.scss";

export default class Certificate extends Component<ICertificate> {
  render() {
    return (
      <div className="certificate">
        <div>Name: {this.props.name}</div>
        <div>Thumbprint: {this.props.thumbprint}</div>
        <div>Valid from: {new Date(this.props.validFrom).toLocaleDateString()}</div>
        <div>Valid to: {new Date(this.props.validTo).toLocaleDateString()}</div>
      </div>
    );
  }
}

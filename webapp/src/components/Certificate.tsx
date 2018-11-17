import React, { Component } from 'react'
import { ICertificate } from '../store/certificateStore';
import './Certificate.scss'

export default class Certificate extends Component<ICertificate> {
  render() {
    return (
      <div className="certificate">
        <div>{this.props.name}</div>
        <div>{this.props.thumbprint}</div>
        <div>{new Date(this.props.validFrom).toLocaleDateString()}</div>
        <div>{new Date(this.props.validTo).toLocaleDateString()}</div>
      </div>
    )
  }
}

import React, { Component, Children } from 'react';
import './styles/index.scss'
import { Routes } from './Routes'

export default class App extends Component {
  render() {
    return (
      <div>
        <div className='menu_area'>foo</div>
        <div className='content_area'>{this.props.children}</div>
        <div className='footer_area'>foo</div>
      </div>
    );
  }
}

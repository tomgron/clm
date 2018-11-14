import React, { Component } from 'react'
import {IAllStores} from '../store'
import {IUser, User, IUserStore} from '../store/userStore'
import { inject, observer } from 'mobx-react';

@inject('allStores')
@observer
export default class Login extends Component {
  render() {
    return (
      <div>
        LOGIN PAGE
      </div>
    )
  }
}

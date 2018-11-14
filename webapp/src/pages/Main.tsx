import React, { Component } from 'react'
import {IAllStores} from '../store'
import {IUser, User, IUserStore} from '../store/userStore'
import { inject, observer } from 'mobx-react';

@inject('allStores')
@observer
export default class Main extends Component<any,any> {
  render() {
    return (
      <div>
        Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas tincidunt risus sit amet tellus tristique dignissim. Aliquam eu nisl vel leo rutrum pretium. Quisque vel sapien porta mi euismod interdum. Ut sed scelerisque justo. Morbi sem libero, bibendum vel aliquam a, porta vitae ex. Donec sit amet orci eu nulla convallis molestie eu in nibh. Donec hendrerit venenatis cursus.

Vivamus congue sodales dolor eu facilisis. Vivamus risus elit, egestas eget dignissim et, dictum a nulla. Integer at pretium enim. Etiam vel aliquam nisi. Nullam nec venenatis nisl. Donec lobortis neque vel elit eleifend cursus. Curabitur finibus ac lectus ac blandit. Nunc consequat odio vel faucibus laoreet.

Phasellus eget dui odio. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Cras eget urna vitae magna fringilla maximus eget eu dolor. Donec rutrum euismod volutpat. Nullam laoreet diam sed blandit fermentum. Integer eu velit eget ex mattis tempus. Vestibulum in turpis accumsan, facilisis arcu eu, ullamcorper erat.

Morbi luctus enim eget nulla tempor ultrices. Donec lacinia sapien nec ipsum ultricies venenatis. Proin sem massa, sollicitudin at purus id, iaculis rhoncus justo. Etiam euismod quis sapien vel congue. Fusce aliquet ex eget iaculis mollis. Sed facilisis, risus ac rhoncus lobortis, dui enim ultricies diam, ac aliquam nulla magna non enim. Nullam malesuada convallis nisl, a pellentesque nunc dignissim et. Curabitur vestibulum eu nisl sed tincidunt. Proin tempus mi a sodales vehicula. Vivamus sagittis suscipit turpis, vel vulputate dui tempor a. Integer lorem nunc, pellentesque sit amet purus sollicitudin, luctus egestas elit.

Cras congue faucibus tellus vel consequat. Curabitur sagittis tellus et turpis consectetur euismod. Maecenas placerat felis lacinia elit sollicitudin, ac tincidunt risus venenatis. Praesent finibus rhoncus odio, in fermentum sem eleifend non. Nullam sed dui tincidunt, porttitor augue ac, tempus quam. Quisque nec ullamcorper sapien, sed sagittis libero. Phasellus velit nisl, porttitor eget libero ut, aliquam aliquet nibh. Duis tristique sapien vitae enim viverra, id mollis lorem sagittis. Mauris et cursus erat. Mauris imperdiet metus lacus, eget pretium tortor fringilla sit amet. Pellentesque mollis imperdiet nunc. Duis nec cursus lectus. Vivamus bibendum posuere nunc quis gravida.
      </div>
    )
  }
}

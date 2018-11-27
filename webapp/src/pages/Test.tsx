import React, { Component } from "react";
import { inject, observer } from "mobx-react";

@inject("allStores")
@observer
export default class Test extends Component<any, any> {
  getData() {
    fetch("https://localhost:44304/api/values", {
      method: "GET",
      mode: "cors",
      cache: "no-cache",
      headers: {
        "Content-Type": "application/json; charset=utf-8"
      }
    })
      .then(resp => resp.ok && resp.json())
      .then(json => json && console.table(json));
  }

  render() {
    return (
      <div>
        <button onClick={this.getData}>Get data</button>
      </div>
    );
  }
}

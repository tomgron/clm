import React, { Component } from "react";
import { inject, observer } from "mobx-react";
import { AllStores } from "../store";
import { Certificate } from "../store/certificateStore";
import ReactJson from "react-json-view";

@inject("allStores")
@observer
export default class Test extends Component<any, any> {
  constructor(props) {
    super(props);
    this.state = {
      loading: false,
      dataAvailable: false
    };
  }

  render() {
    const allStores = this.props.allStores as AllStores;

    const getData = () => {
      this.setState({ loading: true, dataAvailable: false });

      fetch("https://localhost:44304/api/values", {
        method: "GET",
        mode: "cors",
        cache: "no-cache",
        headers: {
          "Content-Type": "application/json; charset=utf-8"
        }
      })
        .then(resp => resp.ok && resp.json())
        .then(json => {
          if (json) {
            this.setState({ dataAvailable: true });
            allStores.certificateStore.certificates = []; // Clear old certs
            json.map(i => allStores.certificateStore.addCertificate(new Certificate(i.name, i.thumbprint, i.validFrom, i.validThrough)));
          }
        });

      console.log(allStores.certificateStore);

      this.setState({ loading: false });
    };
    return (
      <div>
        <button disabled={this.state.loading} onClick={getData}>
          Get data
        </button>
        
        {this.state.dataAvailable && <ReactJson src={allStores.certificateStore.certificates} theme="monokai" displayDataTypes={true} displayObjectSize={true} collapsed={2} />}
      </div>
    );
  }
}

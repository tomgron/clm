import React, { Component, Children } from "react";
import { BrowserRouter as Router, Route } from "react-router-dom";
import { Provider } from "mobx-react";
import { allStores } from "./store";
import Main from "./pages/Main";
import Header from "./components/Header";
import Login from "./pages/Login";
import Footer from "./components/Footer";
import "./styles/app.scss";
import { Certificate } from "./store/certificateStore";

export default class App extends Component {
  render() {
    allStores.certificateStore.addCertificate(new Certificate("foo", "bar", Date.now(), Date.now()));
    allStores.certificateStore.addCertificate(new Certificate("test", "asdfasdf", Date.now(), Date.now()));
    allStores.certificateStore.addCertificate(new Certificate("zxvzxcv", "qwerqwer", Date.now(), Date.now()));

    return (
      <Provider allStores={allStores}>
        <Router>
          <div className="app">
            <Header />
            <div className="content">
              <Route path="/" exact component={Main} />
              <Route path="/login" exact component={Login} />
            </div>
            <Footer />
          </div>
        </Router>
      </Provider>
    );
  }
}

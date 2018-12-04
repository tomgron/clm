import React, { Component, Children } from "react";
import { BrowserRouter as Router, Route, RouteComponentProps } from "react-router-dom";
import { Provider } from "mobx-react";
import { allStores } from "./store";
import Main from "./pages/Main";
import Header from "./components/Header";
import PrivateRoute from "./components/PrivateRoute";
import Login from "./pages/Login";
import Footer from "./components/Footer";
import Colors from "./pages/Colors";
import Test from "./pages/Test";
import "./styles/app.scss";
import { Certificate } from "./store/certificateStore";
import createBrowserHistory from "history/createBrowserHistory";
import { RouterStore, syncHistoryWithStore, SynchronizedHistory } from "mobx-react-router";

export default class App extends Component<any, any> {
  render() {
    const browserHistory = createBrowserHistory();

    const history = syncHistoryWithStore(browserHistory, allStores.routingStore);

    return (
      <Provider allStores={allStores}>
        <Router {...history}>
          <div className="app">
            <Header />
            <div className="content">
              <Route path="/" exact component={Main} />
              <Route path="/login" exact component={Login} />
              <Route path="/test" exact component={Test} />
              <PrivateRoute path="/colors" component={Colors} />
            </div>
            <Footer />
          </div>
        </Router>
      </Provider>
    );
  }
}

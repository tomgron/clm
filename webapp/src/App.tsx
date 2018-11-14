import React, { Component, Children } from 'react';
import { BrowserRouter as Router, Route, Link } from "react-router-dom";
import {Provider} from 'mobx-react'
import {allStores} from './store'
import Main from './pages/Main'
import Header from './components/Header'
import Login from './pages/Login'
import Footer from './components/Footer'
import './styles/app.scss'

export default class App extends Component {
  render() {
    return (
      <Provider allStores={allStores}>
        <Router>
          <div>
            <Header/>
            <div className="content">
              <Route path="/" exact component={Main}/>        
              <Route path="/login" exact component={Login}/>
            </div>
            <Footer/>     
          </div>
        </Router>
      </Provider>
    );
  } 
}

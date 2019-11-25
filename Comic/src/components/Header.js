import React from 'react';
import createBrowserHistory from 'history/createBrowserHistory'
import {Link } from "react-router-dom";
import {connect} from 'react-redux';
import './Header.css';
import Nav from './Nav';
class Header extends React.Component{
    render()
    {
      var d_style={
        marginLeft: "300px",
        marginTop:"20px"
      }
      var li={
        color:"#e3538c",
        fontSize:"17px",
        textDecoration: "none",
        
      }
      return(
        <>
          <div className="containers">
            <div className="row" id="head"> 
                <div className =" col-md-12 col-lg-12">
                    <Nav/>
                </div>
            </div>
          </div>
        </>
      );
    }
}

export default Header;
      
import React from 'react';
import {Link,Route} from 'react-router-dom';
import './Hello.css'
import Breadcrumb from './Breadcrumb';
class Hello extends React.Component{
    render()
    {
        return (
            <>
            <div className="content-wrapper" id="con">
                <Breadcrumb br="Overview"/>
                <div  id="row" className="row">
                    <div className="col-md-10 offset-md-1">
                        <div className="card text-white bg-primary o-hidden h-100">
                            <div className="card-body">
                                <div className="card-body-icon">
                                    <i className="far fa-smile-wink"></i>
                                </div>
                                <div className="mr-5"> <i id ="a" className="fas fa-fw fa-comments"></i>HELLO ADMIN !!!</div>
                            </div>
                            <a className="card-footer text-white clearfix small z-1" href="#">
                            <span className="float-left">WELCOME TO TVT COMIC</span>
                            <span className="float-right">
                            </span>
                            </a>
                        </div>
                    </div>
            </div>
        </div>
        </>
        )
    }
}
export default Hello;



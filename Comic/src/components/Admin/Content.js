import React from 'react';
import {Link,Route} from 'react-router-dom';
import './Content.css'
import Hello from './Hello';
class Content extends React.Component{
    render(){
        return (
            <div className="side-bar">
                <ul className="side sidebar-color navbar-nav">
                    <li className="nav-item active">
                        <Link className="navbar-link" to="/Admin"><span className="mb-5" style={{fontSize:"25px"}} >TVT COMIC</span></Link>
                    </li>
                    <li className="nav-item active">
                        <Link className="nav-link" to="/Admin/Comics">
                            <i id ="i" className="fas fa-fw fa-tachometer-alt" />
                            <span>Quản lý truyện</span>
                        </Link>
                    </li>
                    <li className="nav-item dropdown">
                    <Link className="nav-link" to="/Admin/Users">
                        <i id ="i" className="fas fa-users"></i>
                        <span>Quản lý User</span>
                    </Link>
                    </li>
                </ul>
            </div>
        );
    }
}

export default Content;
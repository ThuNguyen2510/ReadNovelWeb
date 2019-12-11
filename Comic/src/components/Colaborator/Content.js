import React from 'react';
import { Link, Route } from 'react-router-dom';
class Content extends React.Component {
    render() {
        return (
            <nav className="sidebar sidebar-offcanvas ml-3" id="sidebar">
                <ul className="nav">
                    <li className="navbar-brand">
                        <h4>TVT</h4>
                    </li>
                    <li className="nav-item nav-profile">
                        <a href="#" className="nav-link">
                            <div className="nav-profile-image">
                                <img src="assets/images/faces/face1.jpg" alt="profile" />
                                <span className="login-status online" />
                                {/*change to cd  or busy as needed*/}
                            </div>
                            <div className="nav-profile-text d-flex flex-column">
                                <p className="font-weight-bold mb-2">David Grey. H</p>
                                <p className="text-secondary text-small">Project Manager</p>
                            </div>
                            <i className="mdi mdi-bookmark-check text-success nav-profile-badge" />
                        </a>
                    </li>
                    <li className="nav-item">
                        <a className="nav-link float-md-left" href="/Colaborator">
                        <i className="mdi mdi-home menu-icon" />
                            <span className="menu-title ml-2">Dashboard</span>
                        </a>
                    </li>
                    <li className="nav-item">
                        <a className="nav-link float-md-left" href="/Colaborator/comics">
                            <i className="mdi mdi-format-list-bulleted menu-icon" />
                            <span className="menu-title ml-2">Quản lý truyện</span>
                        </a>
                    </li>
                    <li className="nav-item">
                        <a className="nav-link float-md-left" href="/Colaborator/categorys">
                            <i className="mdi mdi-table-large menu-icon" />
                            <span className="menu-title ml-2">Thể loại</span>
                        </a>
                    </li>
                    <li className="nav-item">
                        <a className="nav-link float-md-left" href="/Colaborator/forums">
                            <i className="mdi mdi-chart-bar menu-icon" />
                            <span className="menu-title ml-2">Diễn đàn</span>
                        </a>
                    </li>                    
                    <li className="nav-item">
                        <a className="nav-link float-md-left" data-toggle="collapse" href="#general-pages" aria-expanded="false" aria-controls="general-pages">
                            <i className="mdi mdi-medical-bag menu-icon" />
                            <span className="menu-title ml-2">Sample Pages</span>
                        </a>
                        <div className="collapse" id="general-pages">
                            <ul className="nav flex-column sub-menu">
                                <li className="nav-item"> <a className="nav-link float-md-left" href="pages/samples/blank-page.html"> Blank Page </a></li>
                                <li className="nav-item"> <a className="nav-link float-md-left" href="pages/samples/login.html"> Login </a></li>
                                <li className="nav-item"> <a className="nav-link float-md-left" href="pages/samples/register.html"> Register </a></li>
                                <li className="nav-item"> <a className="nav-link float-md-left" href="pages/samples/error-404.html"> 404 </a></li>
                                <li className="nav-item"> <a className="nav-link float-md-left" href="pages/samples/error-500.html"> 500 </a></li>
                            </ul>
                        </div>
                    </li>
                    <li className="nav-item sidebar-actions">
                        <span className="nav-link float-md-left">
                            <a href="/" style={{textDecoration:"none"}}><button className="btn btn-block btn-lg btn-gradient-success mt-4">+ Đăng xuất</button></a>
                        </span>
                    </li>
                </ul>
            </nav>

        );
    }
}

export default Content;
import React, { Component } from 'react';
import {Link,Route} from 'react-router-dom';

export class Info extends Component {
    render() {
        return (
            <>
                <div className="content-wrapper" style={{width:"100%", height:"100%"}}>
                    <div className="page-header">
                        <h3 className="page-title">
                            <span className="page-title-icon bg-gradient-primary text-white mr-2">
                                <i className="mdi mdi-home" />
                            </span> Dashboard </h3>
                        <nav aria-label="breadcrumb">
                            <ul className="breadcrumb">
                                <li className="breadcrumb-item active" aria-current="page">
                                    <span />Admin <i className="mdi mdi-alert-circle-outline icon-sm text-primary align-middle" />
                                </li>
                            </ul>
                        </nav>
                    </div>
                    <div className="row">
                        <div className="col-md-3 stretch-card grid-margin">
                            <div className="card bg-gradient-danger card-img-holder text-white">
                                <div className="card-body">
                                    <img src="assets/images/dashboard/circle.svg" className="card-img-absolute" alt="circle-image" />
                                    <Link style={{fontSize:"50px", color:"#fff"}} to="/Admin/Users"> <h4 className="font-weight-normal mb-3">Thành viên <i className="mdi mdi-chart-line mdi-24px float-right" />
                                    </h4>
                                    <h2 className="mb-5">150 </h2>
                                    <a href="/Admin/Users" style={{fontSize:"50px", color:"#fff"}}><i className="mdi mdi-plus-circle-outline large"></i></a>
                                    {/* <h6 className="card-text">Increased by 60%</h6> */}
                                    </Link>
                                </div>
                            </div>
                        </div>
                        <div className="col-md-3 stretch-card grid-margin">
                            <div className="card bg-gradient-info card-img-holder text-white">
                                <div className="card-body">
                                    <img src="assets/images/dashboard/circle.svg" className="card-img-absolute" alt="circle-image" />
                                    <Link style={{fontSize:"50px", color:"#fff"}} to="/Admin/Comics"><h4 className="font-weight-normal mb-3">Quản lý truyện <i className="mdi mdi-bookmark-outline mdi-24px float-right" />
                                    </h4>
                                    <h2 className="mb-5">45,6334</h2>
                                    <a href="/Admin/Comics" style={{fontSize:"50px", color:"#fff"}}><i className="mdi mdi-plus-circle-outline large"></i></a>
                                    </Link>
                                </div>
                            </div>
                        </div>
                        <div className="col-md-3 stretch-card grid-margin">
                            <div className="card bg-gradient-success card-img-holder text-white">
                                <div className="card-body">
                                    <img src="assets/images/dashboard/circle.svg" className="card-img-absolute" alt="circle-image" />
                                    <Link style={{fontSize:"50px", color:"#fff"}} to="/Admin/Categorys"><h4 className="font-weight-normal mb-3">Thể loại <i className="mdi mdi-diamond mdi-24px float-right" />
                                    </h4>
                                    <h2 className="mb-5">95,5741</h2>
                                    <a href="/Admin/Categorys" style={{fontSize:"50px", color:"#fff"}}><i className="mdi mdi-plus-circle-outline large"></i></a>
                                    </Link>
                                </div>
                            </div>
                        </div>
                        <div className="col-md-3 stretch-card grid-margin">
                            <div className="card bg-gradient-primary card-img-holder text-white">
                                <div className="card-body">
                                    <img src="assets/images/dashboard/circle.svg" className="card-img-absolute" alt="circle-image" />
                                    <Link style={{fontSize:"50px", color:"#fff"}} to="/Admin/Categorys"><h4 className="font-weight-normal mb-3">Diễn đàn <i className="mdi mdi-diamond mdi-24px float-right" />
                                    </h4>
                                    <h2 className="mb-5">95,5741</h2>
                                    <a href="/Admin/Categorys" style={{fontSize:"50px", color:"#fff"}}><i className="mdi mdi-plus-circle-outline large"></i></a>
                                    </Link>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </>
        );
    }
}

export default Info;

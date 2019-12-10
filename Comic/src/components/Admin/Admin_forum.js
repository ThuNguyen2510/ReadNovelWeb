import React, { Component } from 'react';
import { Link, Route } from 'react-router-dom';
import Content from './Content';
import Footer from './footer';

export class Admin_forum extends Component {
    render() {
        var list =[
            {user: "vi", post:"tim truyen ne"},
            {user: "thu", post:"ae giup do"},
            {user: "thi", post:"can tim truyen..."},
            {user: "vi", post:"tim truyen ne"},
            {user: "thu", post:"ae giup do"},
            {user: "thi", post:"can tim truyen..."},
            {user: "vi", post:"tim truyen ne"},
            {user: "thu", post:"ae giup do"},
            {user: "thi", post:"can tim truyen..."},
            {user: "vi", post:"tim truyen ne"},
            {user: "thu", post:"ae giup do"},
            {user: "thi", post:"can tim truyen..."}
        ]
        var show= list.map((a)=>{
            return(<>
                <tr>
                    <td>{a.user}</td>
                    <td>{a.post}</td>
                    <td>
                        <ul className="ml-5">
                        <li id="but" ><Link ><i class="far fa-eye ml-5"></i></Link></li>
                        <li id="but" ><button><i id="del" class="far fa-minus-square"></i></button></li>
                    </ul>
                    </td>
                </tr>
            </>)
        })
        return (
            <div>
                <div className="row">
                    <div className="col-md-2">
                        <Content />
                    </div>
                    <div className="col-md-10" style={{ height: "100%" }}>
                        <div className="content-wrapper" style={{ height: "100%", padding:"0 0 "}} >
                            <nav aria-label="breadcrumb ">
                                <ul className="breadcrumb">
                                    <li className="breadcrumb-item active ml-3" aria-current="page">
                                        <span />Admin/Quản lý diễn đàn <i className="mdi mdi-alert-circle-outline icon-sm text-primary align-middle" />
                                    </li>
                                </ul>
                            </nav>
                            <div className="row m-3">
                                <div className="col-sm-12 col-md-6  grid-margin">
                                    <div className="input-group" >
                                        <input type="search" id="adsearch" className="form-control" placeholder="Tìm bài đăng..." />
                                        <span className="input-group-btn">
                                            <button id="adbut"  className="btn btn-primary" type="submit" >
                                                <i className="fas fa-search"></i>
                                            </button>
                                        </span>
                                    </div>
                                </div>
                            </div>
                            <div className="card ml-5 mr-5 mb-5">
                                <div className="card-body mb-3">
                                    <h4>Diễn đàn</h4>
                                    <div className="table-responsive">
                                        <table className="table">
                                            <thead>
                                                <tr>
                                                    <th>Bài đăng</th>
                                                    <th>Người đăng</th>
                                                    <th>Action</th>
                                                </tr>
                                            </thead>
                                            <tbody>
                                                {show}
                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>
                            <div className="row">
                                                <div className="dataTables_info ml-5 mb-5" id="dataTable_info" role="status" aria-live="polite"><i class="fas fa-pencil-ruler mr-2"></i>THỐNG KÊ: {show.length} bài đăng</div>
                                            </div>
                            <Footer/>
                        </div>
                    </div>
                </div>
            </div>
        );
    }
}

export default Admin_forum;

import React, { Component } from 'react';
import { Link, Route } from 'react-router-dom';
import Sidebar from './Sidebar';
import Nav from './Nav';
export class User_forum extends Component {
    render() {

        var list =[
            {time: "2019/10/10", post:"tim truyen ne"},
            {time: "2019/1/2", post:"ae giup do"},
            {time: "2019/6/11", post:"can tim truyen..."},
            {time: "2019/7/12", post:"tim truyen ne"},
            {time: "2019/7/12", post:"ae giup do"},
            {time: "2019/7/12", post:"can tim truyen..."},
            {time: "2019/7/12", post:"tim truyen ne"},
            {time: "2019/7/12", post:"ae giup do"},
            {time: "2019/6/11", post:"can tim truyen..."},
            {time: "2019/6/11", post:"tim truyen ne"},
            {time: "2019/10/10", post:"ae giup do"},
            {time: "2019/10/10", post:"can tim truyen..."}
        ]
        var show = list.map(a=>{
            return (
                <>
                    <tr>
                        <td>{a.post}</td>
                        <td>{a.time}</td>
                        <td>
                            <Link to=''><button className="btn btn-gradient-info">Xem</button></Link>
                        </td>
                    </tr>
                </>
            )
        })
        return (
            <div>
                <div className="row">
                    <div className="col-md-2">
                        <Sidebar />
                    </div>
                    <div className="col-md-10">
                        <Nav br="Diễn đàn"></Nav>
                        <div className="col-md-12 ">
                            <div className="card m-5" style={{backgroundColor:"#f0f0f0", border:"none"}}>
                                <div className="card-body">
                                    <h4 className="card-title">Lịch sử </h4>
                                    <table className="table table-hover">
                                        <thead>
                                            <tr>
                                                <th>Tiêu đề</th>
                                                <th>Thời gian</th>
                                                <th>Bài đăng</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            {show}
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        );
    }
}

export default User_forum;

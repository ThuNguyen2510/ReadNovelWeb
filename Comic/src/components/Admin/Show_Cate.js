import React, { Component } from 'react';
import Content from './Content'

export class Show_Cate extends Component {
    render() {
        return (
            <div>
                <div className="row">
                    <div className="col-md-2">
                        <Content />
                    </div>
                    <div className="col-md-10">
                        <div className="content-wrapper" >
                            <nav aria-label="breadcrumb ">
                                <ul className="breadcrumb">
                                    <li className="breadcrumb-item active ml-3" aria-current="page">
                                        <span />Thể loại:  <i className="mdi mdi-alert-circle-outline icon-sm text-primary align-middle" />
                                    </li>
                                </ul>
                            </nav>
                        </div>
                    </div>
                </div>
            </div>
        );
    }
}

export default Show_Cate;

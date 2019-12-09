import React, { Component } from 'react';
import { connect } from 'react-redux';
import { fetchGenres } from '../../actions/GenreAction';
import Footer from './footer';
import Content from './Content';
import { Link, Route } from 'react-router-dom';

export class Admin_Cate extends Component {
    constructor(props) {
        super(props)
    }
    componentDidMount() {
        this.props.fetchGenres();
    }
    render() {
        var list = this.props.gens.map((value_, index) => {
            return <>
                <tr>
                    <td className="py-3">
                        {value_.genre_name}
                    </td>
                    <td>
                        <button type="button" className="btn btn-gradient-danger btn-fw">Xóa</button>
                    </td>
                </tr>
            </>
        })
        return (
            <div >
                <div className="row" >
                    <div className="col-md-2">
                        <Content />
                    </div>
                    <div className="col-md-10" >
                        <div className="content-wrapper" style={{ width: "100%",height:"100vh", padding: "0 0"}}>
                            <nav aria-label="breadcrumb ">
                                <ul className="breadcrumb">
                                    <li className="breadcrumb-item active ml-3" aria-current="page">
                                        <span />Admin/Quản lý thể loại <i className="mdi mdi-alert-circle-outline icon-sm text-primary align-middle" />
                                    </li>
                                </ul>
                            </nav>
                            <div className="col-lg-10 offset-1 grid-margin stretch-card mt-4">
                                <div className="card ">
                                    <div className="card-body">
                                        <h4 className="card-title">Quản lý thể loại</h4>
                                        <table className="table table-striped">
                                            <thead>
                                                <tr>
                                                    <th> Thể loại </th>
                                                    <th> Action </th>
                                                </tr>
                                            </thead>
                                            <tbody>
                                                {list}
                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <Footer/>
                    </div>
                </div>
            </div>
        );
    }
}
const mapStateToProps = (state) => {
    return {
        gens: state.genre,
    };
}
const mapDispatchToProps = (dispatch) => {
    return {
        fetchGenres: () => dispatch(fetchGenres()),
    }
}
export default connect(mapStateToProps, mapDispatchToProps)(Admin_Cate);

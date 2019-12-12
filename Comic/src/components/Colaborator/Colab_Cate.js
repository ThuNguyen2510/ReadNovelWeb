import React, { Component } from 'react';
import { connect } from 'react-redux';
import { fetchGenres } from '../../actions/GenreAction';
import Footer from './footer';
import Content from './Content';
import { Link, Route } from 'react-router-dom';

export class Colab_Cate extends Component {
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
                    <div className="col-md-10" style={{ width: "100%", height: "100%" }}>
                        <div className="content-wrapper" style={{ width: "100%", height: "100%", padding: "0 0" }}>
                            <nav aria-label="breadcrumb ">
                                <ul className="breadcrumb">
                                    <li className="breadcrumb-item active ml-3" aria-current="page">
                                        <span />Colab/Quản lý thể loại <i className="mdi mdi-alert-circle-outline icon-sm text-primary align-middle" />
                                    </li>
                                </ul>
                            </nav>
                            <div className="row>">
                                <div className="col-sm-12 col-md-6 ml-5 grid-margin">
                                    <div className="input-group" >
                                        <input type="search" id="adsearch" value="" className="form-control" placeholder="Tìm thể loại..." />
                                        <span className="input-group-btn">
                                            <button id="adbut" className="btn btn-primary" type="submit" >
                                                <i className="fas fa-search"></i>
                                            </button>
                                        </span>
                                    </div>
                                </div>
                            </div>
                            <div className="col-lg-10 offset-1 stretch-card mt-4">
                                <div className="card h-100 mb-5">
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
                        <Footer />
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
export default connect(mapStateToProps, mapDispatchToProps)(Colab_Cate);
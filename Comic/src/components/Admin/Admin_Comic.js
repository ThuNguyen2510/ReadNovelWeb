import React from 'react';
import { Link, Route } from 'react-router-dom';
import Content from './Content';
import './Admin_Comic.css';
import { connect } from 'react-redux';
import { fetchListComic, deleteComic } from '../../actions/ComicActions';
import { fetchGenres } from '../../actions/GenreAction';
import { SearchByName } from '../../actions/SearchAction'
class Admin_Comic extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            keyword: ''
        }
        this.search = this.search.bind(this)
    }
    componentDidMount() {
        this.props.fetchListComic()
        this.props.fetchGenres()
    }
    findGenre(id) {
        var gen = ""
        for (var i = 0; i < this.props.gens.length; i++) {

            if (this.props.gens[i].id === id) {
                gen = this.props.gens[i].genre_name

                break;
            }
        }
        return gen;
    }
    show() {
        return this.props.list.map((a) =>
            // <tr>
            //     <td><img style={{ width: "50px" }} src={a.Image}></img></td>
            //     <td> <Link to={"/Comic/" + a.id + "/Show"}>{a.Name}</Link></td>
            //     <td>{a.Author}</td>
            //     <td>{this.findGenre(a.Genre_id)}</td>
            //     <td>
            //         <ul>
            //             <li id="but" ><Link to={"/Comic/" + a.id + "/Show"}><i class="far fa-eye"></i></Link></li>
            //             <li id="but" ><button onClick={e => { if (window.confirm("Are you sure??")) this.props.deleteComic(a.id) }} ><i id="del" class="far fa-minus-square"></i></button></li>
            //         </ul>
            //     </td>
            // </tr>
            <tr>
                <td>
                    <img src={a.Image} className="mr-2" alt="image" /><br/>
                    <Link to={"/Comic/" + a.id + "/Show"}>{a.Name}</Link>
                </td>
                <td> {this.findGenre(a.Genre_id)} </td>
                <td>
                {a.Author}
                </td>
                <td> 
                    <ul className="ml-5">
                        <li id="but" ><Link to={"/Comic/" + a.id + "/Show"}><i class="far fa-eye"></i></Link></li>
                        <li id="but" ><button onClick={e => { if (window.confirm("Are you sure??")) this.props.deleteComic(a.id) }} ><i id="del" class="far fa-minus-square"></i></button></li>
                    </ul> 
                </td>
            </tr>

        )
    }
    search(keyword) {
        this.props.SearchByName(keyword)
    }
    render() {
        var a = {
            float: "left"
        }
        let { keyword } = this.state
        return (
            <>
                <div className="containers">
                    <div className="row" >
                        <div className="col-md-2 col-lg-2">
                            <Content />
                        </div>
                        <div className="col-md-10 col-lg-10">
                            <div className="card" style={{ width: "100%" }}>
                                <div className="card-header">
                                    <p><i class="fas fa-table mr-2"></i>Quản lý truyện</p>
                                </div>
                                <div id="addcomic"> <Link to="/Comics/Add"><i class="fas fa-plus"></i>Thêm truyện </Link></div>
                                <div className="card-body mt-1">
                                        <div className=" dt-bootstrap4" id="">
                                            <div className="row>">
                                                <div className="col-sm-12 col-md-6  grid-margin">
                                                    <div className="input-group" >
                                                        <input type="search" id="adsearch" value={keyword} onChange={e => this.setState({ keyword: e.target.value })} className="form-control" placeholder="Tìm tên truyện,..." />
                                                        <span className="input-group-btn">
                                                            <button onClick={e => this.search(this.state.keyword)} id="adbut" className="btn btn-primary" type="submit" >
                                                                <i className="fas fa-search"></i>
                                                            </button>
                                                        </span>
                                                    </div>
                                                </div>
                                            </div>
                                            <div className="row">
                                                <div className="col-12 grid-margin">
                                                    <div className="card">
                                                        <div className="card-body">
                                                            <h4 className="card-title">Danh sách truyện</h4>
                                                            <div className="table-responsive">
                                                                <table className="table">
                                                                    <thead>
                                                                        <tr>
                                                                            <th> Tên truyện </th>
                                                                            <th> Thể loại </th>
                                                                            <th> Tác giả </th>
                                                                            <th> Action </th>
                                                                            
                                                                        </tr>
                                                                    </thead>
                                                                    <tbody>
                                                                        {/* <tr>
                                                                            <td>
                                                                                <img src="assets/images/faces/face1.jpg" className="mr-2" alt="image" /> David Grey </td>
                                                                            <td> Fund is not recieved </td>
                                                                            <td>
                                                                                <label className="badge badge-gradient-success">DONE</label>
                                                                            </td>
                                                                            <td> Dec 5, 2017 </td>
                                                                            <td> WD-12345 </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td>
                                                                                <img src="assets/images/faces/face2.jpg" className="mr-2" alt="image" /> Stella Johnson </td>
                                                                            <td> High loading time </td>
                                                                            <td>
                                                                                <label className="badge badge-gradient-warning">PROGRESS</label>
                                                                            </td>
                                                                            <td> Dec 12, 2017 </td>
                                                                            <td> WD-12346 </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td>
                                                                                <img src="assets/images/faces/face3.jpg" className="mr-2" alt="image" /> Marina Michel </td>
                                                                            <td> Website down for one week </td>
                                                                            <td>
                                                                                <label className="badge badge-gradient-info">ON HOLD</label>
                                                                            </td>
                                                                            <td> Dec 16, 2017 </td>
                                                                            <td> WD-12347 </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td>
                                                                                <img src="assets/images/faces/face4.jpg" className="mr-2" alt="image" /> John Doe </td>
                                                                            <td> Loosing control on server </td>
                                                                            <td>
                                                                                <label className="badge badge-gradient-danger">REJECTED</label>
                                                                            </td>
                                                                            <td> Dec 3, 2017 </td>
                                                                            <td> WD-12348 </td>
                                                                        </tr> */}
                                                                        {this.show()}
                                                                    </tbody>
                                                                </table>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <div className="row">
                                                <div className="dataTables_info ml-4" id="dataTable_info" role="status" aria-live="polite"><i class="fas fa-pencil-ruler mr-2"></i>THỐNG KÊ {this.props.list.length} cuốn truyện</div>
                                            </div>
                                            <div className="row justify-content-center align-items-center">
                                                <div className="dataTables_paginate paging_simple_numbers ">
                                                    <ul className="pagination ">
                                                        <li className="paginate_button page-item previous disabled" id="dataTable_previous"><Link to="#" aria-controls="dataTable" data-dt-idx="0" tabindex="0" className="page-link">Previous</Link></li>
                                                        <li className="paginate_button page-item active"><Link to={"/Comics/trang/" + 1} aria-controls="dataTable" data-dt-idx="1" tabindex="0" className="page-link">1</Link></li>
                                                        <li className="paginate_button page-item "><Link to={"/Comics/trang" + 2} aria-controls="dataTable" data-dt-idx="1" tabindex="0" className="page-link">2</Link></li>
                                                        <li className="paginate_button page-item "><Link to={"/Comics/trang" + 3} aria-controls="dataTable" data-dt-idx="1" tabindex="0" className="page-link">3</Link></li>
                                                        <li className="paginate_button page-item next" ><Link to="#" aria-controls="dataTable" data-dt-idx="0" tabindex="0" className="page-link">Next</Link></li>
                                                    </ul>
                                                </div>
                                            </div>
                                        </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </>


        );
    }
}

const mapStateToProps = (state) => {
    return {
        list: state.comics,
        gens: state.genre,
        search: state.search
    };
}
const mapDispatchToProps = (dispatch) => {
    return {
        fetchListComic: () => dispatch(fetchListComic()),
        fetchGenres: () => dispatch(fetchGenres()),
        deleteComic: (id) => dispatch(deleteComic(id)),
        SearchByName: (key) => dispatch(SearchByName(key))

    };
}
export default connect(mapStateToProps, mapDispatchToProps)(Admin_Comic);  
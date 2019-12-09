import React from 'react';
import './ForumRight.css';
import {Link} from 'react-router-dom';
export class ForumRight extends React.Component {
    render() {
        return (
            <>
                <nav class="navbar navbar-expand-lg navbar-light bg-light">
                    <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNavAltMarkup" aria-controls="navbarNavAltMarkup" aria-expanded="false" aria-label="Toggle navigation">
                        <span class="navbar-toggler-icon"></span>
                    </button>
                    <div class="collapse navbar-collapse" id="navbarNavAltMarkup">
                        <div class="navbar-nav">
                            <a class="nav-item nav-link active" href="#">Mới cập nhật<span class="sr-only">(current)</span></a>
                            <a class="nav-item nav-link" href="#">Được quan tâm</a>


                        </div>
                    </div>
                    <form class="form-inline">
                        <input class="form-control mr-sm-2" type="search" placeholder="Search" aria-label="Search" />
                        <button class="btnNav" type="submit"><i style={{ color: "green" }} className="fas fa-search btnsearch"></i></button>
                        <button class="btnNav" type="submit"><Link to="/Forum-New-Post"><i style={{ color: "green" }} className="fas fa-edit"></i></Link></button>
                    </form>
                </nav>
                <table class="table">
                    <thead>
                        <tr>
                            <th scope="col">Chủ thớt</th>
                            <th scope="col">Tiêu đề</th>
                            <th scope="col">Comment</th>
                            <th scope="col"><i className="far fa-clock"></i></th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <th scope="row">TuongVi</th>
                            <td><Link to="/FDetail" className="tieude">Tìm truyện thú vị về nữ cường</Link></td>
                            <td>30</td>
                            <td>2h</td>
                        </tr>
                        <tr>
                            <th scope="row">Nhutthuy</th>
                            <td><Link to="/FDetail" className="tieude">HÃY CHO TUI BIẾT BỘ MÀ CÓ KẾT THẬT NGƯỢC TÂM NHƯ NÀY</Link></td>
                            <td>44</td>
                            <td>3h</td>
                        </tr>
                        <tr>
                            <th scope="row">Thư không có Thị nge</th>
                            <td><Link to="/FDetail" className="tieude">Chỉ tớ với nữ chính ở gia lai</Link></td>
                            <td>78</td>
                            <td>6h</td>
                        </tr>
                    </tbody>
                </table>
            </>
        );
    }
}

export default ForumRight;

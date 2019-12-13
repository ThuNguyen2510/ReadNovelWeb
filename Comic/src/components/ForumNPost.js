import React, { Component } from 'react';
import './ForumNPost.css';
import { Link } from 'react-router-dom';
import Header from './Header';
import Footer from './Footer';
import 'froala-editor/js/froala_editor.pkgd.min.js';
import 'froala-editor/css/froala_style.min.css';
import 'froala-editor/css/froala_editor.pkgd.min.css';
import FroalaEditor from 'react-froala-wysiwyg';
import {getUName} from '../actions/LoadUserAction';
import {addPostF} from '../actions/NewPostForumAction';
import {connect} from 'react-redux';
import newpost from '../reducers/new_post_reducer';
export class ForumNPost extends Component {
    constructor(props) {
        super(props);
        new FroalaEditor('textarea#froala-editor')
        this.state={}
        this.handleOnClick =this.handleOnClick.bind(this);
    }
    handleOnClick(e){
        e.preventDefault();
        let{content,title}=this.state;
        var us_=JSON.parse(localStorage.getItem('logined_user'));
        var temp= new Date
        var date=temp.getMonth()+"/"+temp.getDate()+"/"+temp.getFullYear()
        this.props.addPostF(us_.id,title,content,date);
        this.setState({content:" ",title:" "})
        this.props.history.goBack();
       }
    render() {
        var userin= JSON.parse(localStorage.getItem("logined_user"))
        let {content,title}= this.state
        return (
            <>
                <Header />
                <div className="container" style={{height:"100vh"}}>
                    <div className="row">
                        <div className="col-md-12 mt-3">
                            <div className="phantop">
                                <Link className="pull-left">
                                    <img src={userin.image} alt="" className="avatar" />
                                    <strong>{userin.username}</strong>
                                </Link>
                            </div>

                        </div>

                        <div className="col-md-12">
                            <hr></hr>
                            <div className="content">
                                <form className="form">
                                    <p>Tựa đề: </p>
                                    <input className="form-control" type="text" placeholder="Đủ nghĩa - Ngắn gọn - Súc tích" defaultValue={""} onChange={e=> this.setState({title: e.target.value})} value={title} required />
                                    <p>Nội dung bài viết</p>
                                    <FroalaEditor defaultValue={""} onChange={e=> this.setState({content: e.target.value})} value={content} required></FroalaEditor>
                                    <button className="btn btn-info mt-2" onClick={this.handleOnClick}>Post</button>
                                    <button className="btn btn-dark mt-2 ml-1" onClick={e=>this.props.history.goBack()}>Hủy</button>
                                </form>
                            </div>
                        </div>
                    </div>
                </div>
                <Footer />
            </>
        );
    }
}
const mapStateToProps=(state)=>{
    return {
        us: newpost
    }
}
const mapDispatchToProps =(dispatch) =>{
    return {
        getUName: (id)=>dispatch(getUName(id)),
        addPostF:  (userid,title,content,time)=> dispatch(addPostF(userid,title,content,time))
    }
}
export default connect(mapStateToProps,mapDispatchToProps) (ForumNPost);

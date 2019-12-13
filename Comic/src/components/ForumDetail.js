import React, { Component } from 'react';
import './ForumDetail.css';
import Header from './Header';
import { Link } from 'react-router-dom';
import {connect} from 'react-redux';
import {fetchAPost,addAnswer} from '../actions/PostFAction';
import {getUserName} from '../actions/LoadUserAction';
export class ForumDetail extends Component {
    constructor(props)
    {
        super(props)
        this.state={}
    }
    componentDidMount()
    {
        this.props.getUserName();
        this.props.fetchAPost(this.props.match.params.id);
        this.handleOnclick =this.handleOnclick.bind(this);
        
    }
    handleOnclick(e){
        e.preventDefault();
    let{content}=this.state;
    var us_=JSON.parse(localStorage.getItem('logined_user'));
    var temp= new Date
    var date=temp.getMonth()+"/"+temp.getDate()+"/"+temp.getFullYear()
    this.props.addAnswer(us_.id,this.props.post.id,content,date)
    this.setState({content:" "})
    }
    getun(id)
    {
        for(var i=0;i<this.props.uname.length;i++)
        {
           
            if(id==this.props.uname[i].id){
          
                return this.props.uname[i].username
            }
        }
    }
    im(id){
        for(var i=0;i<this.props.uname.length;i++)
        {
            if(id==this.props.uname[i].id){
                return this.props.uname[i].image
            }
        }
    }
    Detail()
    {
        var p=[];
          var userinf=this.props.user
          console.log(userinf)       
        p.push(
            <>
            <h3 className="title mt-3">{this.props.post.title}</h3>
                <img src={userinf.image} style={{width: "200px"}}></img>
                <h4>{userinf.username}</h4>
                <div className="naiyou" >
                    <p>{this.props.post.postContent}</p>
                    <p>{this.props.post.postTime}</p>
                    <p>{this.props.answers.length}</p>
                    <Link className="thich"><i className=" fa fa-heart fa-2x"></i></Link><span>{this.props.likes.length}</span>
                    <Link className="ml-2 edit">Sửa</Link>
                    <Link className="ml-2 edit">Xóa</Link>

                </div>
        </>
        )
        return p;     
    }
    showAnswer()
    {
        var l=[];
        for(var i=0;i<this.props.answers.length;i++)
        {
           
            l.push(<li className="media">
            <a href="#" className="pull-left">
                <img src={this.im(this.props.answers[i].userID)} alt="" className="img-circle" />
            </a>
            <div className="media-body">
                <span className="text-muted pull-right">
                    <small className="text-muted">{this.props.answers[i].answerTime}</small>
                </span>
                <strong className="text-success">@{this.getun(this.props.answers[i].userID)}</strong>
                <p>{this.props.answers[i].content}</p>
                <Link className="pull-right ml-2 edit">Sửa</Link>
                <Link className="pull-right ml-2 edit">Xóa</Link>
            </div>
        </li>)
        }
        return l;
    }
    render() {
        let {content}=this.state;
        return (
            <>
                <Header />
                <div className="container">
                    {this.Detail()}
                    <div className="ttac_cmt">
                        <div className="row bootstrap snippets">
                            <div className="col-md-12 col-md-offset-2 col-sm-12">
                                <div className="comment-wrapper">
                                    <div className="panel panel-info">
                                        <div className="panel-heading mt-4">
                                            Comment panel
              </div>
                                        <div className="panel-body">
                                            <textarea className="form-control" placeholder="write a comment..." rows={3} defaultValue={""} onChange={e=> this.setState({content: e.target.value})} value={content} required/>
                                            <br />
                                            <button type="button" className="btn btn-info pull-right"onClick={this.handleOnclick}>Post</button>
                                            <div className="clearfix" />
                                            <hr />
                                            <ul className="media-list">
                                                {this.showAnswer()}
                                              
                                            </ul>
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
const mapStateToProps =(state) =>{
    return {
        post: state.apost,
        likes:state.apost_in,
        user:state.user,
        answers:state.answer,
        uname: state.answer_usname
    }
}
const mapDispatchToProps =(dispatch) =>{
    return {
        fetchAPost:(id) => dispatch(fetchAPost(id)),
        getUserName:()=>dispatch(getUserName()),
        addAnswer:(userid,postid,content,time)=>dispatch(addAnswer(userid,postid,content,time))
    }
}
// mi ghi dispatch truoc state
export default connect(mapStateToProps, mapDispatchToProps)(ForumDetail);

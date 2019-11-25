import React from 'react';
import {Link,Route,Redirect} from 'react-router-dom';
import Nav from './Nav';
import Content from './Content';
import './Admin_Comic.css';
import {connect} from 'react-redux';
import Breadcrumb from './Breadcrumb';
import {fetchOneComic} from '../../actions/ComicActions';
import {updateChapter} from '../../actions/ChapterAction';
import {fetchChapter} from '../../actions/ChapterAction'
class UpdateChapter extends React.Component{
    constructor(props)
    {
        super(props)
        this.state={
            name:JSON.parse(localStorage.getItem('chap')).chapter_name,
            content:JSON.parse(localStorage.getItem('chap')).content
        }
        this.Save = this.Save.bind(this);
    }
    componentDidMount()
    {
        this.props.fetchOneComic(this.props.match.params.index)
       
    }
    name()
    {
        var name=""
        for(var i=0;i<this.props.comic.length-1;i++)
        {
            name=this.props.comic[i].Name
        }
        return name
    }
    Save(e)
    {
        e.preventDefault();
        let {name,content} = this.state;
        if(window.confirm('Are you sure?'))
        {
            this.props.UpdateChapter(this.props.match.params.id,this.props.match.params.index,name,content)
            alert("Success")
           // this.props.history.goBack()
            //this.props.history.push('/Comic/'+this.props.match.params.index+'/Edit')
        }

    }
    show()
    {
        var s=[]       
        for(var i=0;i<this.props.chap.length;i++)
        {  
            let{name,content}=this.state
            s.push(
                <div className="row ">
                <div className="col-md-2">
                    <Content/>
                </div>
                <div className="col-md-10">
                    <Nav/>                    
                    <Breadcrumb className="col-md-12" br="Quản lý truyện"/>
                    <div className="row" id="row">
                        <div className="col-md-7 ml-3 order-md-1">
                            <form className="needs-validation">
                                <div className="mb-3">
                                    <label for="username">Tên truyện</label>
                                    <div class="input-group">
                                        <div class="input-group-prepend"></div>
                                    <label type="text" class="form-control" id="username" >{this.name()}</label>
                                    </div>
                                </div>
                                <div className="mb-3">
                                    <label for="username">Tên chương</label>
                                    <div class="input-group">
                                        <div class="input-group-prepend"> </div>
                                        <input type="text" value={name} onChange={e=> this.setState({name: e.target.value})} class="form-control" id="name" required></input>
                                    </div>
                                </div>
                            
                                <div className="mb-3">
                                    <label for="username">Nội dung</label>
                                    <div className="form-group">
                                        <textarea value={content} onChange={e=> this.setState({content: e.target.value})} className="form-control" id="exampleFormControlTextarea3" rows="8"></textarea>
                                    </div>
                                </div>
                                
                            </form>
                        </div>
                        </div>
                        <div className="row">
                            <div className="col-md-7"></div>
                            <div className="col-md-5">
                                <button type="button" onClick={this.Save} class="btn btn-pill btn-warning">Lưu</button>
                                <button type="button" onClick={e=> this.props.history.push('/Comic/'+this.props.match.params.index+'/Edit')} class="btn btn-square btn-secondary">Cancel</button>
                            </div>
                        </div>
                    </div>               
                </div>  
            )
        }
        return s;
    }
    render()
    {
        return (
            <>
            {this.show()}
               
        </>
        )
    }
}
const mapStateToProps =(state)=>
{
  return{
    comic: state.comic,
    chap:state.chapter
  };
}
const mapDispatchToProps = (dispatch) => {
    return {
        fetchOneComic:(comic_id) => dispatch(fetchOneComic(comic_id)),
        fetchChapter:(chap_id,com_id) =>dispatch(fetchChapter(chap_id,com_id)),
        UpdateChapter:(chap_id,comic_id,name,content) => dispatch(updateChapter(chap_id,comic_id,name,content))
  };
}
  export default connect(mapStateToProps, mapDispatchToProps)(UpdateChapter);
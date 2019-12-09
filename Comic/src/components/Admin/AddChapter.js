import React from 'react';
import {Link,Route} from 'react-router-dom';
import Nav from './Nav';
import Content from './Content';
import './Admin_Comic.css';
import {connect} from 'react-redux';
import {Redirect} from 'react-router-dom'
import Breadcrumb from './Breadcrumb';
import {fetchOneComic} from '../../actions/ComicActions';
import {addChapter} from '../../actions/ChapterAction'
class AddChapter extends React.Component{
    constructor(props)
    {
        super(props)
        this.state={}
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
        this.props.addChapter(this.props.match.params.index,name,content)
        this.setState({
            name:'',
            content:''
        })
       
    }
    selectFile = (file) => {
       
        this.setState({ file:file})
        let reader = new FileReader()        
        reader.onload = () => {
          this.setState({
            content: reader.result
          })
         
        };
    }
   
    render()
    {
        let {name,content}=this.state
        return (
            <>
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
                                        <input type="text" value={name} onChange={e=> this.setState({name: e.target.value})} class="form-control" id="username" required></input>
                                    </div>
                                </div>
                            
                                <div className="mb-3">
                                    <label for="username">Nội dung</label>
                                    <div className="form-group">
                                        <textarea value={this.state.content} onChange={e=> this.setState({content: e.target.value})} className="form-control" id="exampleFormControlTextarea3" rows="4"></textarea>
                                        <input type="file"   onChange={e=>this.selectFile(e.target.files[0])}></input>
                                    </div>
                                    {console.log(this.state.content)}
                                </div>
                                
                            </form>
                        </div>
                        </div>
                        <div className="row">
                            <div className="col-md-7"></div>
                            <div className="col-md-5">
                                <button type="button" onClick={this.Save} class="btn btn-pill btn-warning">Lưu</button>
                                <button type="button" onClick={e=>this.props.history.goBack()} class="btn btn-square btn-secondary">Cancel</button>
                            </div>
                        </div>
                    </div>               
                </div>
               
        </>
        )
    }
}
const mapStateToProps =(state)=>
{
  return{
    comic: state.comic,
  };
}
const mapDispatchToProps = (dispatch) => {
    return {
        fetchOneComic:(comic_id) => dispatch(fetchOneComic(comic_id)),
        
        addChapter:(id,name,content) => dispatch(addChapter(id,name,content))
  };
}
  export default connect(mapStateToProps, mapDispatchToProps)(AddChapter);
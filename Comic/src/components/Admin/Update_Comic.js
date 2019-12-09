import React from 'react';
import {Link,Route} from 'react-router-dom';
import './Update_Comic.css';
import Nav from './Nav';
import Content from './Content';
import Breadcrumb from './Breadcrumb';
import {fetchGenres} from '../../actions/GenreAction';
import {fetchOneComic,updateComic} from '../../actions/ComicActions';
import {fetchChapters} from '../../actions/ChapterAction';
import {deleteChapter,fetchChapter} from '../../actions/ChapterAction'
import {connect} from 'react-redux'
class Update_Comic extends React.Component{
    constructor(props)
    {
        super(props);
        var comic=JSON.parse(localStorage.getItem('a_comic_edit'))
        this.state={
            Name:comic.Name,
            Author:comic.Author,
            genre_id:comic.Genre_id,
            des:comic.Description,
            status:comic.Status,
            Image:comic.Image
        }
        this.fetchAchap=this.fetchAchap.bind(this)
        this.Save = this.Save.bind(this);
    }
    componentDidMount()
    {
        this.props.fetchGenres()
        this.props.fetchOneComic(this.props.match.params.index)
        this.props.fetchChapters(this.props.match.params.index)
    }
    select(genre_id)
    {
        var s=[]
        s=this.props.gens.map(a=>{
            var check=false;
            if(genre_id==a.id) check=true;
        return   <option selected={check} value={a.id}>{a.genre_name}</option>
        })
        return s;
    }
    status(st)
    {
        var s=[]
        s.push(
            <>
          <option selected={(st==0)} value="0">Còn tiếp</option>
          <option selected={(st==1)} value="1">Full</option> 
            </>
        )
        return s;
    }

    selectImages = (event) => {
        let images = []
        for (var i = 0; i < event.target.files.length; i++) {
        images[i] = event.target.files.item(i);
        }
        images = images.filter(image => image.name.match(/\.(jpg|jpeg|PNG|gif)$/))
        this.setState({ images:images})
        var file = event.target.files[0]
        let reader = new FileReader()
        reader.readAsDataURL(file)
        reader.onload = () => {
          this.setState({
            Image: reader.result
          })
         };
    }
    show()
    {   var image={
        width: "210px",
        height: "240px"
        }
        var s=[]
        let {Name,Author,genre_id,des,Image,status}=this.state
        if(this.props.comic.length>0)
        for(var i=0;i<this.props.comic.length-1;i++)
            s.push(  <>
            <div className="row" id="row">
                        <div className="col-md-7 ml-3 order-md-1">
                            <form className="needs-validation">
                <div className="mb-3">
                            <label for="username">Tên truyện</label>
                            <div class="input-group">
                                <div class="input-group-prepend"></div>
                        <input type="text" class="form-control" id="username" value={Name} onChange={e=> this.setState({Name: e.target.value})} required=""></input>
                            </div>
                        </div>
                        <div className="mb-3">
                            <label for="username">Tác giả</label>
                            <div class="input-group">
                                <div class="input-group-prepend"> </div>
                                <input type="text" class="form-control" id="username" value={Author} onChange={e=> this.setState({Author: e.target.value})} required=""></input>
                            </div>
                        </div>
                        <div className="mb-3">
                                    <label for="username">Thể loại</label>
                                        <select onChange= {(e) => this.setState({genre_id:e.target.value}) }className="custom-select d-block w-100" id="country" required="">
                                            {this.select(genre_id)}
                                        </select>
                                </div>
                                <div className=" mb-3">
                                    <label for="cc-expiration">Trạng thái</label>
                                    <select onChange= {(e) => this.setState({status:e.target.value}) }className="custom-select d-block w-100" id="country" required="">
                                            {this.status(status)}
                                        </select>
                                </div>        
                                <div className="mb-3">
                                    <label for="username">Mô tả</label>
                                    <div className="form-group">
                         <textarea className="form-control" id="exampleFormControlTextarea3" value={des} onChange={e=> this.setState({des: e.target.value})} rows="4"></textarea>
                                    </div>
                                </div>
                                
                                <div className=" mb-3">
                                    <label for="cc-expiration">Số chương</label>
                            <label type="text" class="form-control" id="cc-expiration" placeholder="" required="">{this.props.chaps.length}</label>
            
                                </div> 
                                <div className="mb-3">
                                <label><Link to={"/Comic/"+this.props.match.params.index+"/Chap"}><i class="fas fa-plus"></i>Thêm chương </Link></label>
                                
                                </div>
                            </form>
                        </div>
                        <div className="col-md-4 order-md-2 ml-3 mb-4">
                            <div className="row">
                                <img style={image} src={this.state.Image}></img>

                            </div>
                            <input className="form-control " type="file" 
                                onChange={this.selectImages} multiple/>                              
                        </div>                    
                    </div>        
</>
            )
           return s;

    }
    fetchAchap = (id) =>
     {
        
        this.props.fetchChapter(id,this.props.match.params.index)
    }
    Save(e)
    {
     e.preventDefault();
     let {Name,Author,genre_id,des,Image,status}=this.state
     console.log(status)
     var temp= new Date
    var date=temp.getMonth()+"/"+temp.getDate()+"/"+temp.getFullYear()
    var chap_number=this.props.chaps.length
    
    if(window.confirm('Are you sure?'))
    {
        this.props.updateComic(this.props.match.params.index,Name,Author,parseInt(genre_id),des,Image,date,chap_number,status)
        
        alert("Success")
        this.props.history.push('/Admin/Comics')
    }
    }
    render()
    {
        
        var list= this.props.chaps.map((a)=>           
                <tr>
                    <td ><p id="li">Chương số {a.id} : {a.chapter_name}</p></td>
                    <td >
                    <ul>
                        <li id="but" ><Link  to={"/Comic/"+this.props.match.params.index+"/Chapter/"+a.id+"/Show"} onClick={()=> this.fetchAchap(a.id)}><button ><i class="far fa-eye"></i></button></Link></li>
                        <li id="but" ><button id={a.id} onClick={e=>{if(window.confirm("Are you sure??")) this.props.deleteChapter(a.id,this.props.match.params.index)}} ><i id="del" class="far fa-minus-square"></i></button></li>
                    </ul>
                    </td>
                </tr>
            
        )
       
        return(
            
            <>
            <div className="row ">
                <div className="col-md-2">
                    <Content/>
                </div>
                <div className="col-md-10">
                    <Nav/>                    
                    <Breadcrumb className="col-md-12" br="Quản lý truyện"/>
                                {this.show()}
                                {list}
                                <div className="row">
                            <div className="col-md-7">
                                <button type="button" onClick={this.Save} className="btn btn-pill btn-warning">Save</button>
                                <button type="button" onClick={e=>this.props.history.push('/Admin/Comics')} class="btn btn-square btn-secondary">Cancel</button>
                            </div>
                        </div>
                            
                    </div>               
                </div>
        </>
        );
    }
}
const mapStateToProps =(state)=>
{
  return{
    gens:state.genre,
    comic: state.comic,
    chaps: state.chapters
  };
}
const mapDispatchToProps = (dispatch) => {
    return {
        fetchGenres :()=> dispatch(fetchGenres()),
        fetchOneComic:(comic_id) => dispatch(fetchOneComic(comic_id)),
        fetchChapters: (id) => dispatch(fetchChapters(id)),  
        fetchChapter:(id1,id) => dispatch(fetchChapter(id1,id)) ,  
        deleteChapter:(id,com) =>dispatch(deleteChapter(id,com)),
        updateComic:(id,Name,Author,genre_id,des,Image,time,chaps,tus)=> dispatch(updateComic(id,Name,Author,genre_id,des,Image,time,chaps,tus))
  };
}
  export default connect(mapStateToProps, mapDispatchToProps)(Update_Comic);
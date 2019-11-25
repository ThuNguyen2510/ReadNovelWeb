import React from 'react';
import {Link,Route} from 'react-router-dom';
import Nav from './Nav';
import Content from './Content';
import './Admin_Comic.css';
import {connect} from 'react-redux';
import Breadcrumb from './Breadcrumb';
import {fetchGenres} from '../../actions/GenreAction';
import {addComic} from '../../actions/ComicActions';
import ImageUploader from 'react-images-upload';
class AddComic extends React.Component{
    constructor(props)
    {
        super(props)
        this.state={ images: [],imageUrls: []}
        this.Save = this.Save.bind(this);
    }
    componentDidMount()
    {
        this.props.fetchGenres()
    }
    select()
    {
        var s=[]
      
        s=this.props.gens.map(a=>{
        return  <option value={a.id} >{a.genre_name}</option>
        })
        return s;
    }
    Save(e)
    {
        e.preventDefault();
        var temp= new Date
        var date=temp.getMonth()+"/"+temp.getDate()+"/"+temp.getFullYear()
        let {name,genre_id,author,des} = this.state;
        var img=localStorage.getItem('image_url')
        var id=parseInt(genre_id)
        if(window.confirm('Add a comic??'))
        {
            this.props.addComic(name,id,author,0,des,date,img)
            alert("Add success")

        }
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
            imageUrls: reader.result
          })
          localStorage.setItem('image_url',reader.result)
        };
    }
   
    render()
    {
        let {name,author,genre_id,chap_number,des}=this.state
        var image1={
            width: "210px",
            height: "240px"
        }
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
                                        <input type="text" value={name} onChange={e=> this.setState({name: e.target.value})}  class="form-control" id="username" required=""></input>
                                    </div>
                                </div>
                                <div className="mb-3">
                                    <label for="username">Tác giả</label>
                                    <div class="input-group">
                                        <div class="input-group-prepend"> </div>
                                        <input type="text" value={author} onChange={e=> this.setState({author: e.target.value})} class="form-control" id="username" required=""></input>
                                    </div>
                                </div>
                            
                                <div className="mb-3">
                                    <label for="username">Thể loại</label>
                                        <select value={genre_id} onChange={e=> this.setState({genre_id: e.target.value})} className="custom-select d-block w-100" id="country" required="">
                                            {this.select()}
                                        </select>
                                </div>
                                <div className="mb-3">
                                    <label for="username">Mô tả</label>
                                    <div className="form-group">
                                        <textarea value={des} onChange={e=> this.setState({des: e.target.value})} className="form-control" id="exampleFormControlTextarea3" rows="4"></textarea>
                                    </div>
                                </div>

                                <div className="mb-3">
                                <label><Link to="/Comic/"><i class="fas fa-plus"></i>Thêm chương </Link></label>
                                
                                </div>
                            </form>
                        </div>
                        <div className="col-md-4 order-md-2 ml-3 mb-4">
                            <div className="row">
                                <img style={image1} src={(this.state.imageUrls.length>0)?this.state.imageUrls:"http://dummyimage.com/250x235.bmp/dddddd/000000"}></img>
                            </div>
                            <input className="form-control " type="file" 
                                onChange={this.selectImages} multiple/>                        
                        </div>                    
                    </div>{ console.log(this.state)}
                        <div className="row">
                            <div className="col-md-7"></div>
                            <div className="col-md-5">
                                <button type="button" onClick={this.Save} class="btn btn-pill btn-warning">Lưu</button>
                                <button type="button"  onClick={e=>this.props.history.goBack()}  class="btn btn-square btn-secondary">Cancel</button>
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
    gens:state.genre,
  };
}
const mapDispatchToProps = (dispatch) => {
    return {
        fetchGenres :()=> dispatch(fetchGenres()),
        addComic:(name,id,author,chap_number,des,date,img)=>dispatch(addComic(name,id,author,chap_number,des,date,img))
  };
}
  export default connect(mapStateToProps, mapDispatchToProps)(AddComic);
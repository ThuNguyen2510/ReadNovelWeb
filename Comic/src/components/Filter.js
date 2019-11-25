import React from 'react';
import './Filter.css';
import {Link} from 'react-router-dom'
import Header from './Header';
import Nav from './Nav';
import LeftBody from './LeftBody';
import RightBody from './RightBody';
import Footer from  './Footer';
import Comic from './Comic'
import {connect} from 'react-redux';
import {SearchByName} from '../actions/SearchAction';
import {fetchGenres} from '../actions/GenreAction';
import {fetchComicUpdateNew2,fetchComicHot,fetchComicByCategory} from '../actions/ComicActions'
import comic from '../reducers/a_comic_reducer';
class Filter extends React.Component
{
    constructor(props)
    {
        super(props)
        
    }
    componentDidMount()
    {
       
        this.props.fetchGenres()
        
        if(window.location.pathname=='/TruyenMoi')
        {
            this.props.fetchComicUpdateNew2()
        }
        if(window.location.pathname=='/TruyenHot')
        {
            
            this.props.fetchComicHot()
            
        }else
        {
            this.props.SearchByName(localStorage.getItem('searchByName'))
        }
        
    }
    componentWillMount()
    {
        this.props.fetchGenres()
        
        if(window.location.pathname=='/TruyenMoi')
        {
            this.props.fetchComicUpdateNew2()
        }
        if(window.location.pathname=='/TruyenHot')
        {
            
            this.props.fetchComicHot()
            
        }else
        {
            this.props.SearchByName(localStorage.getItem('searchByName'))
        }
    }
    filter(comics)
    {
        comics.length=0;
        for(var i=0;i<this.props.comicsfilter.length;i++)
         comics.push(<Comic  id={this.props.comicsfilter[i].id} Src={this.props.comicsfilter[i].Image}
             name={this.props.comicsfilter[i].Name} author={this.props.comicsfilter[i].Author}
              follow={this.props.comicsfilter[i].Number_of_Read} like={this.props.comicsfilter[i].Number_of_Like}/>)
        
    }
    render()
    { 
    
        localStorage.setItem('searchByName',this.props.match.params.string)
        var con_m21={
        backgroundColor: "#fff",
        height: "98%",
      
        
    }
    var but_style={
        cursor: "pointer",
        background: "#FFFFFF",
        border: "1px solid #E1E1E11",
        padding: "3px 10px",
        fontWeight: "bold"
    }
    var table_s={
        textAlign:"center",
        width:"70%",

    }
    var h={
        color:"#ef2d3f"
    }
    var li={
        listStyle:"none"
    }
    var option=this.props.list.map((a,index)=>{
        return <><option value={a.id} id={index}>{a.genre_name}</option></>
        })
    var comics=[]    
    if((window.location.pathname!=='/TruyenMoi'||window.location.pathname!=='/TruyenHot')&&this.props.result.length>0){
      
         comics=this.props.result.map(a=>{
        return <Comic  id={a.id} Src={a.Image} name={a.Name} author={a.Author} follow={a.Number_of_Read} like={a.Number_of_Like} />
    })  }
     if(window.location.pathname=='/TruyenMoi'&&this.props.new.length>0){
       
        comics=this.props.new.map(a=>{
        return <Comic  id={a.id} Src={a.Image} name={a.Name} author={a.Author} follow={a.Number_of_Read} like={a.Number_of_Like}/>})
    }
     if(window.location.pathname=='/TruyenHot'&& this.props.hot.length>0)
    {

        comics=this.props.hot.map(a=>{
        return <Comic  id={a.id} Src={a.Image} name={a.Name} author={a.Author} follow={a.Number_of_Read} like={a.Number_of_Like}/>})
    }
        return(
            <>
            <Header/>
            <div>
                <hr/>
                <div className="container">
                    <div className="row">
                        <div className="col-md-12 col-lg-9 mb-4">
                           
                            <div  style={con_m21}>
                <div className="content m2l">
                <div >
                    <form>
                        <table style={table_s}>                          
                            <tr>
                            <td> 
                          
                                <select onChange={e=>this.props.fetchComicByCategory(e.target.value)} class="mdb-select md-form colorful-select dropdown-primary">
                                    <option >Thể Loại </option>
                                    {option}
                                    {this.filter(comics)}
                                    
                            </select>
                            </td>
                            <td>
                              
                            </td>
                            <td>                            
                                <input type="checkbox" />Truyện Full
                            </td>
                            <td>
                                <button type="submit" className="btn btn-search"><i class="fa fa-search fa-fw"></i>Tìm truyện</button>
                            </td>
                            </tr>                                                
                        </table>
                    </form>
                </div>
                </div>
                <hr></hr>
                <div>
                <nav aria-label="Page navigation example">
                    <ul className="pagination justify-content-center">
                        <li className="page-item">
                            <Link className="page-link" to="/" aria-label="Previous">
                            <span aria-hidden="true">«</span>
                            <span className="sr-only">Previous</span>
                            </Link>
                        </li>
                        <li className="page-item"><Link className="page-link" to="#">1</Link></li>
                        <li className="page-item"><Link className="page-link" to="#">2</Link></li>
                        <li className="page-item"><Link className="page-link" to="#">3</Link></li>
                        <li className="page-item">
                            <Link className="page-link" to="/" aria-label="Next">
                            <span aria-hidden="true">»</span>
                            <span className="sr-only">Next</span>
                            </Link>
                        </li>
                    </ul>
                </nav>
                </div>
               <div className="row ">     
                   { (comics.length) && comics }
                </div> 
                <div className="row ">
                   { !comics.length && <p style={{marginLeft:"40%"}}>NO RESULT</p> }
                </div> 
            </div>
                        </div>
                        <div className="col-md-12 col-lg-3">
                            <RightBody/>
                        </div>
                    </div>
                    <hr/>
                    <div className="row mt-2">
                        <Footer/>
                    </div>
                </div>
            </div>
            </>
        );
    }
}

const mapStateToProps = (state) => {
    return {
     result:state.search,
     list: state.genre,
     new: state.comicnew,
     hot:state.comichot,
     comicsfilter:state.comics
    }
  }
  
const mapDispatchToProps = (dispatch) => {
    return {
      SearchByName:(keyword) =>dispatch(SearchByName(keyword)),
      fetchGenres:() =>dispatch(fetchGenres()),
      fetchComicByCategory:(id)=> dispatch(fetchComicByCategory(id)),
      fetchComicUpdateNew2:() => dispatch(fetchComicUpdateNew2()) ,
      fetchComicHot:() => dispatch(fetchComicHot())
    };
  }
  
  export default connect(mapStateToProps, mapDispatchToProps)(Filter);
  
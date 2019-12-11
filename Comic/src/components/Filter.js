import React from 'react';
import './Filter.css';
import {Link} from 'react-router-dom'
import Header from './Header';
import RightBody from './RightBody';
import Footer from  './Footer';
import Comic from './Comic'
import {connect} from 'react-redux';
import {SearchByName} from '../actions/SearchAction';
import {fetchComicHot,fetchComicByCategory} from '../actions/ComicActions'
class Filter extends React.Component
{
    constructor(props)
    {
        super(props)
        this.search=this.search.bind(this);
    }
    componentDidMount()
    {
       
        // if(window.location.pathname==='/TruyenHot')
        // {
            
        //     this.props.fetchComicHot()
            
        // }else
        // {
        //     this.props.SearchByName(localStorage.getItem('searchByName'))
        // }
        
    }
   
    filter(comics)
    {
        comics.length=0;
        for(var i=0;i<this.props.comicsfilter.length;i++)
         comics.push(<Comic  id={this.props.comicsfilter[i].id} Src={this.props.comicsfilter[i].Image}
             name={this.props.comicsfilter[i].Name} author={this.props.comicsfilter[i].Author}
              follow={this.props.comicsfilter[i].Number_of_Read} like={this.props.comicsfilter[i].Number_of_Like}/>)
        
    }
    search(e)
    {
        console.log("mdk")
    }
    getGenreId(genre)
    {
        console.log(genre)
        for(var i=0;i<this.props.list.length;i++)
        {
            console.log(this.props.list[i].genre_name)
            if(this.props.list[i].genre_name==genre)
            {
                return this.props.list[i].genreID
            }
            
        }
    }
    render()
    { 
    
        localStorage.setItem('searchByName',this.props.match.params.string)
        var con_m21={
        backgroundColor: "#fff",
        height: "95%",
      
        
    }
    var table_s={
        textAlign:"center",
        width:"70%",

    }
    var li={
        listStyle:"none"
    }
    var option=this.props.list.map((a,index)=>{
        return <><option value={a.genreID} id={a.genreID}>{a.genre_name}</option></>
        })
    var comics=[]    
        comics=this.props.result.map(a=>{
            return <Comic  id={a.id} Src={a.image} name={a.name} author={a.author} follow={a.views} like={a.likes}/>
        })
        return(
            <div className="container-fluid">
            <Header/>
            <div>
                <div className="container mt-2">
                    <div className="row">
                        <div className="col-md-12 col-lg-9 mb-4">
                           
                            <div  style={con_m21}>
                <div className="content m2l">
                <div >
                    <form>
                        <table style={table_s}>                          
                            <tr>
                            <td> 
                          
                                <select onChange={e=>localStorage.setItem('genreid',(e.target.value))} class="mdb-select md-form colorful-select dropdown-primary">
                                    <option >Thể Loại </option>
                                    {option}
                                                                       
                            </select>
                            </td>
                            <td>
                              
                            </td>
                            <td>                            
                                <input type="checkbox" />Truyện Full
                            </td>
                            <td>
                                <button onClick={this.search} className="btn btn-search"><i class="fa fa-search fa-fw"></i>Tìm truyện</button>
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
                   
                </div>
                <div className="row mt-2">
                        <Footer/>
                    </div>
            </div>
            </div>
        );
    }
}

const mapStateToProps = (state) => {
    return {
     result:state.search,
     list: state.genre
    }
  }
  
const mapDispatchToProps = (dispatch) => {
    return {
      SearchByName:(keyword) =>dispatch(SearchByName(keyword)),
      fetchComicByCategory:(id)=> dispatch(fetchComicByCategory(id))
    };
  }
  
  export default connect(mapStateToProps, mapDispatchToProps)(Filter);
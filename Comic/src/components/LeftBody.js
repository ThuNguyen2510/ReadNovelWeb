import React from 'react';
import ListComic from './ListComic';
import {Link,Redirect} from 'react-router-dom';
import './LeftBody.css';
import {connect} from 'react-redux';
import {fetchGenres} from '../actions/GenreAction';
import {fetchComicByCategory} from '../actions/ComicActions'
class LeftBody extends React.Component{
    constructor(props)
    {
        super(props)
        this.Search23 = this.Search23.bind(this);
    }
    componentDidMount()
    {
        this.props.fetchGenres()
    }
    componentWillMount()
    {
        this.props.fetchGenres()

    }
    filter()
    {
        var check=document.getElementById('check').checked
        localStorage.setItem('checkbox',check)

    }
    Search23(e)
    {
        this.props.fetchComicByCategory(1)
    }
    render(){
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
            return <><option value={a.id} id={a.id}>{a.genre_name}</option></>
            })
        return(
            <div style={con_m21}>
                <div className="content m2l">
                <div >
                    <form>
                        <table style={table_s}>                          
                            <tr>
                            <td> 
                                <select onChange={e=>this.props.fetchComicByCategory(e.target.value)} className="mdb-select md-form colorful-select dropdown-primary"  >
                                    <option value="0" >Thể Loại </option>
                                    {option}
                            </select>
                            </td>
                            <td>
                                
                            </td>
                            <td>                            
                                <input type="checkbox" id="check"/>Truyện Full
                            </td>
                            <td>
                                <button onClick={this.Search23} className="btn btn-search"><i class="fa fa-search fa-fw"></i>Tìm truyện</button>
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
               <div className="row">
                   <ListComic/>
                   </div> 
            </div>
        );

        
    }
}
const mapStateToProps = (state) => {
    return {
     list: state.genre
    }
  }
  
  const mapDispatchToProps = (dispatch) => {
    return {
      fetchGenres:() =>dispatch(fetchGenres()),
      fetchComicByCategory:(id) => dispatch(fetchComicByCategory(id))
  
    };
  }
  
  export default connect(mapStateToProps, mapDispatchToProps)(LeftBody);
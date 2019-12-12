import React from 'react';
import './Nav.css';
import {Link} from "react-router-dom";
import 'react-awesome-slider/dist/styles.css';
import {connect} from 'react-redux';
import {fetchGenres} from '../actions/GenreAction'
class Nav extends React.Component{
    
      constructor(props)
      {
        super(props)
      }
     
    componentDidMount()
    {   
      this.props.fetchGenres()
    }
    render(){
      var li_style={
        listStyle: "none"
    }
    var option=this.props.list.map((a,index)=>{
    return(
        <li className="cate ml-5">
        <Link style={{color:"Black"}} to="/Search">{a.genre_name}</Link><br/>
        </li>
    )
    });

        return(
            <div  id="header">             
                <div className="wrap-nav" >
                    <div className="second-nav">
                        <ul className="menu ml-5">
                            <li className="nav-item">
                                <i  style={{marginRight:"-15px"}}  className="fas fa-home"></i><Link to="/">TRANG CHỦ</Link>
                            </li>
                            <li className=" nav-item dropdown">
                                <Link className="dropdown" to="/">THỂ LOẠI</Link><i className="fas fa-caret-down" style={{marginLeft:"-10px"}} ></i>
                                <ul className="dropdown-content">
                                    {option}
                                </ul>
                            </li>
                            <li className="nav-item">
                                <Link to="/TruyenHot">TRUYỆN HOT</Link>
                            </li>
                            <li className="nav-item">
                                <Link to="/Forum">DIỄN ĐÀN</Link>
                            </li>
                        </ul>
                    </div>
                </div>
                <hr style={{marginTop:"-12px"}}/>
            </div>

        )
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
  };
}
export default connect(mapStateToProps, mapDispatchToProps)(Nav);
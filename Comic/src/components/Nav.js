import React from 'react';
import './Nav.css';
import { Router, Link, NavLink } from "react-router-dom";
import AwesomeSlider from 'react-awesome-slider';
import 'react-awesome-slider/dist/styles.css';
import {connect} from 'react-redux';
import {logout} from '../reducers/login_reducer';
import {fetchGenres} from '../actions/GenreAction'
import LeftBody from './LeftBody';
import Search from './Search';
import Home from './Home';
import {SearchByName} from '../actions/SearchAction'
class Nav extends React.Component{
    
      constructor(props)
      {
        super(props)
        this.state={
          flag:false,
          login:false
        }
        this.handleClick=this.handleClick.bind(this)
      }
     
    componentDidMount()
    {   
      this.props.fetchGenres()
      this.props.logout()
    }
    render(){
      var li_style={
        listStyle: "none"
    }
    var option=this.props.list.map((a,index)=>{
    return <><option id={index}>{a.genre_name}</option></>
    });
    let {search}=this.state
        return(
          <>
              <nav className="navbar navbar-expand-lg navbar-light bg-color">
                <div className="logo">
                  <img className="img" src = {require('../TVT.PNG')} alt = "logo"></img>
                </div>
                <button className="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                  <span className="navbar-toggler-icon" />
                </button>
                <div className="collapse navbar-collapse" id="navbarSupportedContent">
                  <ul className="navbar-nav mr-auto">
                    <li className="nav-item active">
                      <Link className="name" to="/"><i className="fas fa-home"></i> Trang Chủ<span className="sr-only">(current)</span></Link>
                    </li>
                    <li className="nav-item">
                      <Link className="name" to="/TruyenHot"><i className="fab fa-hotjar"></i> Truyệt hot</Link>
                    </li>
                    <li className="nav-item subnav" >
                      <Link className="name" to="/Category">Thể loại</Link><i class="fas fa-caret-down"></i>
                      <div class="subnav-content">
                        {option}
                      </div>
                    </li> 
                    <li className="nav-item">
                      <Link className="name" to="/TruyenMoi" ><i className="fas fa-newspaper"></i> Truyện mới</Link>
                    </li>
                  </ul>
                  <form className="form-inline my-2 my-lg-0 form" >
                    <input  value={search} onChange={e => this.setState({search: e.target.value}) }
                     className="input" id='search' type="search" placeholder="Tìm truyện..." aria-label="Search" />
                   <Link  onClick={this.handleClick} to={"/search/"+search} className="btn btn-danger" id="btnsearch" ><i className="fas fa-search btnsearch"></i></Link>
                  </form>
                </div>
                <div className ="sign">
                  {this.login_logout()}                  
                    </div>
              </nav>           
             
        </>

        )
    }
    
    handleClick()
      {
        this.setState({
          flag:true
        });
        this.props.SearchByName(this.state.search)
        
      }
  
    login_logout()
    {
      if(localStorage.getItem('login')==='success')
      { 
        
        return this.login()
      }
      else{
        
        return   <>
        <Link className="link" id="login" to='/Signin'  ><i className="fas fa-sign-in-alt link" ></i></Link> 
        </> 
      }
     
    }
    logoutf()
    {
       localStorage.removeItem('login')
       localStorage.removeItem('logined_user')
       //document.getElementById('user').remove()
      var link=document.getElementById('login')
        link.setAttribute('href','/Signin')
        var icon=document.getElementById('icon')
        icon.setAttribute('class','fas fa-sign-in-alt link')
     //   link.setAttribute('data-content','Signin/Signup')
        document.getElementById("user").style.visibility = "hidden";
        
      
       
    }
    login()
    {
      var span
      var link
      var i
      var user     
        span='Logout'
        link='/'
        i="fas fa-sign-out-alt"
        user=<Link to="/User/page" id="user">{JSON.parse(localStorage.getItem('logined_user')).username}</Link>       
      return <>
        {user}
       <Link onClick={this.logoutf}  id="login" className="link" to={link}><i id="icon" className={i}></i></Link> 
       </>          

    }

   

}
const mapStateToProps = (state) => {
  return {
   list: state.genre
  }
}

const mapDispatchToProps = (dispatch) => {
  return {
    logout:() =>dispatch(logout()),
    fetchGenres:() =>dispatch(fetchGenres()),
    SearchByName:(keyword) =>dispatch(SearchByName(keyword))

  };
}
export default connect(mapStateToProps, mapDispatchToProps)(Nav);
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
import './Top_bar.css';
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
            <div id="headers">             
                <div className="container" >
                    <div className="row level" style={{backgroundColor:"#fff"}}>
                        <div className="d-flex justify-content-start">
                            <Link className="logo">
                                <img className="img" style={{width:"100px"}} src = {require('../TVT.PNG')} alt = "logo"></img>
                            </Link>      
                        </div>                      
                        <div className="input-group  d-flex justify-content-center " style={{width:"500px"}}>
                            <input className="form-control py-2 border-right-0 border-radius-25" type="search" placeholder="What are you looking for?"  id="ip1" />
                            <span className="input-group-append">
                                <button className="btn btn-outline-secondary border-left-0 border" style={{backgroundColor:"#0282f9"}} id="ip2" type="button">
                                <i className="fa fa-search" style={{color:"#fff"}} />
                                </button>
                            </span>
                        </div>                          
                        <div className="d-flex justify-content-end">
                          <div className ="sign mr-5">
                              {this.login_logout()}                  
                          </div>
                        </div>
                    </div>
                </div>
              
            </div>
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
        <Link className="link mr-auto"  id="login" to='/Signin'  >Log in<i className="fas fa-sign-in-alt link" ></i></Link> 
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
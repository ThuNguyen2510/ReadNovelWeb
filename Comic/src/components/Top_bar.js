import React from 'react';
import './Nav.css';
import {Link} from "react-router-dom";
import {connect} from 'react-redux';
import {logout} from '../reducers/login_reducer';
import {fetchGenres} from '../actions/GenreAction'
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
    let {search}=this.state
        return(
          <>
            <div id="headers">             
                <div className="container" >
                    <div className="row level" style={{backgroundColor:"#fff"}}>
                        <div className="d-flex justify-content-start">
                            <Link className="logo"  to="/">
                                <img className="img" style={{width:"100px"}} src = {require('../TVT.PNG')} alt = "logo"></img>
                            </Link>      
                        </div>                      
                        <div className="input-group  d-flex justify-content-center " style={{width:"500px"}}>
                            <input className="form-control py-2 border-right-0 border-radius-25" type="search" placeholder="What are you looking for?"  id="ip1" />
                            <span className="input-group-append">
                            <Link  onClick={this.handleClick} to={"/search/"+search} className="btn" id="ip2" ><i style={{color:"#fff"}} className="fas fa-search btnsearch"></i></Link>
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
        
        return   (
        <>
            <Link className="btn"  id="login" to='/Signin' >Đăng nhập</Link> 
            <Link className="btn ml-2"  id="signup" to='/Signup' >Đăng ký</Link> 
        </> 
        )
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
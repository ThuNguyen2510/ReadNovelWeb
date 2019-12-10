import React from 'react';
import './Nav.css';
import {Link} from "react-router-dom";
import 'react-awesome-slider/dist/styles.css';
import {connect} from 'react-redux';
import {logout} from '../reducers/login_reducer';
import {fetchGenres} from '../actions/GenreAction'
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
    return(
        <li className="cate ml-5">
        <Link   id={index} style={{color:"gray"}}>{a.genre_name}</Link><br/>
        </li>
    )
    });
    let {search}=this.state
        return(
            <div  id="header">             
                <div className="wrap-nav" >
                    <div className="second-nav">
                        <ul className="menu ml-5">
                            <li>
                                <i  style={{marginRight:"-15px"}}  className="fas fa-home"></i><Link to="/">TRANG CHỦ</Link>
                            </li>
                            <li className=" dropdown">
                                <Link className="dropdown" to="/">THỂ LOẠI</Link><i className="fas fa-caret-down" style={{marginLeft:"-10px"}} ></i>
                                <ul className="dropdown-content">
                                    {option}
                                </ul>
                            </li>
                            <li>
                                <Link to="/">TRUYỆN HOT</Link>
                            </li>
                            <li>
                                <Link to="/Forum">DIỄN ĐÀN</Link>
                            </li>
                        </ul>
                    </div>
                </div>
                <hr style={{marginTop:"-12px"}}/>
            </div>

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
        icon.setAttribute('className','fas fa-sign-in-alt link')
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
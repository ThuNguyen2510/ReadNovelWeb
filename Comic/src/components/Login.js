import React from 'react';
import { Router, Route, Link,Switch, NavLink } from "react-router-dom";
import Signup from './Signup';
import Home from './Home';
import { connect } from 'react-redux';
import {Redirect} from 'react-router-dom';
import { login } from './../reducers/login_reducer';
class Login extends React.Component{
    constructor(props) {
        super(props);
        this.state = {};
        console.log("OK")
        if(localStorage.getItem('signup')!=null)localStorage.removeItem('signup')
        this.onSubmit = this.onSubmit.bind(this);
    }
    render()
    {
      var image_s={
        width:"250px"
      }
    var d_s={
                
        border: "1px solid #E1E1E1",
        padding: "10px 20px 10px 10px",
        backgroundColor: "#42100f",
        borderRadius: "8px",
        width: "500px",
        textAlign: "center",
    }
    var sign={
        color: "#f66b00",
        fontWeight:" bold",

    }
    var p={
        textAlign:"left",
        fontWeight:" 600",
        fontVariant: "ordinal"
    }
    var input={
        width: "400px",
        marginLeft:" 40px"
    }
    var thi={
        display: "inline-block",
    }
    var i={
      color:"red"
    }
        let {email, password} = this.state;
        let {isLoginPending, isLoginSuccess, loginError} = this.props;
        return(
                  
             <>
             <div className="containers h-100">
                <div className="row h-100 justify-content-center align-items-center">
                  <Link to="/"><img src={require('../TVT.PNG')} style={{width:'250px'}} alt="Logo"/></Link>
                </div>
              </div>
              <form name="loginForm" className="row h-100 justify-content-center align-items-center" onSubmit={this.onSubmit}>
                <div className="position-relative ">
                  <div className="box">
                    <div className="row">
                      <div className="col-md-12">
                        <div className="bg-white" id="bran" style={d_s}>
                          <h1 style={sign}>SIGN IN</h1>
                          <form action="">
                            <div className="form-group">
                              <p style={p} ><i className="far fa-user"></i> User Name</p>
                              <input style={input} type="text" className="form-control" id="userName"
                              placeholder="User name" onChange={e => this.setState({email: e.target.value})} value={email} required/>
                            </div>
                            <div className="form-group">
                            <p style={p}><i className="fas fa-lock"></i> PassWord</p>
                              <input style={input}type="password" className="form-control" id="passWord"
                              placeholder="***********" onChange={e => this.setState({password: e.target.value})} value={password} required />
                            </div>
                            <div className="message">  
                            { isLoginSuccess && this.LoginSuccess() }
                            { loginError && <p style={i}>Check PassWord and Username</p> }
                            {!isLoginSuccess}
                          </div>
                            <button type="submit" className="btn btn-primary" >Sign in</button>
                            
                          </form>
                        </div>
                      </div>
                    </div>
                    <div className="row  justify-content-center " >
                      <ul>
                      <li style={{listStyle:"none"}}>
                        <div>Not have Account <Link to="/Signup" >Signup</Link></div>
                      </li>
                      <br/>
                      <li style={{listStyle:"none"}}>
                        <span><Link to="/"><i className="far fa-arrow-alt-circle-left"></i>Back to Homepage </Link></span>
                      </li>
                      </ul>
                      
                    </div>
                  </div>
                </div>
              </form>
             </>

         
        )
    }
    LoginSuccess()
    {
      
      localStorage.setItem('login','success')
      let user =JSON.parse(localStorage.getItem('logined_user'))
      if(user.role==0)      
      { 
        return <Redirect  to="/"/>
        
      }
      else if(user.role==1)
      {
        
        return  <Redirect to="/Admin" />
      }
     
    }
    onSubmit(e) {
        e.preventDefault();
        let { email, password } = this.state;
        this.props.login(email, password);
        this.setState({
          email: '',
          password: '',
        });
      }
    
}


const mapStateToProps = (state) => {
    return {
      isLoginPending: state.login.isLoginPending,
      isLoginSuccess: state.login.isLoginSuccess,
      loginError: state.login.loginError
    };
  }
  
  const mapDispatchToProps = (dispatch) => {
    return {
      login: (email, password) => dispatch(login(email, password)),
    };
  }
  
  export default connect(mapStateToProps, mapDispatchToProps)(Login);
import React from 'react';
import { Link, Route } from 'react-router-dom';
import Content from './Content';
import Footer from './footer';
import Info from './Info';
import './index.css'
class index extends React.Component {
    constructor(props){
        super(props)
       
    }
    render() {
        var meno = {
            marginTop: "20px",
        }
        var content=[];
        if(JSON.parse(localStorage.getItem('logined_user'))!=null)
        {
           
            var user =JSON.parse(localStorage.getItem('logined_user'))
            if(user.role!=2)
            {
                content.push(<p>NOT ALLOW</p>)
            }
            else if(user.role==2)
            {
                content.push( <div id="mmenu_screen">
                <div className="clear" />
                <div className="row flex-fill">
                    <div className="col-md-2" >
                        <Content role={user.role} />
                    </div>
                    <div className="col-md-10 " >
                        <Info/>
                        <Footer/>
                    </div>
                </div>
            </div>)
            }
            
        }
        return (
           <div>
               {content}
           </div>
        );
    }
}
export default index;
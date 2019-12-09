import React from 'react';
import {Link,Route} from 'react-router-dom';
import Hello from './Hello';
import Nav from './Nav';
import Content from './Content';
class index extends React.Component{
    
    render(){
        var meno={
            marginTop: "20px",
        }
        return(
            <>
            <div className="containers">
                <div className="row">
                    <div className="col-md-2 col-lg-2" >
                        <Content/>
                    </div>
                    <div className="col-md-10 col-lg-10 ">
                        <Nav/>
                        <Hello/>
                    </div>
                </div>
            </div>
            </>
        );
    }
}
export default index;
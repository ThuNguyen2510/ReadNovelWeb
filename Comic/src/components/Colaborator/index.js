import React from 'react';
import { Link, Route } from 'react-router-dom';
import Content from './Content';
import Footer from './footer';
import Info from './Info';
import './index.css'
class index extends React.Component {
    render() {
        var meno = {
            marginTop: "20px",
        }
        return (
            <div id="mmenu_screen">
                <div className="clear" />
                <div className="row flex-fill">
                    <div className="col-md-2" >
                        <Content />
                    </div>
                    <div className="col-md-10 " >
                        <Info/>
                        <Footer/>
                    </div>
                </div>
            </div>
        );
    }
}
export default index;
import React from 'react';
// import './Home.css';
import Header from './Header.js';
import Slider from './Slider';
import LeftBody from './LeftBody';
import Footer from './Footer.js';
import RightBody from './RightBody'
class Home extends React.Component{
    render(){
      
        return(
            <div className="container-fluid">
                <Header/>
                <Slider/>
                <div className="container bg-navy">
                    
                    <div className="row mt-3">
                        <div className="col-md-8 ">
                            <LeftBody/>
                        </div>
                        <div className="col-md-4">
                            <RightBody/>
                        </div>
                    </div>
                </div>
                <Footer/>
            </div>
        )
    }
}
export default Home;
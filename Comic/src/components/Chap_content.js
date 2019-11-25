import React from 'react'
import Header from './Header'
import Footer from './Footer'
import './Chap_content.css'

class Chap_content extends React.Component{
    render(){
        return(
            <div>
                <div className="container">
                    <div className="row">
                        <div className="col-md-10 offset-1 content">
                            {this.props.content}
                        </div>
                    </div>
                </div>
            </div>
        );
    }
}
export default Chap_content;
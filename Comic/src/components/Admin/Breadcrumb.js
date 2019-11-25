import React from 'react';
import {Link,Route} from 'react-router-dom';
class Breadcrumb extends React.Component{
    render(){
        return(
            <div>
                <ol className="breadcrumb mt-2">
                    <li className="breadcrumb-item">
                    <Link to="/Admin">TVT</Link>
                    </li>
                    <li className="breadcrumb-item active">{this.props.br}</li>
                </ol>
            </div>
        )
    }
}
export default Breadcrumb;
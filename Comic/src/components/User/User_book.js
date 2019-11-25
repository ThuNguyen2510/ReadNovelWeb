import React from 'react';
import './User_book.css';
import { Link, Route } from 'react-router-dom';
import Sidebar from './Sidebar';
import Nav from './Nav';
import Book from './Book';
class User_book extends React.Component{
    render(){
        return(
            <>
                <div className="row">
                    <div className="col-xs-6 col-md-2">
                        <Sidebar/>
                    </div>
                    <div className="col-xs-12 col-sm-6 col-md-10">
                        <div className="ml-sm-2">
                            <Nav br="Tủ sách"/>
                        </div> 
                        <div>
                            <Book/>
                        </div>                       
                    </div>  
                </div>
            </>
        )
    }
}
export default User_book;
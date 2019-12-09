import React from 'react';
import ListComic from './ListComic';
import {Link} from 'react-router-dom';
import './LeftBody.css';
import {connect} from 'react-redux';
import {fetchGenres} from '../actions/GenreAction';
import {fetchComicByCategory} from '../actions/ComicActions'
class LeftBody extends React.Component{
    constructor(props)
    {
        super(props)
    }
    filter()
    {
        var check=document.getElementById('check').checked
        localStorage.setItem('checkbox',check)

    }
    render(){
        var con_m21={
            backgroundColor: "#fff",
            height: "95%",
            width: "100%"
        }
        var table_s={
            textAlign:"center",
            width:"70%",
        }
        var li={
            listStyle:"none"
        }
       
        return(
            <div style={con_m21}>
               <div className="row">
                   <ListComic/>
                </div> 
            </div>
        );

        
    }
}
const mapStateToProps = (state) => {
    return {
    }
  }
  
  const mapDispatchToProps = (dispatch) => {
    return {
    };
  }
  
  export default connect(mapStateToProps, mapDispatchToProps)(LeftBody);
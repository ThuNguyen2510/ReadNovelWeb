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
        this.Search23 = this.Search23.bind(this);
    }
    componentDidMount()
    {
        this.props.fetchGenres()
    }
    componentWillMount()
    {
        this.props.fetchGenres()

    }
    filter()
    {
        var check=document.getElementById('check').checked
        localStorage.setItem('checkbox',check)

    }
    Search23(e)
    {
        this.props.fetchComicByCategory(1)
    }
    render(){
        var con_m21={
            backgroundColor: "#fff",
            height: "95%",
            width: "100%"
        }
        var li={
            listStyle:"none"
        }
        var option=this.props.list.map((a,index)=>{
            return <><option value={a.id} id={a.id}>{a.genre_name}</option></>
            })
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
     list: state.genre
    }
  }
  
  const mapDispatchToProps = (dispatch) => {
    return {
      fetchGenres:() =>dispatch(fetchGenres()),
      fetchComicByCategory:(id) => dispatch(fetchComicByCategory(id))
    };
  }
  
  export default connect(mapStateToProps, mapDispatchToProps)(LeftBody);
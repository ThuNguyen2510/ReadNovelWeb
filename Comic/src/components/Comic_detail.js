import React from 'react';
import {connect} from 'react-redux'
import Header from './Header';
import Nav from './Nav';
import Footer from './Footer';
import Detail from './Detail';
import Detail_R from './Detail_R';
import ListChap from './ListChap';
import Comment from './Comment';
import './Comic_detail.css';
import {Link} from 'react-router-dom'
import {fetchOneComic} from '../actions/ComicActions';
import {fetchChapters} from '../actions/ChapterAction'
class Comic_detail extends React.Component{

    componentDidMount()
    {
        this.props.fetchOneComic(this.props.match.params.index);  
    }
    componentWillMount()
    {}
    image()
    {
        var im;
        for(var i=0;i<this.props.comic.length-1;i++)
        {
          im=<img id="s" src={this.props.comic[i].Image}></img>
        }
        return <>{im}</>
    }
    Detail()
    {
        var result=[];
            for(var i = 0; i < this.props.comic.length-1; i++)
            {
                var s=this.props.comic[i].Status
                var tus=""
                if(s===0)
                {
                    tus="Còn tiếp"
                }
                else if(s===1)
                {
                    tus="Full"
                }
                localStorage.setItem('comic_name',this.props.comic[i].Name)
                result.push(<Detail id_comic={this.props.comic[i].id }Name={this.props.comic[i].Name} 
                    Author={this.props.comic[i].Author} id={this.props.comic[i+1]} 
                    like={this.props.comic[i].Number_of_Like} 
                    read={this.props.comic[i].Number_of_Read} status={tus} description={this.props.comic[i].Description}/>)
            }
           
            return result;
            
    }
    show()
    {
       
        return <>         
        <div className="container-fluid">    
            <Header/>
            </div> 
            
             <hr/>              
            <div className="container">
                <div className="row">
                    <div className="col-md-12 col-lg-9">
                        <div className="row wrap-detail">
                            <div className="col-md-4">
                               {this.image()}
                            </div>
                            <div className="col-md-8 details">
                            {this.Detail()}  
                            </div>
                        </div>
                        <hr/>
                        <div className="col-md-12">
                        <ListChap comic_id={this.props.match.params.index} />
                        </div>
                    </div>
                    <hr/>                    
                    <div className="col-md-12 col-lg-3">
                        <Detail_R/>
                    </div>
                    <div className="col-md-2">
                    </div>
                </div>
                <div className="row">   
                    <Comment comic_id={this.props.match.params.index}/>                
                </div>
                <hr/>
                <div className="row">   
                    <Footer/>                
                </div>
            </div>   
        </>
    }
    render()
    {
       
        return(
            <>
           {this.show()}
           </>
        )
    }
}
const mapStateToProps = (state) => {
    console.log("map")
    console.log(state)
    return {
     comic: state.comic, 
     chaps: state.chapters
    };
  }
  
  const mapDispatchToProps = (dispatch) => {
    return {
      fetchOneComic: (id) => dispatch(fetchOneComic(id)),        
    };
  }
  
  export default connect(mapStateToProps, mapDispatchToProps)(Comic_detail);
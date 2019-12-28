import React from 'react';
import { Link, Redirect } from 'react-router-dom';
import './Detail.css';
import { likeComic } from '../actions/ComicActions';
import { addLike } from '../actions/LikeComicAction';
import { getLike } from '../actions/LikeComicAction';
import { unLike } from '../actions/LikeComicAction';
import { connect } from 'react-redux';
import { fetchGenre } from '../actions/GenreAction';

class Detail extends React.Component {
    constructor(props) {
        super(props)
        this.state = {}
    }
    componentDidMount() {
        // if(JSON.parse(localStorage.getItem('logined_user'))===null)
        // {
        //   if(window.confirm("vui lòng đăng nhập để tương tác")){
        //       return <Redirect to="/Signin" />
        //   }

        // }else{
        if (JSON.parse(localStorage.getItem('logined_user')) != null) {
           
            var user = JSON.parse(localStorage.getItem('logined_user'))
            this.props.getLike(user.id)
        }
        
        // }

    }

    genre(id)
    {
        for(var i=0;i<this.props.genre.length;i++)
        {
            if(id==this.props.genre[i].genreID)
            {
                return this.props.genre[i].genre_name                
            }
        }
    }
    btnClick(a) {
        if (JSON.parse(localStorage.getItem('logined_user')) === null) {
            alert("vui lòng đăng nhập để tương tác")
        } else {
            var user = JSON.parse(localStorage.getItem('logined_user'))
            if(a==1)
            for(var i=0;i<this.props.liked.length;i++){
                if(this.props.id_comic==this.props.liked[i].comicID){
                   this.props.unLike(this.props.id_comic,user.id,this.props.liked[i].id)
                   this.checklike()
                   break
                }
            }
            else if(a==0)
            {
                if(this.props.liked.length!=0)
                for(var i=0;i<this.props.liked.length;i++){
                    if(this.props.id_comic!=this.props.liked[i].comicID){
                        this.props.addLike(user.id,this.props.id_comic)                    
                        this.checklike()
                       break
                    }
                }
                else{
                    this.props.addLike(user.id,this.props.id_comic)                    
                    this.checklike()

                }
            }
           
            
        }

    }
    daLike() {
        return ( 
        <> 
            <button className = "liked" onClick = { e=> this.btnClick(1) } >
                <i className = "fa fa-heart" > </i> 
            </button > 
            <span className = "like" > { this.props.like } </span>
        </> 
        );
    }
    chuaLike() {
        return (
        <> 
            < button className = "but-like" onClick = {e=> this.btnClick(0) } >
                <i className = "fa fa-heart" > </i> 
            </button> 
            < span className = "like" > { this.props.like } </span>
        </>
        );
    }
    checklike(){
        console.log(this.props.liked.length)
        for(var i=0;i<this.props.liked.length;i++){
            if(this.props.id_comic==this.props.liked[i].comicID){
                return this.daLike();
            }
              
            
        }
        return this.chuaLike();
    }
    render() {
 
        return ( 
        <>
            <div className = "title" >
                <h3 className = "title" >
                <Link to = { "/Comic/" + this.props.id_comic }
                className = "comicname" > { this.props.Name } </Link> </h3> 
            </div> 
            <div className = "contend" >
                <div className = "info" >
                    <p> Tác giả: <Link to = "/Author" className = "author" > { this.props.Author } </Link></p >
                    <p> Thể loại: < Link to = {"/Search/"+this.props.genreID} className = "author" > { this.genre(this.props.genreID) } </Link> </p >
                    <p> Trạng thái: < span className = "status" > { this.props.status } </span> </p >
                    <p> </p> 
                    <div className = "view"> {this.checklike()} 
                        <button className = "but-dt" > < i className = "fa fa-eye" > { this.props.read } </i></button >
                    </div>

                </div> 
                <div className = "description" >
                    <p> { this.props.description } </p> 
                    <p> </p> 
                </div> 
            </div> 
        </>
        );
    }

}
const mapStateToProps = (state) => {
    console.log(state)
    return {
        comic: state.comic,
        liked: state.like,
        genre:state.genre
    };
}

const mapDispatchToProps = (dispatch) => {
    return {
        likeComic: (id) => dispatch(likeComic(id)),
        addLike: (user_id, comic_id) => dispatch(addLike(user_id, comic_id)),
        getLike: (uid) => dispatch(getLike(uid)),
        unLike: (comic_id,user_id,id) => dispatch(unLike(comic_id,user_id,id )),
        fetchgenre:()=> dispatch(fetchGenre())
    };
}

export default connect(mapStateToProps, mapDispatchToProps)(Detail);
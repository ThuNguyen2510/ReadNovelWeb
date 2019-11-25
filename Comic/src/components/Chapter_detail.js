import React from 'react';
import Nav from './Nav';
import Header from './Header';
import Footer from './Footer';
import Chap_content from './Chap_content';
import {Link} from 'react-router-dom';
import './Chapter_detail.css';
import {fetchChapter,fetchChapters} from '../actions/ChapterAction'
import {fetchComicName} from '../actions/ComicActions'
import {connect} from 'react-redux'
import { parenthesizedExpression } from '@babel/types';
class Chapter_detail extends React.Component{
    constructor(props)
    {
        super(props)
    }
    componentDidMount()
    {
        this.props.fetchChapter(this.props.match.params.id,this.props.match.params.index)
    }
   componentWillMount()
   {
       this.props.fetchChapter(this.props.match.params.id,this.props.match.params.index)
       this.props.fetchChapters(this.props.match.params.index)
       
   }
   option()
   {
    var chaps=[]
    for(var i=0;i<this.props.chaps.length;i++)
    {
        var select=false;
        if((i+1)==this.props.match.params.id) select=true;
         chaps.push(
         <option id={i+1} value={this.props.chaps[i].id} selected={select}>Chương {this.props.chaps[i].id}: {this.props.chaps[i].chapter_name}</option>)
    }
    return chaps;
   }
   SelectSync1(name)
{
   
    var list2 = document.getElementById('slt2');
	for (var i=0;i<list2.length;i++)
	{
         var listboxname = list2[i].innerHTML.substring(parseInt(list2[i].innerHTML.indexOf('g')+2),parseInt(list2[i].innerHTML.indexOf(':')))
         if (listboxname ===name)
		{
			list2.selectedIndex = i;
			break;
		}
    }
}
SelectSync2(name)
{
    var list1 = document.getElementById('slt1');
	for (var i=0;i<list1.length;i++)
	{
         var listboxname = list1[i].innerHTML.substring(parseInt(list1[i].innerHTML.indexOf('g')+2),parseInt(list1[i].innerHTML.indexOf(':')))
         if (listboxname ===name)
		{
			list1.selectedIndex = i;
			break;
		}
	}
}
   select1()
   {
       return <> <select id={'slt1'} onClick={e=> this.SelectSync1(e.target.value)} className="chapter" onChange= {(e) => this.props.fetchChapter(e.target.value,this.props.match.params.index)} >
       {this.option()}                       
   </select>
       </>
   }

   select2()
   {
       return <> <select id={'slt2'} onClick={e=> this.SelectSync2(e.target.value)} className="chapter" onChange= {(e) => this.props.fetchChapter(e.target.value,this.props.match.params.index)} >
       {this.option()}                       
   </select>
       </>
   }

    show()
    {
        var name=""
        var content=""
        var id
        for(var i=0;i<this.props.chap.length;i++)
        {
            name=this.props.chap[i].chapter_name            
            content=this.props.chap[i].content
            id=this.props.chap[i].id
        }
        return <>
         <div className="nav-content"> 
                    <i className="fas fa-home"></i><Link to="/">Trang chủ</Link><i className="fas fa-angle-right"></i>
                    <Link to={"/Comic/"+this.props.match.params.index}>{localStorage.getItem('comic_name')}</Link><i className="fas fa-angle-right"></i>
                    <Link to={"/Comic/"+this.props.match.params.index+"/Chapter/"+this.props.match.params.id}>Chap {parseInt(id)}</Link>
                    <hr/>
                </div>
                <div className="list-chap">
                    <Link to={"/Comic/"+this.props.match.params.index+"/Chapter/"+this.props.match.params.id}>{name}</Link><br/> 
                    {this.select1()}
                </div>
                 <Chap_content content={content}/>
                    {this.select2()}
                <hr/>
                <Footer/>
            
        </>
    }
  
    render(){
        return(
            <div>
                <Header/>
                <hr/>
                {this.show()}
                <hr/>
                <Footer/>
            </div>   
            
        );

    }
}
const mapStateToProps = (state) => {
    return {
     chap: state.chapter,  
     comic: state.comic,
     chaps:state.chapters
    
  }
}
  
  const mapDispatchToProps = (dispatch) => {
    return {
        fetchChapter: (chap_id,comic_id)=> dispatch(fetchChapter(chap_id,comic_id)),
        fetchChapters: (comic_id) => dispatch(fetchChapters(comic_id)),
       
    };
  }
  
  export default connect(mapStateToProps, mapDispatchToProps)(Chapter_detail);
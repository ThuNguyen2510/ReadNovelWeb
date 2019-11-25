import React from 'react';
import './ListChap.css';
import {Link} from 'react-router-dom';
import {connect} from 'react-redux'
import {fetchChapters} from '../actions/ChapterAction'
class ListChap extends React.Component
{
    constructor(props)
    {
        super(props)
    }
    componentDidMount()
    {
        
        this.props.fetchChapters(this.props.comic_id);
    }
    show1()
    {
        var r=[];
        console.log(this.props.comic_id.parseInt)
        for(var i=0;i<this.props.chaps.length;i++)
        {
            r.push(<> <Link  to={"/Comic/"+this.props.comic_id+"/Chapter/"+(this.props.chaps[i].id)} id="tenchuong">Chương {(this.props.chaps[i].id)}: {this.props.chaps[i].chapter_name}</Link><br></br></>)
        }
        return r;
    }
    show2(r)
    {
        var x=[]
        for(var i=0;i<=r.length/2 -1;i++)
        {
            x.push(r[i])
        }
        return x;
    }
    show3(r)
    {
        var e=[]
        const s=parseInt(r.length/2)
        for(var i=s;i<r.length;i++)
        {
            e.push(r[i])
        }
        return e;
    }
    
    render()
    {  let {chaps} =this.props;
    console.log(this.props);
        return(
            <>
            <div className="row list-chap">
                <div className="col-xs-12">
                    <h4 className="title">Danh sách chương</h4>
                </div>
                <div className="col-sm-6">
                    {this.show2(this.show1())}
                </div>
                <div className="col-sm-6">
                    {this.show3(this.show1())}
                </div>
                </div>
            </>
        );
    }
}
const mapStateToProps = (state) => {
    return {
     chaps: state.chapters,  

    };
  }
  
  const mapDispatchToProps = (dispatch) => {
    return {
        fetchChapters: (id) => dispatch(fetchChapters(id)),     
    };
  }
  
  export default connect(mapStateToProps, mapDispatchToProps)(ListChap);
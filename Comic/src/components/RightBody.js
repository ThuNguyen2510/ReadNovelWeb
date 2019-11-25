import React from 'react';
import Comic_mini from './Comic_mini';
import {Link} from 'react-router-dom';
import {connect} from 'react-redux'
import { fetchComicUpdateNew } from '../actions/ComicActions';
 class RightBody extends React.Component{
   constructor(props)
   {
     super(props)
   }
   componentDidMount()
   {
     this.props.fetchComicUpdateNew()
   }
    show()
    {
       return this.props.list.map((a,index)=>
      <Comic_mini id={a.id} src={a.Image} name={a.Name} datetime={a.Post_DateTime}/>
      )
    }
     render()
     {
        var con_d={
            backgroundColor: "#fff",
            height: "100%",
            border: "2.5px solid #e1e1e1",
            
        }
        var i_s={
            color:"#ef2d3f",
            textDecoration: "none",
        }
        var tb_s={
            margin: "20px"
        }
        var a_style ={
          cursor: "pointer",         
          border: "1px solid #E1E1E1",
          padding: "3px 8px",
          fontWeight:" bold",
          color: "#f66b00",
          textDecoration: "none",
          backgroundColor: "#42100f",
          color: "white",
          borderRadius: "8px"
        }
        
         return(
            <>
            <div className="row">
            <div style={con_d}>
              <div>
              <h5 className="widget-heading font-nav" title="TRUYỆN ĐỌC NHIỀU NHẤT" >
              <i style={i_s} className="fab fa-font-awesome-flag"></i>
                <Link to="/" style={i_s}>TRUYỆN MỚI NHẤT</Link>                
                </h5>
              </div>
              <hr></hr>
              <div className="widget-content" style={tb_s}>
                {this.show()}
              </div> 
              <span class="c-wg-button-wrap">
                  <Link style={a_style} className="widget-view-more" to="/TruyenMoi">Xem thêm</Link>
              </span>           
            </div>
            </div>            
            <div className="row">             
            </div>
            </>
         );

     }
 }

 function mapStateToProps (state)
{
  return{
    list: state.comicnew
  }
}
const mapDispatchToProps = (dispatch) => {
  return {
    fetchComicUpdateNew: () => dispatch(fetchComicUpdateNew()),
  };
}

export default connect(mapStateToProps, mapDispatchToProps)(RightBody);   

import React from 'react';
import AwesomeSlider from 'react-awesome-slider';
import 'react-awesome-slider/dist/styles.css';
import './Slider.css';
import Comic_inSlider from './Comic_inSlider';
import {connect} from 'react-redux';
import {fetchComicHot} from '../actions/ComicActions'

class Slider extends React.Component{
    componentDidMount()
    {
        this.props.fetchComicHot()
    }
    get1()
    {
        var result=[]
        console.log(this.props.listhot)
        for(var i=0;i<this.props.listhot.length/2;i++)
        {
            result.push(
            <div className="col-md-2">
                <Comic_inSlider id={this.props.listhot[i].id} Image={this.props.listhot[i].Image} />
            </div>)
        }
        return result;
    }
    get2()
    {
        var result=[]
        console.log(this.props.listhot)
        for(var i=6;i<this.props.listhot.length;i++)
        {
            result.push(
            <div className="col-md-2">
            <Comic_inSlider id={this.props.listhot[i].id} Image={this.props.listhot[i].Image} />
            </div>)
        }
        return result;
    }
    comic1()
    {
        var c1=[]
         c1.push(
           <>
           {this.get1()}
           </>)
        return c1;
           
    }
    comic2()
    {
        var c2=[]
        c2.push(
           <>
            {this.get2()}
            </>
        )
        return c2;
    }
    show()
    {
        var div=[]
        var j=0;
    
        div.push(
        <div className="row " > 
         {this.comic1()}
        </div>)
        div.push(
        <div className="row "> 
            {this.comic2()}
           </div>
        )    
        return div   

    }
    render()
    {
        var style={
            height:"350px",
            width:"100%",
            marginLeft:"0%"

        }
        var s={
            backgroundColor: "#fffffc",
            float:"left",
            backroundSize: "cover"
        }
        return(
            <>
                  <AwesomeSlider style={style}>
                {this.show()}
                  
                </AwesomeSlider>
            </>
        )
    }
}
const mapStateToProps = (state) =>{
    return{
      listhot: state.comichot
    }
  }
  
  
  
  const mapDispatchToProps =(dispatch, props)=>
  {
    return {
      fetchComicHot : ()=>{
      dispatch(fetchComicHot())
  
    }
  }
  }
export default connect(mapStateToProps, mapDispatchToProps)(Slider);
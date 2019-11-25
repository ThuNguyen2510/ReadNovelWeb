import axios from 'axios';
export const SearchByName = (keyword) =>
{
    
    return dispatch=>{
       
        return axios.get('http://127.0.0.1:3000/comics?Name_like='+keyword).then( 
            data=>{ 
                dispatch(searchByName(data.data))}
        )
    }
}
const searchByName = (comics) => ({
    type : 'SEARCH_BY_NAME',
    comics: comics
    
})

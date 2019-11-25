import axios from 'axios';
export const fetchChapters= (comic_id) =>
{
    return dispatch =>{
        return axios.get('http://127.0.0.1:3000/chapters?comic_id='+comic_id).then(
            data =>{
                const list=data.data
                dispatch(returnListChapter(list));
            }
        )
    }
}
export const fetchChapter = (chapter_id,comic_id) =>
{
    return dispatch=>{
        return axios.get('http://127.0.0.1:3000/chapters?id='+chapter_id+'&&comic_id='+comic_id).then(
            data=>{
                const gen=data.data
                localStorage.setItem('chap',JSON.stringify(gen[0]))
                dispatch(returnChapter(gen))
            }
        )
    }
}
export const addChapter = (comic_id,chapter_name,content) =>
{
    return dispatch=>{
       
        return axios.post('http://127.0.0.1:3000/chapters',{comic_id,chapter_name,content}).then(   

                dispatch(addchapter())
                
        )
    }
}
export const updateChapter = (chap_id,comic_id,chapter_name,content) =>
{
    return dispatch=>{
        return axios.get('http://127.0.0.1:3000/chapters?id='+chap_id+'&&comic_id='+comic_id).then(
            data=>{
                const gen=data.data
                const id=gen[0].id
                return axios.patch('http://127.0.0.1:3000/chapters/'+id,{"chapter_name":chapter_name,"content":content}).then(     
                    dispatch(updatechapter())
            )
            }
        )
       
    }
}
export const deleteChapter = (chap_id,comic_id) =>
{
    return dispatch=>{
        return axios.get('http://127.0.0.1:3000/chapters?id='+chap_id+'&&comic_id='+comic_id).then(
            data=>{
                const gen=data.data[0]
                return axios.delete('http://127.0.0.1:3000/chapters/'+gen.id).then(
                    (data=>{
                        dispatch(delchapter())
                        return axios.get('http://127.0.0.1:3000/chapters?comic_id='+comic_id).then(
                             data =>{
                                const list=data.data
                                dispatch(returnListChapter(list));
                            }
                        )
                    })
                )

                
            }
        )
       
        
    }
}
const returnChapter = (Chapter) => (
    {
    type : 'GET_A_CHAPTER',
    chap: Chapter
})
const returnListChapter =(Chapters) =>(
    {
        type:'SHOW_LIST_CHAPTERS',
        chaps:Chapters
    }
)
const addchapter = () => (
    {
    type : 'ADD_A_CHAPTER',
    
})
const updatechapter = () => (
    {
    type : 'UPDATE_CHAPTER',
    
})
const delchapter = () => (
    {
    type : 'DELETE_CHAPTER',
    
})
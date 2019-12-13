import axios from 'axios';
export const addPostF = (userid, title, content, time) => {
    return dispatch => {
        return axios.post('http://127.0.0.1:3000/posts', { userid, title, content, time }).then(
            data => {
                dispatch(addNewPost())
            }
        )
    }
}
const addNewPost = () => ({
    type: "ADD-POST"
})
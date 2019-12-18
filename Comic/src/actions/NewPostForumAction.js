import axios from 'axios';
export const addPostF = (userid, title, content, time) => {
    return dispatch => {
        return axios.post('http://127.0.0.1:3000/posts', { "userID": userid, "title": title, "postContent": content, "postTime": time }).then(
            data => {
                dispatch(addNewPost())
                return axios.get('http://127.0.0.1:3000/posts').then(
                    data => {
                        const listpost = data.data
                        dispatch(returnListPost(listpost))
                    }
                )
            }
        )
    }
}
const addNewPost = () => ({
    type: "ADD-POST"
})
const returnListPost = (lpost) => ({
    type: 'GET-LIST-POST',
    posts: lpost
})
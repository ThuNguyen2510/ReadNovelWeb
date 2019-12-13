import axios from 'axios';
export const fetchPosts = () => {
    return dispatch => {
        return axios.get('http://127.0.0.1:3000/posts').then(
            data => {
                const listpost = data.data
                dispatch(returnListPost(listpost))
            }
        )
    }
}
export const fetchAPost = (Id) => {
    return dispatch => {
        return axios.get('http://127.0.0.1:3000/posts/' + Id).then(
            data => {
                const p = data.data
                dispatch(returnAPost(p))
                dispatch(returnAPostLikes(p.likePosts))
                dispatch(returnAPostUser(p.user))
                dispatch(returnAPostAnswers(p.answers))
                dispatch(userInfo1(p.user))

            }
        )
    }
}
export const addAnswer = (userid, postid, content, time) => {
    return dispatch => {
        return axios.post('http://127.0.0.1:3000/answers', { userid, postid, content, time }).then(
            data => {
                dispatch(addNewAnswer())
                return axios.get('http://127.0.0.1:3000/posts/' + postid).then(
                    d => {
                        const p = d.data
                        dispatch(returnAPost(p))
                        dispatch(returnAPostLikes(p.likePosts))
                        dispatch(returnAPostUser(p.user))
                        dispatch(returnAPostAnswers(p.answers))
                        dispatch(userInfo1(p.user))
                    }
                )
            }

        )
    }
}
const returnListPost = (lpost) => ({
    type: 'GET-LIST-POST',
    posts: lpost
})
const returnAPost = (p) => ({
    type: 'SHOW_A_POST',
    post: p
})
const returnAPostLikes = (likes) => ({
    type: 'GET_LIKE_POST',
    likes
})
const returnAPostUser = (user) => ({
    type: 'GET_LIKE_USER',
    user
})
const returnAPostAnswers = (answers) => ({
    type: 'GET_ANSWERS',
    answers
})
const userInfo1 = (user) => ({
    type: "GET-USER-NAME1",
    user_: user
})
const addNewAnswer = () => ({
    type: "ADD-NEW-ANSWER"
})
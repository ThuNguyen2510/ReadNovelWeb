import axios from 'axios';
export const addLike = (user_id, comic_id) => {
    return dispatch => {
        return axios.post('http://127.0.0.1:3000/likes', { "userID": user_id, "comicID": comic_id }).then(
            data => {
                dispatch(addnewLike())
                return axios.get('http://127.0.0.1:3000/users/' + user_id, {
                    headers: {
                        "Authorization": 'Bearer ' + localStorage.getItem("token"),
                        'Content-Type': 'application/json',
                    }
                }).then(
                    d => {

                        dispatch(gLike(d.data.likes))
                        return axios.get('http://127.0.0.1:3000/comics/' + comic_id).then(
                            data => {
                                const c = data.data
                                dispatch(returnOneComic(c))
                            }
                        )
                    }
                )
            }


        )
    }

}
export const getLike = (id) => {
    console.log(id)
    return dispatch => {
        return axios.get('http://127.0.0.1:3000/users/' + id, {
            headers: {
                "Authorization": 'Bearer ' + localStorage.getItem("token"),
                'Content-Type': 'application/json',
            }
        }).then(
            d => {
                dispatch(gLike(d.data.likes))
            }
        )
    }
}
export const unLike = (comic_id, user_id, id) => {
    return dispatch => {

        return axios.delete('http://127.0.0.1:3000/likes/' + id).then(
            (data_) => {
                dispatch(deleteLike())
                return axios.get('http://127.0.0.1:3000/users/' + user_id, {
                    headers: {
                        "Authorization": 'Bearer ' + localStorage.getItem("token"),
                        'Content-Type': 'application/json',
                    }
                }).then(
                    d => {

                        dispatch(gLike(d.data))
                        return axios.get('http://127.0.0.1:3000/comics/' + comic_id).then(
                            data => {
                                const c = data.data
                                dispatch(returnOneComic(c))
                            }
                        )
                    }
                )
            }

        )
    }

}
const addnewLike = () => ({
    type: 'ADD-LIKE'
})
const gLike = (list) => ({
    type: 'GET-LIKE',
    check: list
})
const deleteLike = () => ({
    type: 'UNLIKE'
})
export const returnOneComic = (comic) => ({
    type: 'SHOW_A_COMIC',
    comic: comic
})
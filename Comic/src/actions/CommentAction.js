import axios from 'axios';
export const fetchComt = (comic_id) => {
    return dispatch => {
        return axios.get('http://127.0.0.1:3000/comments?comic_id=' + comic_id).then(
            data => {
                const list = data.data;
                dispatch(returnListComt(list));
            }
        )
    }
}

export const addComt = (user_id, comic_id, content, time) => {
    return dispatch => {

        return axios.post('http://127.0.0.1:3000/comments', { user_id, comic_id, content, time }).then(
            (data) => {
                dispatch(addNewComt())
                return axios.get('http://127.0.0.1:3000/comments?comic_id=' + comic_id).then(
                    data => {
                        const list = data.data;
                        dispatch(returnListComt(list));
                    }
                )

            }


        )

    }
}
const returnListComt = (comt) =>
    ({
        type: 'SHOW-COMT',
        cmt: comt,
    })
const addNewComt = () =>
    ({
        type: 'ADD-COMT',
        //addComt: check,
    })
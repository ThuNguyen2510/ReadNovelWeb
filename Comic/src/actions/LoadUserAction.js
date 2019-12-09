import axios from 'axios';
export const getUserName = () => {
    return dispatch => {
        return axios.get('http://127.0.0.1:3000/users',
        { headers: {
            "Authorization":'Bearer '+ localStorage.getItem("token"),
            'Content-Type': 'application/json',
          }}).then(
            data => {
                const us = data.data
                dispatch(userInfo(us))
            }
        )
    }
}
const userInfo = (user) => ({
    type: "GET-USER-NAME",
    user_: user
})
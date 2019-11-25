import axios from 'axios';
import Comic_detail from '../components/Comic_detail';
export const fetchListComic = () => {
    return dispatch => {
        return axios.get('http://127.0.0.1:3000/comics').then(data => {
            dispatch(returnList(data.data))
        })
    }
}
export const fetchComicByCategory = (genre_id) => {
    return dispatch => {
        if (genre_id == 0) {
            return axios.get('http://127.0.0.1:3000/comics').then(data => {
                dispatch(returnList(data.data))
            })
        } else
            return axios.get('http://127.0.0.1:3000/comics?Genre_id=' + genre_id).then(data => {
                dispatch(returnComicByCategory(data.data))
            })
    }
}
export const getLikedComics = (userid) => {
    return dispatch => {
        return axios.get('http://127.0.0.1:3000/likes?user_id=' + userid).then(data => {
            dispatch(returnLikedComicId(data.data))
        })
    }
}
export const fetchOneComic = (Id) => {
    return dispatch => {
        return axios.get('http://127.0.0.1:3000/comics?id=' + Id).then(
            data => {
                const c = data.data[0]

                axios.get('http://127.0.0.1:3000/genres?id=' + c.Genre_id).then(
                    g => {
                        const g_name = g.data[0].genre_name

                        dispatch(returnOneComic(c, g_name))
                    }
                )
            }
        )
    }
}
export const fetchComicHot = () => {
    return dispatch => {
        return axios.get('http://127.0.0.1:3000/comics?_sort=Number_of_Like&_order=desc?_start=0&_end=12').then(data => {
            dispatch(returnComicHot(data.data))
        })
    }
}
export const fetchComicUpdateNew = () => {
    return dispatch => {
        return axios.get('http://127.0.0.1:3000/comics?_sort=Post_DateTime&_order=desc?_start=0&_end=5').then(data => {
            dispatch(returnComicUpdateNew(data.data))
        })
    }
}
export const fetchComicUpdateNew2 = () => {
    return dispatch => {
        return axios.get('http://127.0.0.1:3000/comics?_sort=Post_DateTime&_order=desc?_start=0&_end=8').then(data => {
            dispatch(returnComicUpdateNew2(data.data))
        })
    }
}

export const likeComic = (comic_id, Number_of_Like) => {
    return dispatch => {
        return axios.patch('http://127.0.0.1:3000/comics?id=' + comic_id, Number_of_Like).then(
            (data) => {

                dispatch(likeComic(data.data))
            })
    }
}
export const addComic = (name, genre_id, author, chap_number, des, date, img) => {
    return dispatch => {


        return axios.post('http://127.0.0.1:3000/comics/', {
            'Name': name,
            'Author': author,
            'Genre_id': genre_id,
            'Description': des,
            'Chapter_number_of': chap_number,
            'Status': 0,
            'Number_of_Like': '0',
            'Number_of_Read': '0',
            'Post_DateTime': date,
            'Image': img
        }).then(

            dispatch(addcomic())
        )
    }
}
export const deleteComic = (id) => {
    return dispatch => {
        return axios.delete('http://127.0.0.1:3000/comics/' + id).then(
            (data) => {
                dispatch(delComic())
                return axios.get('http://127.0.0.1:3000/comics').then(data => {
                    dispatch(returnList(data.data))
                })
            }
        )
    }

}
export const updateComic = (id, Name, Author, genre_id, des, Image, date, chaps, Status) => {
    console.log("ACtion")
    console.log(Status)
    return dispatch => {
        return axios.patch('http://127.0.0.1:3000/comics/' + id, {
            'Name': Name,
            'Author': Author,
            'Genre_id': genre_id,
            'Image': Image,
            'Description': des,
            'Post_DateTime': date,
            'Chappter_number_of': chaps,
            'Status': Status
        }).then(
            (data) => {
                dispatch(updatecomic())

            }
        )
    }

}
const returnList = (comics) => ({
    type: 'SHOW_LIST',
    list: comics
});
const returnOneComic = (comic, gen) => ({
    type: 'SHOW_A_COMIC',
    comic: comic,
    gen: gen
})
const returnLikedComicId = (comicid) => ({
    type: 'GET_LIKED_COMIC_ID',
    comicid
})
const like = (comic) => ({
    type: 'LIKE',
    comic: comic
})
const returnComicHot = (comics) => ({
    type: 'COMIC_HOT',
    comics: comics
})
const returnComicUpdateNew = (comics) => ({
    type: 'COMIC_UPDATE_NEW',
    comics: comics
})
const returnComicUpdateNew2 = (comics) => ({
    type: 'COMIC_UPDATE_NEW_2',
    comics: comics
})
const returnComicByCategory = (comics) => ({
    type: 'LIST_COMIC_BY_CATEGORY',
    comics
})
const addcomic = () => ({
    type: 'ADD_COMIC',

})
const delComic = () => ({
    type: 'DELETE_COMIC',

})
const updatecomic = () => ({
    type: 'UPDATE_COMIC',

})
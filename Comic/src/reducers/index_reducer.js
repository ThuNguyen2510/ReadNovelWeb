import { combineReducers } from 'redux';
import comics from './comic_reducer';
import login from './login_reducer';
import logout from './login_reducer';
import genre from './genre_reducer';
import chapters from './chapter_reducer';
import signup from './signup_reducer';
import comic from './a_comic_reducer';
import chapter from './a_chapter_reducer';
import comichot from './comic_hot_reducer';
import comicnew from './comic_update_new_reducer';
import search from './Search_reducer';
import users from './user_reducer';
import like from './like_reducer';
import comt from './comt_reducer';
import user from './LoadUserReducer';
import likedcomic from './likedcomic_reducer'
const appReducers = combineReducers({
    comics,
    comic,
    comichot,
    comicnew,
    chapters,
    chapter,
    login,
    signup,
    genre,
    search,
    users,
    like,
    comt,
    user,
    likedcomic
});
export default appReducers;
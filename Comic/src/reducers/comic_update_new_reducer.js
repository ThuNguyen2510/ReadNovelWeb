var initialState =  [];
export default function comicnew(state = initialState, action) {
  switch (action.type) {
    case 'COMIC_UPDATE_NEW':
      return [...action.comics]
    case 'COMIC_UPDATE_NEW_2':
      return [...action.comics]  
    default:
      return [...state];
  }
}

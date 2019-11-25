var initialState =  [];
export default function search(state = initialState, action) {
  switch (action.type) {
    case 'SEARCH_BY_NAME':
      return [...action.comics]    
    default:
      return [...state];
  }
}

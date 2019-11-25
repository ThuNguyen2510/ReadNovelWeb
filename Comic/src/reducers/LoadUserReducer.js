var initialState = [];
export default function user(state = initialState, action) {
    switch (action.type) {
        case 'GET-USER-NAME':
            return [...action.user_]
        default:
            return [...state]
    }
}
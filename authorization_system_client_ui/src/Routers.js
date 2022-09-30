import Home from './components/Home.vue';
import Login from './components/Login.vue';
import SignUp from './components/SignUp.vue';
import UserDetail from './components/UserDetail.vue';

import {
    createRouter,
    createWebHistory
} from 'vue-router';

const routes = [{
        name: "Login",
        component: Login,
        path: '/',
    },
    {
        name: "SignUp",
        component: SignUp,
        path: '/signUp',
    }, {
        name: 'Home',
        component: Home,
        path: '/home',
    },
     {
        name: 'UserDetail',
        component: UserDetail,
        path: '/userDetail',
    },
];

const router = createRouter({
    history: createWebHistory(),
    routes,
});
export default router;
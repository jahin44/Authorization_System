import Home from './components/Home.vue';
import Login from './components/Login.vue';
import { createRouter,createWebHistory} from 'vue-router';

const routes = [
    {
    name: "Login",
    component: Login,
    path: '/',
}, {
    name: 'Home',
    component: Home,
    path: '/home',
},
];

const router = createRouter({
    history: createWebHistory(),
    routes,
});
export default router;
import { createApp } from 'vue'
import App from './App.vue'
import './assets/tailwind.css'
import router from './Routers.js';

createApp(App).use(router).mount('#app')

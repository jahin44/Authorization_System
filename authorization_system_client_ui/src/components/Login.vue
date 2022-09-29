<template>
  <div class="grid place-content-center">
    <div class="w-full max-w-xs">
      <form class="bg-gray-200 shadow-md rounded px-12 pt-8 pb-10 mb-2">
        <div class="mb-4">
          <label
            class="block text-gray-700 text-sm font-bold mb-2"
            for="username"
          >
            User Name
          </label>
          <input
            class="shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline"
            id="username"
            type="text"
            v-model="UserName"
            placeholder="Username"
          />
        </div>
        <div class="mb-6">
          <label
            class="block text-gray-700 text-sm font-bold mb-2"
            for="password"
          >
            Password
          </label>
          <input
            class="shadow appearance-none border border-red-500 rounded w-full py-2 px-3 text-gray-700 mb-3 leading-tight focus:outline-none focus:shadow-outline"
            id="password"
            type="password"
            v-model="Password"
            placeholder=" Password"
          />
          <p class="text-red-500 text-xs italic">Please choose a password.</p>
        </div>
        <div class="flex items-center justify-between">
          <button
            class="bg-blue-500 hover:bg-blue-700 text-white font-bold py-2 px-4 rounded focus:outline-none focus:shadow-outline"
            v-on:click="loginAsync"
            type="button"
          >
            LogIn
          </button>
          <a
            class="inline-block align-baseline font-bold text-sm text-blue-500 hover:text-blue-800"
            href="#"
          >
            Forgot Password?
          </a>
          <a
            class="inline-block align-baseline font-bold text-sm text-blue-500 hover:text-blue-800"
            href="#"
          >
            Register
          </a>
        </div>
      </form>
      <p class="text-center text-gray-500 text-xs">
        &copy;2020 Acme Corp. All rights reserved.
      </p>
    </div>
  </div>
</template>
<script>
import "@/assets/tailwind.css";
import axios from "axios";

export default {
  name: "LogIn",
  data() {
    return {
      UserName: "",
      Password: "",
    };
  },
  methods: {
    async loginAsync() {
      let result = await axios.post(
        "https://localhost:7190/api/Authenticate/login",
        {
          userName: this.UserName,
          password: this.Password,
        }
      );
      if (result.status == 200) {
        localStorage.setItem("Token", JSON.stringify(result.data.token));
        localStorage.setItem("UserName", JSON.stringify(this.UserName));
        this.$router.push({name:'Home'})
      }
    },
  },
  mounted(){
    let token = localStorage.getItem("Token");
    if( token != null){
      this.$router.push({name:'Home'});
    }
  }
};
</script>
<Style>
element.style {
     PADDING: 10%;
}
</Style>

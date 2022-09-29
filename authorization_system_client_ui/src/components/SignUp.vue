<template>
  <div class="grid place-content-center ">
  <form class="w-full max-w-md ">
    <div class="md:flex md:items-center mb-6">
      <div class="md:w-1/3">
        <label
          class="block text-gray-500 font-bold md:text-right mb-1 md:mb-0 pr-4"
          for="inline-full-name"
        >
          User Name
        </label>
      </div>
      <div class="md:w-2/3">
        <input
          class="bg-gray-200 appearance-none border-2 border-gray-200 rounded w-full py-2 px-4 text-gray-700 leading-tight focus:outline-none focus:bg-white focus:border-purple-500"
          id="inline-full-name"
          type="text"
          v-model="UserName"
        />
      </div>
    </div>
    <div class="md:flex md:items-center mb-6">
      <div class="md:w-1/3">
        <label
          class="block text-gray-500 font-bold md:text-right mb-1 md:mb-0 pr-4"
          for="inline-full-name"
        >
         Email
        </label>
      </div>
      <div class="md:w-2/3">
        <input
          class="bg-gray-200 appearance-none border-2 border-gray-200 rounded w-full py-2 px-4 text-gray-700 leading-tight focus:outline-none focus:bg-white focus:border-purple-500"
          id="inline-full-name"
          type="email"
          v-model="Email"
        />
      </div>
    </div>
    <div class="md:flex md:items-center mb-6">
      <div class="md:w-1/3">
        <label
          class="block text-gray-500 font-bold md:text-right mb-1 md:mb-0 pr-4"
          for="inline-password"
        >
          Password
        </label>
      </div>
      <div class="md:w-2/3">
        <input
          class="bg-gray-200 appearance-none border-2 border-gray-200 rounded w-full py-2 px-4 text-gray-700 leading-tight focus:outline-none focus:bg-white focus:border-purple-500"
          id="inline-password"
          type="password"
          v-model="Password"
        />
      </div>
    </div>
    <div class="md:flex md:items-center">
      <div class="md:w-1/3"></div>
      <div class="md:w-2/3">
        <button
          v-on:click="SignIn"
          type="button"
        >
          Sign In
        </button>
      </div>
      <div class="md:w-2/3">
        <button
          class="shadow bg-purple-500 hover:bg-purple-400 focus:shadow-outline focus:outline-none text-white font-bold py-2 px-4 rounded"
          v-on:click="registerAsync"
          type="button"
        >
          Sign Up
        </button>
      </div>
    </div>
  </form>
</div>
</template>
<script>
import "@/assets/tailwind.css";
import axios from "axios";

export default {
  name: "SignUp",
  data() {
    return {
      UserName: "",
      Email: "",
      Password: "",
    };
  },
  methods: {
    SignIn(){
      this.$router.push({ name: "Login" });
    },
    async registerAsync() {
        await axios.post(
        "https://localhost:7190/api/Authenticate/register",
        {
          userName: this.UserName,
          email: this.Email,
          password: this.Password,
        }).then((response) => {
          if (response.status == 200) {
            this.$router.push({ name: "Login" });
          } else {
            this.UserName = "";
            this.Email = "";
            this.password = "";
          }
        })
        .catch((error) => {
          console.error(error);
        })     
    },
  },
  mounted() {
    let token = localStorage.getItem("Token");
    if (token != null) {
      this.$router.push({ name: "Home" });
    }
  },
};
</script>
<Style>
    element.style {
         PADDING: 10%;
    }
    </Style>

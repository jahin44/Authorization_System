<template>
    <div class="grid grid-cols-8 ">
        <div class="col-start-1 ">
            <button
    class="bg-purple-400 hover:bg-purple-700 text-white font-bold py-2 px-4 rounded-full"
    v-on:click="Home"
  >
    Home
  </button>
</div>
<div class="col-start-8 ">
  
  <button
    class="bg-blue-400 hover:bg-red-700 text-white font-bold py-2 px-4 rounded-full"
    v-on:click="logOut"
  >
    LogOut
  </button>
</div>
</div>
  <div class="grid grid-cols-5 gap 3 ">
    <div class="col-span-2 ">
      <form class=" -mx-4 sm:-mx-8 px-4 sm:px-8 py-4 ">
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
              v-model="user.UserName"
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
              v-model="user.Email"
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
              v-model="user.Password"
            />
          </div>
        </div>
        <div class="md:flex md:items-center mb-6">
          <div class="md:w-1/3">
            <label
              class="block text-gray-500 font-bold md:text-right mb-1 md:mb-0 pr-4"
              for="inline-password"
            >
              Phone Number
            </label>
          </div>
          <div class="md:w-2/3">
            <input
              class="bg-gray-200 appearance-none border-2 border-gray-200 rounded w-full py-2 px-4 text-gray-700 leading-tight focus:outline-none focus:bg-white focus:border-purple-500"
              id="inline-number"
              type="number"
              v-model="user.PhoneNumber"
            />
          </div>
        </div>
        <div class="md:flex md:items-center">
          <div class="md:w-1/3"></div>
          <div class="md:w-1/3">
            <button
              class="shadow bg-red-400 hover:bg-red-700 focus:shadow-outline focus:outline-none text-white font-bold py-2 px-4 rounded"
              v-on:click="registerAsync"
              type="button"
            >
              Delete
            </button>
          </div>
          <div class="md:w-3/3">
            <button
              class="shadow bg-purple-500 hover:bg-green-400 focus:shadow-outline focus:outline-none text-white font-bold py-2 px-4 rounded"
              v-on:click="Edit"
              type="button"
            >
              Edit
            </button>
          </div>
        </div>
      </form>
    </div>
    <div class="col-span-3">
      <div class="-mx-4 sm:-mx-8 px-4 sm:px-8 py-4  ">
        <div
          class="inline-block min-w-full shadow-md rounded-lg overflow-hidden"
        >
          <table :value="userList" class="min-w-full leading-normal">
            <thead>
              <tr>
                <th
                  class="px-20 py-3 border-b-2 border-gray-300 bg-gray-100 text-left text-xs font-semibold text-gray-700 uppercase tracking-wider"
                >
                  CategoryName
                </th>
                <th
                  class="px-20 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-700 uppercase tracking-wider"
                >
                  UnitName
                </th>
              </tr>
            </thead>
            <tbody>
              <tr v-for="(user, i) in userList" :key="i">
                <td class="px-3 py-5 border-b border-gray-200 bg-white text-sm">
                  <p class="text-gray-900 whitespace-no-wrap">
                    {{ user.CategoryName }}
                  </p>
                </td>
                <td class="px-3 py-5 border-b border-gray-200 bg-white text-sm">
                  <p class="text-gray-900 whitespace-no-wrap">
                    {{ user.UnitName }}
                  </p>
                </td>
              </tr>
            </tbody>
          </table>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import "@/assets/tailwind.css";
import axios from "axios";

export default {
  name: "UserDetail",
  data() {
    return {
      userList: [],
      user: {},
      token:"",
    };
  },
  methods: {
    UserDetail() {
      this.$router.push({ name: "UserDetail" });
    },
    Home(){
        this.$router.push({ name: "Home" });
    },
    logOut() {
      console.log();
      localStorage.removeItem("Token");
      localStorage.removeItem("UserName");
      this.$router.push({ name: "Login" });
    },
    
    async GetUsersAsync() {
        const access =this.token;
        console.log(access);
        const config = {
    headers: { "Authorization": `Bearer ${access}` }
             };
      await axios
        .get("https://localhost:7190/api/UserOperation/GetAllUsers",config)
        .then((response) => {
          if (response.data.length > 0) {
            this.userList = response.data;
          } else {
            this.userList = [];
          }
        })
        .catch((error) => {
          console.error(error);
        });
    },
  },
  mounted() {
    this.token = localStorage.getItem("Token");
    this.UserName = localStorage.getItem("UserName");
    if (this.token == null) {
      this.$router.push({ name: "Login" });
     } 
    this.GetUsersAsync();
  },
};
</script>

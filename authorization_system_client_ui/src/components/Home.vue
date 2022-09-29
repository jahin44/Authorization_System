<template>
  <div class="container mx-auto px-4 sm:px-8">
    <div class="py-8">
      <div class="grid grid-cols-6 gap-2">
        <div class="col-start-1 col-end-3">
          <h2 class="text-2xl font-semibold leading-tight ">Product Details</h2>
        </div>
        <div class="col-end-7 col-span-2 inline-grid grid-cols-2 gap-2">
          <button
            class=" bg-blue-500 hover:bg-blue-700 text-white font-bold py-2 px-4 rounded-full "
          >
            {{this.UserName}} 
          </button>
          <button
            class=" bg-blue-400 hover:bg-red-700 text-white font-bold py-2 px-4 rounded-full"
            v-on:click="logOut"
          >
            LogOut
          </button>
        </div>
      </div>
      <div class="-mx-4 sm:-mx-8 px-4 sm:px-8 py-4 overflow-x-auto">
        <div
          class="inline-block min-w-full shadow-md rounded-lg overflow-hidden"
        >
          <table :value="productList" class="min-w-full leading-normal">
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
                <th
                  class="px-20 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-700 uppercase tracking-wider"
                >
                  Name
                </th>
                <th
                  class="px-20 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-700 uppercase tracking-wider"
                >
                  Code
                </th>
                <th
                  class="px-20 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-700 uppercase tracking-wider"
                >
                  Type
                </th>
                <th
                  class="px-5 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-700 uppercase tracking-wider"
                >
                  Status
                </th>
                <th
                  class="px-20 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-700 uppercase tracking-wider"
                >
                  ProductBarcode
                </th>
                <th
                  class="px-20 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-700 uppercase tracking-wider"
                >
                  Description
                </th>
                <th
                  class="px-20 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-700 uppercase tracking-wider"
                >
                  BrandName
                </th>
                <th
                  class="px-20 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-700 uppercase tracking-wider"
                >
                  SizeName
                </th>
                <th
                  class="px-20 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-700 uppercase tracking-wider"
                >
                  ColorName
                </th>
                <th
                  class="px-20 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-700 uppercase tracking-wider"
                >
                  ModelName
                </th>
                <th
                  class="px-20 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-700 uppercase tracking-wider"
                >
                  VariantName
                </th>
                <th
                  class="px-20 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-700 uppercase tracking-wider"
                >
                  OldPrice
                </th>
                <th
                  class="px-20 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-700 uppercase tracking-wider"
                >
                  Price
                </th>
                <th
                  class="px-20 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-700 uppercase tracking-wider"
                >
                  CostPrice
                </th>
                <th
                  class="px-20 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-700 uppercase tracking-wider"
                >
                  stock
                </th>
                <th
                  class="px-20 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-700 uppercase tracking-wider"
                >
                  TotalPurchase
                </th>
                <th
                  class="px-20 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-700 uppercase tracking-wider"
                >
                  LastPurchaseDate
                </th>
                <th
                  class="px-20 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-700 uppercase tracking-wider"
                >
                  LastPurchaseSupplier
                </th>
                <th
                  class="px-20 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-700 uppercase tracking-wider"
                >
                  TotalSales
                </th>
                <th
                  class="px-20 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-700 uppercase tracking-wider"
                >
                  LastSalesDate
                </th>
                <th
                  class="px-20 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-700 uppercase tracking-wider"
                >
                  LastSalesCustomer
                </th>
                <th
                  class="px-20 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-700 uppercase tracking-wider"
                >
                  ImagePath
                </th>
              </tr>
            </thead>
            <tbody>
              <tr v-for="(product, i) in productList" :key="i">
                <td class="px-3 py-5 border-b border-gray-200 bg-white text-sm">
                  <p class="text-gray-900 whitespace-no-wrap">
                    {{ product.CategoryName }}
                  </p>
                </td>
                <td class="px-3 py-5 border-b border-gray-200 bg-white text-sm">
                  <p class="text-gray-900 whitespace-no-wrap">
                    {{ product.UnitName }}
                  </p>
                </td>
                <td class="px-3 py-5 border-b border-gray-200 bg-white text-sm">
                  <p class="text-gray-900 whitespace-no-wrap">
                    {{ product.Name }}
                  </p>
                </td>
                <td class="px-3 py-5 border-b border-gray-200 bg-white text-sm">
                  <p class="text-gray-900 whitespace-no-wrap">
                    {{ product.Code }}
                  </p>
                </td>
                <td class="px-3 py-5 border-b border-gray-200 bg-white text-sm">
                  <p class="text-gray-900 whitespace-no-wrap">
                    {{ product.Type }}
                  </p>
                </td>
                <td class="px-3 py-5 border-b border-gray-200 bg-white text-sm">
                  <p class="text-gray-900 whitespace-no-wrap">
                    {{ product.Status }}
                  </p>
                </td>
                <td class="px-3 py-5 border-b border-gray-200 bg-white text-sm">
                  <p class="text-gray-900 whitespace-no-wrap">
                    {{ product.ProductBarcode }}
                  </p>
                </td>
                <td class="px-3 py-5 border-b border-gray-200 bg-white text-sm">
                  <p class="text-gray-900 whitespace-no-wrap">
                    {{ product.Description }}
                  </p>
                </td>
                <td class="px-3 py-5 border-b border-gray-200 bg-white text-sm">
                  <p class="text-gray-900 whitespace-no-wrap">
                    {{ product.BrandName }}
                  </p>
                </td>
                <td class="px-3 py-5 border-b border-gray-200 bg-white text-sm">
                  <p class="text-gray-900 whitespace-no-wrap">
                    {{ product.SizeName }}
                  </p>
                </td>
                <td class="px-3 py-5 border-b border-gray-200 bg-white text-sm">
                  <p class="text-gray-900 whitespace-no-wrap">
                    {{ product.ColorName }}
                  </p>
                </td>
                <td class="px-3 py-5 border-b border-gray-200 bg-white text-sm">
                  <p class="text-gray-900 whitespace-no-wrap">
                    {{ product.ModelName }}
                  </p>
                </td>
                <td class="px-3 py-5 border-b border-gray-200 bg-white text-sm">
                  <p class="text-gray-900 whitespace-no-wrap">
                    {{ product.VariantName }}
                  </p>
                </td>
                <td class="px-3 py-5 border-b border-gray-200 bg-white text-sm">
                  <p class="text-gray-900 whitespace-no-wrap">
                    {{ product.OldPrice }}
                  </p>
                </td>
                <td class="px-3 py-5 border-b border-gray-200 bg-white text-sm">
                  <p class="text-gray-900 whitespace-no-wrap">
                    {{ product.Price }}
                  </p>
                </td>
                <td class="px-3 py-5 border-b border-gray-200 bg-white text-sm">
                  <p class="text-gray-900 whitespace-no-wrap">
                    {{ product.CostPrice }}
                  </p>
                </td>
                <td class="px-3 py-5 border-b border-gray-200 bg-white text-sm">
                  <p class="text-gray-900 whitespace-no-wrap">
                    {{ product.stock }}
                  </p>
                </td>
                <td class="px-3 py-5 border-b border-gray-200 bg-white text-sm">
                  <p class="text-gray-900 whitespace-no-wrap">
                    {{ product.TotalPurchase }}
                  </p>
                </td>
                <td class="px-3 py-5 border-b border-gray-200 bg-white text-sm">
                  <p class="text-gray-900 whitespace-no-wrap">
                    {{ product.LastPurchaseDate }}
                  </p>
                </td>
                <td class="px-3 py-5 border-b border-gray-200 bg-white text-sm">
                  <p class="text-gray-900 whitespace-no-wrap">
                    {{ product.LastPurchaseSupplier }}
                  </p>
                </td>
                <td class="px-3 py-5 border-b border-gray-200 bg-white text-sm">
                  <p class="text-gray-900 whitespace-no-wrap">
                    {{ product.TotalSales }}
                  </p>
                </td>
                <td class="px-3 py-5 border-b border-gray-200 bg-white text-sm">
                  <p class="text-gray-900 whitespace-no-wrap">
                    {{ product.LastSalesDate }}
                  </p>
                </td>
                <td class="px-3 py-5 border-b border-gray-200 bg-white text-sm">
                  <p class="text-gray-900 whitespace-no-wrap">
                    {{ product.LastSalesCustomer }}
                  </p>
                </td>
                <td class="px-3 py-5 border-b border-gray-200 bg-white text-sm">
                  <p class="text-gray-900 whitespace-no-wrap">
                    {{ product.ImagePath }}
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
  name: "WelCome",
  data() {
    return {
      productList: [],
      UserName: "",
    };
  },
  methods: {
    logOut(){
      console.log()
        localStorage.removeItem("Token");
         localStorage.removeItem("UserName");
        this.$router.push({name:'Login'})

    },
    async GetProductsAsync() {
      await axios
        .get("https://www.pqstec.com/InvoiceApps/values/GetProductListAll")
        .then((response) => {
          if (response.data.length > 0) {
            this.productList = response.data;
          } else {
            this.productList = [];
          }
        })
        .catch((error) => {
          console.error(error);
        });
    },
  },
  mounted() {
    let token = localStorage.getItem("Token");
    this.UserName = localStorage.getItem("UserName");
    this.UserName = this.UserName.replace(/['"]+/g, '').toUpperCase();
    if (token != null) {
      this.$router.push({ name: "Home" });
      this.GetProductsAsync();
    } else {
      this.$router.push({ name: "Login" });
    }
  },
};
</script>

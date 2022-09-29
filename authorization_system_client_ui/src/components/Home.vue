<template>
  <div class="container mx-auto px-4 sm:px-8">
    <div class="py-8">
      <div>
        <h2 class="text-2xl font-semibold leading-tight">Product Details</h2>
      </div>
      <div class="-mx-4 sm:-mx-8 px-4 sm:px-8 py-4 overflow-x-auto">
        <div
          class="inline-block min-w-full shadow-md rounded-lg overflow-hidden"
        >
          <table class="min-w-full leading-normal">
            <thead>
              <tr>
                <th
                  class="px-5 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-700 uppercase tracking-wider"
                >
                  CategoryName
                </th>
                <th
                  class="px-5 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-700 uppercase tracking-wider"
                >
                  UnitName
                </th>
                <th
                  class="px-5 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-700 uppercase tracking-wider"
                >
                  Name
                </th>
                <th
                  class="px-5 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-700 uppercase tracking-wider"
                >
                  Code
                </th>
                <th
                  class="px-5 py-3 border-b-2 border-gray-200 bg-gray-100"
                ></th>
                <th
                  class="px-5 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-700 uppercase tracking-wider"
                >
                  ProductBarcode
                </th>
                <th
                  class="px-5 py-3 border-b-2 border-gray-200 bg-gray-100"
                ></th>
                <th
                  class="px-5 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-700 uppercase tracking-wider"
                >
                  BrandName
                </th>
                <th
                  class="px-5 py-3 border-b-2 border-gray-200 bg-gray-100"
                ></th>
                <th
                  class="px-5 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-700 uppercase tracking-wider"
                >
                  SizeName
                </th>
                <th
                  class="px-5 py-3 border-b-2 border-gray-200 bg-gray-100"
                ></th>
                <th
                  class="px-5 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-700 uppercase tracking-wider"
                >
                  ColorName
                </th>
                <th
                  class="px-5 py-3 border-b-2 border-gray-200 bg-gray-100"
                ></th>
                <th
                  class="px-5 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-700 uppercase tracking-wider"
                >
                  ModelName
                </th>
                <th
                  class="px-5 py-3 border-b-2 border-gray-200 bg-gray-100"
                ></th>
                <th
                  class="px-5 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-700 uppercase tracking-wider"
                >
                  VariantName
                </th>
                <th
                  class="px-5 py-3 border-b-2 border-gray-200 bg-gray-100"
                ></th>
                <th
                  class="px-5 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-700 uppercase tracking-wider"
                >
                  OldPrice
                </th>
                <th
                  class="px-5 py-3 border-b-2 border-gray-200 bg-gray-100"
                ></th>
                <th
                  class="px-5 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-700 uppercase tracking-wider"
                >
                  Price
                </th>
                <th
                  class="px-5 py-3 border-b-2 border-gray-200 bg-gray-100"
                ></th>
                <th
                  class="px-5 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-700 uppercase tracking-wider"
                >
                  CostPrice
                </th>
                <th
                  class="px-5 py-3 border-b-2 border-gray-200 bg-gray-100"
                ></th>
                <th
                  class="px-5 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-700 uppercase tracking-wider"
                >
                  stock
                </th>
                <th
                  class="px-5 py-3 border-b-2 border-gray-200 bg-gray-100"
                ></th>
                <th
                  class="px-5 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-700 uppercase tracking-wider"
                >
                  TotalPurchase
                </th>
                <th
                  class="px-5 py-3 border-b-2 border-gray-200 bg-gray-100"
                ></th>
                <th
                  class="px-5 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-700 uppercase tracking-wider"
                >
                  LastPurchaseDate
                </th>
                <th
                  class="px-5 py-3 border-b-2 border-gray-200 bg-gray-100"
                ></th>
                <th
                  class="px-5 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-700 uppercase tracking-wider"
                >
                  LastPurchaseSupplier
                </th>
                <th
                  class="px-5 py-3 border-b-2 border-gray-200 bg-gray-100"
                ></th>
                <th
                  class="px-5 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-700 uppercase tracking-wider"
                >
                  TotalSales
                </th>
                <th
                  class="px-5 py-3 border-b-2 border-gray-200 bg-gray-100"
                ></th>
                <th
                  class="px-5 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-700 uppercase tracking-wider"
                >
                  LastSalesDate
                </th>
                <th
                  class="px-5 py-3 border-b-2 border-gray-200 bg-gray-100"
                ></th>
                <th
                  class="px-5 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-700 uppercase tracking-wider"
                >
                  LastSalesCustomer
                </th>
                <th
                  class="px-5 py-3 border-b-2 border-gray-200 bg-gray-100"
                ></th>
                <th
                  class="px-5 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-700 uppercase tracking-wider"
                >
                  ImagePath
                </th>
                <th
                  class="px-5 py-3 border-b-2 border-gray-200 bg-gray-100"
                ></th>
                <th
                  class="px-5 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-700 uppercase tracking-wider"
                >
                  Type
                </th>
                <th
                  class="px-5 py-3 border-b-2 border-gray-200 bg-gray-100"
                ></th>
                <th
                  class="px-5 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-700 uppercase tracking-wider"
                >
                  Status
                </th>
                <th
                  class="px-5 py-3 border-b-2 border-gray-200 bg-gray-100"
                ></th>
              </tr>
            </thead>
            <tbody>
              <tr>
                <td class="px-5 py-5 border-b border-gray-200 bg-white text-sm">
                  <div class="flex">
                    <div class="flex-shrink-0 w-10 h-10"></div>
                    <div class="ml-3">
                      <p class="text-gray-900 whitespace-no-wrap">
                        Molly Sanders
                      </p>
                      <p class="text-gray-600 whitespace-no-wrap">000004</p>
                    </div>
                  </div>
                </td>
                <td class="px-5 py-5 border-b border-gray-200 bg-white text-sm">
                  <p class="text-gray-900 whitespace-no-wrap">$20,000</p>
                  <p class="text-gray-600 whitespace-no-wrap">USD</p>
                </td>
                <td class="px-5 py-5 border-b border-gray-200 bg-white text-sm">
                  <p class="text-gray-900 whitespace-no-wrap">Sept 28, 2019</p>
                  <p class="text-gray-600 whitespace-no-wrap">Due in 3 days</p>
                </td>
                <td class="px-5 py-5 border-b border-gray-200 bg-white text-sm">
                  <span
                    class="relative inline-block px-3 py-1 font-semibold text-green-900 leading-tight"
                  >
                    <span
                      aria-hidden
                      class="absolute inset-0 bg-green-200 opacity-50 rounded-full"
                    ></span>
                    <span class="relative">Paid</span>
                  </span>
                </td>
                <td
                  class="px-5 py-5 border-b border-gray-200 bg-white text-sm text-right"
                >
                  <button
                    type="button"
                    class="inline-block text-gray-500 hover:text-gray-700"
                  >
                    <svg
                      class="inline-block h-6 w-6 fill-current"
                      viewBox="0 0 24 24"
                    >
                      <path
                        d="M12 6a2 2 0 110-4 2 2 0 010 4zm0 8a2 2 0 110-4 2 2 0 010 4zm-2 6a2 2 0 104 0 2 2 0 00-4 0z"
                      />
                    </svg>
                  </button>
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
  name: "ProductDetails",
  data() {
    return {
      UserName: "",
      Password: "",
    };
  },
  methods: {
    async loginAsync() {
      let result = await axios.get(
        "https://localhost:7190/api/Authenticate/login",
        {
          userName: this.UserName,
          password: this.Password,
        }
      );
      if (result.status == 200) {
        localStorage.setItem("Token", JSON.stringify(result.data.token));
        localStorage.setItem("UserName", JSON.stringify(this.UserName));
        this.$router.push({ name: "Home" });
      }
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

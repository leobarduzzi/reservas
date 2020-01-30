import Vue from 'vue'
window.axios = require('axios');
import VueAxios from 'vue-axios'
import VueFormGenerator from 'vue-form-generator/dist/vfg-core.js'
import vueForm from './Form'

import 'vue-form-generator/dist/vfg-core.css'
import 'bootstrap'; 
import 'bootstrap/dist/css/bootstrap.min.css';

Vue.use(VueAxios)
Vue.use(VueFormGenerator)


Vue.config.productionTip = false


  new Vue({
    el: '#app',
    components: {
        vueForm
    }
  })

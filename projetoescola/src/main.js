import Vue from 'vue'
import App from './App.vue'
import router from './router.js'
import VueResource from 'vue-resource'
import vuetify from './plugins/vuetify'

Vue.config.productionTip = false;
Vue.use(VueResource);

new Vue({
  //ROUTER - DIZ AO VUE QUE SERÁ COMANDADO POR ROTAS
  router,

  vuetify,
  render: h => h(App)
}).$mount('#app')

<template>
  <v-app>
    <v-main id="app">
      <div>
        <Nav></Nav>
        <div class="marginPrincipal">
          <router-view></router-view>
        </div>
      </div>
    </v-main>
  </v-app>
</template>

<script>
import Alunos from './components/Aluno/Alunos'
import Professor from './components/Professor/Professor'
import Sobre from './components/Sobre/Sobre'
import Nav from './components/_nav/Nav'
import Login from './components/Login/Login'

export default {
  name: 'app',
  components: {
    /* eslint-disable vue/no-unused-components */    //resolve o erro do vue/no-unused-components
    Alunos,
    Professor,
    Sobre,
    Login,
    Nav
  }
}
</script>

<style>

@import url("https://fonts.googleapis.com/css?family=Montserrat:400,700");

body {
  background-color:  whitesmoke;
  font-family: Montserrat, sans-serif;
  display: grid;
  justify-items: center;
}

body, html {
  margin: 0;
  height: 100%;
}

.marginPrincipal {
  width: 50%;
  margin: auto;
}

#app {
  width: 100%;
  background-color:  rgb(228, 224, 224);
}

.btn_Danger {
  font-size: 0.5em !important;
    background-color: #fa4430;
}

.btn {
  padding: 10px 20px;
  cursor: pointer;
  color: white;
  font-weight: bold;
  font-size: 1.0em;
  border: 1px solid black;
  border-radius: 5px;
  border-bottom: 3px solid black;
}

.btn:hover {
  text-shadow: 1px 1px 1px;
  margin-top: 3px;
  border-bottom: 1px solid black;
}

table {
  margin: 0px;
  padding: 0px;
  border: none;
  list-style-type: none;
  width: 100%; 
}

table, tr, td{
  padding: 20px;
  font-size: 1.3em;
  background-color: rgb(191, 244, 248);
  margin-bottom: 2px;
  color: #292d33;
}


table, thead, th{
  background-color: #d5d5d5 !important;
  color: #292d33;
  font-size: 1.2em;
  padding: 0px 0px;
  text-align: center !important;
  width: 100%;
}

.colPequeno {
  width: 5%;
}

</style>

<template>
    <div class="barraTop ">
        <nav class="navbar navbar-expand-lg navbar-dark bg-dark container-fluid">
            <!--Direciona as Rotas para as paginas especificas-->
            <router-link class="btn btn-secondary my-2 my-sm-0" to="/login">Login</router-link>
            <router-link class="btn btn-secondary my-2 my-sm-0" to="/professores">Professores</router-link>
            <router-link class="btn btn-secondary my-2 my-sm-0" to="/todosalunos">Alunos</router-link>
            <router-link class="btn btn-secondary my-2 my-sm-0" to="/sobre">Sobre</router-link>
        </nav>
    </div>
</template>

<script>
    export default {
        
    }
</script>

<style scoped>
.barraTop {
    background-color: rgb(230, 230, 230);
}

nav {
    padding: 20px 20px 20px 0px;
}

nav a {
    padding: 10px;
    text-decoration: none;
    background-color: white;
    border-radius: 3px;
    color: rgb(0, 110, 225);
    font-weight: bold;
    margin-right: 15px;
}

nav .router-link-active {
    background-color: rgb(160, 160, 160);
    color: white;
    float: right;
}

</style>
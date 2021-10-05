import Vue from 'vue';
import Router from 'vue-router';
import Alunos from './components/Aluno/Alunos'
import AlunoDetalhe from './components/Aluno/AlunoDetalhe'
import Professor from './components/Professor/Professor'
import Sobre from './components/Sobre/Sobre'
import Login from './components/Login/Login.vue'

Vue.use(Router);

export default new Router({
    routes: [
        {
            path: '/login',
            nome: 'Login',
            component: Login
        },
        {
            path: '/professores',
            nome: 'Professores',
            component: Professor
        },
        {
            path: '/alunos:prof_id',
            nome: 'Alunos',
            component: Alunos
        },
        {
            path: '/todosalunos',
            nome: 'Alunos',
            component: Alunos
        },
        {
            path: '/alunoDetalhe/:id',
            nome: 'AlunoDetalhe',
            component: AlunoDetalhe
        },
        {
            path: '/sobre',
            nome: 'Sobre',
            component: Sobre
        },
    ]
})
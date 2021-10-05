<template>
  <div>
    <br>
    <titulo :texto="professorid != undefined ? 'Professor: ' + professor.nome : 'Todos os Alunos'"
    btnVoltar="true" style="color: black;"/>
    <br>
    <br>
    <div v-if="professorid != undefined">
      <input class="campo1" style="width: 830px; height: 66px;" type="text" placeholder="Nome do Aluno" v-model="nome" @keyup.enter="addAluno()">
      <button class="btn btn-success btn-lg" style="width: 165px; margin-left: 15px; height: 68px;" @click="addAluno()">Adicionar</button>
    </div>
    <br>
    <hr />

    <table class="table table-striped" border="1px">
      <thead>
        <tr class="thead-light">
          <th class="tabPequeno">Matrícula</th>
          <th>Nome</th>
          <th>Opções</th>
        </tr>
      </thead>
      <tbody v-if="alunos.length">
        <tr v-for="(aluno, index) in alunos" :key="index">
          <td class="colPequeno">{{ aluno.id }}</td>
          <router-link :to="`/AlunoDetalhe/${aluno.id}`" tag="td" style="cursor: pointer">
            {{ aluno.nome }} {{ aluno.sobrenome }}
          </router-link>
          <td class="colPequeno">
            <button class="btn btn_Danger" @click="remover(aluno)">
              Remover
            </button>
          </td>
        </tr>
      </tbody>
      <tfoot v-if="!alunos.length">
        <tr>
          <td colspan="3" style="text-align: center">
              <h5>Nenhum Aluno Encontrado</h5>
          </td>
        </tr>
      </tfoot>
    </table>
  </div>
</template>

<script>
import Titulo from "../_shared/Titulo.vue";

export default {
  components: {
    Titulo,
  },
  data() {
    return {
      título: "Aluno",
      professorid: this.$route.params.prof_id,
      professor: {},
      nome: "",
      alunos: [],
    };
  },
  //Método HTTP GET para conectar com o servidor da API, URL gerada pela API - busca dados de aluno do banco json
  created() {
    if (this.professorid) {
      this.carregarProfessores();
      this.$http
        .get(`http://localhost:5000/api/aluno/ByProfessor/${this.professorid}`)
        .then(res => res.json())
        .then(alunos => (this.alunos = alunos));
    } else {
      this.$http
        .get("http://localhost:5000/api/aluno")
        .then(res => res.json())
        .then(alunos => (this.alunos = alunos));
    }
  },
  props: {},
  methods: {
    //Método ADICIONAR NOVO ALUNO
    addAluno() {
      let _aluno = {
        nome: this.nome,
        sobrenome: "",
        dataNasc: "",
        professorid: this.professor.id
      };


      //Método HTTP Post de conexão com o banco - faz insert de dados
      this.$http
        .post("http://localhost:5000/api/aluno", _aluno)
        .then((res) => res.json())
        .then(aluno => {
          this.alunos.push(aluno);
          this.nome = "";
        });
    },
    remover(aluno) {
      //Método REMOVER ALUNO
      this.$http.delete(`http://localhost:5000/api/aluno/${aluno.id}`).then(() => {
        let indice = this.alunos.indexOf(aluno);
        this.alunos.splice(indice, 1);
      });
    },
    carregarProfessores() {
      this.$http
        .get("http://localhost:5000/api/professor/" + this.professorid)
        .then(res => res.json())
        .then(professor => {
          this.professor = professor          
        });
    },
  },
};
</script>

<!--Estilo com Scoped é aplicado apenas no mesmo escopo, no caso, apenas em alunos-->
<style scoped>
input {
  width: calc(100% - 195px);
  border: 0;
  padding: 20px;
  font-size: 1.3em;
  color: #687f7f;
  display: inline;
}

.campo1 {
  background-color: rgb(228, 227, 227);
}

/* .btnInput {
  width: 195px;
  border: 0px;
  padding: 20px;
  font-size: 1.3em;
  display: inline;
  background-color: rgb(116, 115, 115);
} */

.btnInput:hover {
  padding: 20px;
  margin: 0px;
  border: 0px;
}

.thead-light {
  margin: auto;
  justify-items: center;
  text-align: justify;
}

.tabPequeno {
  width: 2%;
}

.colPequeno {
    text-align: center;
    background-color: rgb(185, 182, 182);
    color: black;
    font-weight: bold;
}
</style>

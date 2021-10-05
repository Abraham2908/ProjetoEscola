<template>
  <div>
    <br>
    <titulo texto="Professor" btnVoltar="true" style="color: black;" />
    <br>
    <br>
    <hr />
    <table class="table table-striped" border="1px">
      <thead>
        <tr>
          <th class="tabPequeno">Código</th>
          <th>Nome</th>
          <th>Alunos</th>
        </tr>
      </thead>
      <tbody v-if="Professores.length">
        <tr v-for="(Professor, index) in Professores" :key="index">
          <td class="colPequeno">{{ Professor.id }}</td>
          <router-link 
          :to="'/alunos' + Professor.id" 
          tag="td" 
          style="cursor: pointer">
            {{ Professor.nome }} {{ Professor.sobrenome }}
          </router-link>
          <td class="colPequeno">
            {{Professor.qtdAlunos}}
          </td>
        </tr>
      </tbody>
      <tfoot v-if="!Professores.length">
        <tr>
          <td colspan="3" style="text-align: center">
              <h5>Nenhum Professor Encontrado</h5>
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
      Professores: [],
      Alunos: [],
    };
  },
  //Método HTTP GET para conectar com o servidor da API, URL gerada pela API - busca dados de professores do banco json
  created() {
    this.$http.get('http://localhost:5000/api/aluno')
    .then(res => res.json())
    .then(alunos => {
      this.Alunos = alunos;
      this.carregarProfessores();
    })
  },
  props: {

  },

  methods: {
    pegarQtdAlunosPorProfessor() {
      this.Professores.forEach((professor, index) => {
        professor = {
          id: professor.id,
          nome: professor.nome,
          qtdAlunos: this.Alunos.filter(aluno => 
            aluno.professor.id == professor.id
          ).length
        }
        this.Professores[index] = professor;
      });
    },
    carregarProfessores() {
      this.$http
        .get("http://localhost:5000/api/professor")
        .then(res => res.json())
        .then(professor => {
          this.Professores = professor
          this.pegarQtdAlunosPorProfessor();
        });
    }
  },

};
</script>

<style scoped>

.tabPequeno {
  width: 5%;
}

.colPequeno {
    text-align: center;
    background-color: rgb(185, 182, 182);
    color: black;
    font-weight: bold;
}

</style>
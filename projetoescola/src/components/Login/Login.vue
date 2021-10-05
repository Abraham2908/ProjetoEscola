<template>
  <v-container class="grey lighten-3" id="login-page">
    <v-row class="d-flex justify-center">
        <v-col
          cols="6"
        >
          <v-img src="./projetoescola1.png" id="hcode-image"></v-img>
          <v-tabs
            fixed-tabs
            background-color="blue-grey lighten-5"
            color="black"
            v-model="tabsForm"
          >
            <v-tab
              key="register"
            >
              Cadastrar
            </v-tab>
            <v-tab
              key="login"
            >
              Fazer Login
            </v-tab>
          </v-tabs>
        </v-col>
    </v-row>
    <v-row class="d-flex justify-center">
      <v-col cols="4">
        <v-tabs-items
          v-model="tabsForm"
          cols="3"  
        >
          <v-tab-item
            key="register"
          >
            <v-form class="text-center grey lighten-3">

              <v-text-field
                v-model="name"
                label="Nome"
                :rules="nameRules"
                required
              ></v-text-field>

              <v-text-field
                v-model="email"
                label="Email"
                :rules="emailRules"
                required
              ></v-text-field>

              <v-text-field
                v-model="password"
                label="Senha"
                type="password"
                :rules="passwordRules"
                required
              ></v-text-field>

              <v-btn
                color="success"
                class="justify-space-between"
              >
                Registrar
              </v-btn>

            </v-form>
          </v-tab-item>

          <v-tab-item
            key="login"
          >

            <v-form class="text-center grey lighten-3">

              <v-text-field
                v-model="email"
                label="Email"
                :rules="emailRules"
                required
              ></v-text-field>

              <v-text-field
                v-model="password"
                label="Senha"
                type="password"
                :rules="passwordRules"
                required
              ></v-text-field>

              <v-btn                
                color="primary"
                class="justify-space-between"
              >
                Acessar
              </v-btn>

            </v-form>

          </v-tab-item>
        </v-tabs-items>
      </v-col>
    </v-row>
  </v-container>
</template>

<script>
  export default {
    name: 'AdminForm',
    data: () => ({
      tabsForm: null,
      nameRules: [
        value => !!value || 'O nome é obrigatório',
        value => (value && value.length >= 3) || 'O nome deve ter no mínimo 3 caracteres',
        value => (value && value.length <= 10) || 'O nome deve ter menos do que 10 caracteres'
      ],
      emailRules: [
        value => !!value || 'O e-mail é obrigatório',
        value => /.+@.+\..+/.test(value) || 'O e-mail não é válido',
      ],
      passwordRules: [
        value => !!value || 'A senha é obrigatória',
        value => (value && value.length >= 5) || 'A senha deve ter no mínimo 5 caracteres'
      ]
    })
  }
</script>

<style scoped>
  #login-page {
    margin-top: 100px;
  }
  #hcode-image {
    margin: auto;
    width: 100%;
  }
</style>
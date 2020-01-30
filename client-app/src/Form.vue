<template>
  <div class="panel-body">
    <form>
      <vue-form-generator :schema="schema" :model="model" :options="formOptions">
      </vue-form-generator>
    </form>
  </div>
</template>
<script>
export default {
    data () {
        return {
        model: null,
        schema: null,
        formOptions: null
        }
    },
    mounted () {
        axios
        .get('/api/Anuncio/0')
        .then(response => {
            console.log(response)
        })
    }
}
</script>
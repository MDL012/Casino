<template>
  <h1 class="d-flex justify-content-center">Fogadások</h1>
  <div class="border m-3">
    <h3 v-if="jack.jackpot.length < 1" class="d-flex justify-content-center text-danger">Még nincs leadott fogadás.</h3>
    <h4 v-if="jack.jackpot.length > 0">Megtett Játékok:</h4>
    <ul v-if="jack.jackpot.length > 0" v-for="n in jack.jackpot">
      <li>{{ n }}</li>
    </ul>
    <input v-if="jack.jackpot.length > 0" type="button" @click="jack.deletList()" class="btn btn-danger m-2 px-5" value="Lista törlése"></input>
  </div>
</template>

<script setup>
import { ref } from 'vue'
import { useCounterStore } from "../stores/counter.js";

const jack = useCounterStore();
</script>


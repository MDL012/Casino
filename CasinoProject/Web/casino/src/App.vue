<script setup>
import { RouterLink, RouterView } from 'vue-router'
</script>

<template>
  <header>
      <nav class="container-fluid d-flex justify-content-center">
        <RouterLink class="btn btn-outline-success m-2" to="/">Lottók</RouterLink>
        <RouterLink class="btn btn-outline-success m-2" to="/play">Játék</RouterLink>
      </nav>

  </header>
  <RouterView />
</template>
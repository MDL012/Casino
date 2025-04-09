<template>
    <h1 class="d-flex justify-content-center">Lottók</h1>
   <div class="d-flex flex-wrap m-5">
    <div class="card col-6">
      <h3 class="m-3">Ötöslottó</h3>
      <img class="m-3" src="../components/lotto5.png" alt="Ötöslottó">
      <p class="m-3">Az Ötöslottó játékbanban 90 számból kell 5-öt kiválasztani</p>
      <input type="button" @click="addgame('Ötöslottó')" class="btn btn-success m-2" value="Játszom"></input>
    </div>
    <div class="card col-6">
      <h3 class="m-3">Hatoslottó</h3>
      <img class="m-3" src="../components/lotto6.png" alt="Hatoslottó">
      <p class="m-3">Az Hatoslottó játékbanban 45 számból kell 6-öt kiválasztani</p>
      <input type="button" @click="addgame('Hatoslottó')" class="btn btn-success m-2" value="Játszom"></input>
    </div>
    <div class="card col-6">
      <h3 class="m-3">Skandináv Lottó</h3>
      <img class="m-3" src="../components/lotto7.png" alt="Skandináv Lottó">
      <p class="m-3">Az Skandináv Lottó játékbanban 35 számból kell 7-öt kiválasztani</p>
      <input type="button" @click="addgame('Skandináv Lottó')" class="btn btn-success m-2" value="Játszom"></input>
    </div>
    <div class="card col-6">
      <h3 class="m-3">EuroJackpot</h3>
      <img class="m-3" src="../components/lotto8.png" alt="EuroJackpot">
      <p class="m-3">Az EuroJackpot játékbanban 50 számból kell 5-öt és 12-ből 2-őt kiválasztani</p>
      <input type="button" @click="addgame('EuroJackpot')" class="btn btn-success m-2" value="Játszom"></input>
    </div>
   </div>
</template>

<script setup>
import { ref } from 'vue'
import { useCounterStore } from "../stores/counter.js";

const jack = useCounterStore();

const addgame = (game) => {
  jack.giveGame(game)
}
</script>

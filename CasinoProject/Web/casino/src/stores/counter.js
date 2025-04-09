import { ref, computed } from 'vue'
import { defineStore } from 'pinia'

export const useCounterStore = defineStore('casino', () => {
  const jackpot = ref([])

  const giveGame = (game) => {
    jackpot.value.push(game)
  }
  const fillGame = (game) => {
    if(jackpot.value.length < 1){
      game = true
    }
    else{
      game = false
    }
  }
  const deletList = () => {
    jackpot.value = []
  }

  return { jackpot, giveGame, fillGame, deletList}
})

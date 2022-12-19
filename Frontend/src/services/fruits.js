import api from './api.js'

export const findAll = () => {
  return api.get('fruit/')
}

export const findById = (id) => {
  return api.get(`fruit/${id}`)
}

export const multiply = (id) => {
  return api.post(`fruit/multiply/${id}`)
}

export const divide = (id) => {
  return api.post(`fruit/divide/${id}`)
}
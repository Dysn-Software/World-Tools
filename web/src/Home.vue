<script setup>
    import worldService from './services/world'
    const data = worldService.getWorldBySlug('test')
</script>

<template>
    <h1>{{data.name}}</h1>
</template>
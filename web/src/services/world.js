import axios from 'axios'

async function getWorldBySlug(slug) {
    return await axios.get(`/api/world/${slug}`)
}

export default {
    getWorldBySlug
}

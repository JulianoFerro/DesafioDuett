import axios from 'axios';

const __API__ = 'https://localhost:7035/api/';

export default axios.create({
    baseURL: __API__
});
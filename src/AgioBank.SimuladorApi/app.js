const express = require('express');
const bodyParser = require('body-parser');
const cors = require('cors');

const app = express();
const port = 3000;
// Habilita o middleware de CORS
const apiKey = 'abcdefgh';

app.use(cors());

app.use((req, res, next) => {
    const clientApiKey = req.headers['x-apikey'];

    if (clientApiKey && clientApiKey === apiKey) {
        next();
    } else {
        res.status(403).json({ message: 'Acesso proibido. Chave API inválida ou ausente.' });
    }
});

app.use(bodyParser.json());

app.post('/api/v1/login', (req, res) => {
    const { email, senha } = req.body;

    // Simulação de autenticação
    if (email === 'eduardo.boca@gmail.com' && senha === '123456') {
        const responseData = {
            Token: '1234132523i',
            Id: '1',
            Name: 'Eduardo Freitas',
            Email: 'eduardo.boca@gmail.com'
        };

        res.status(200).json(responseData);
    } else {
        res.status(401).json({ message: 'Credenciais inválidas' });
    }
});

app.listen(port, () => {
    console.log(`Servidor em execução em http://localhost:${port}`);
});

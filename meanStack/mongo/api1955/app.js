const express = require('express');
const app = express();
const PORT = 8000;
const bodyParser = require('body-parser');

//for future api's to allow for json and url encodded form data from post reques, available in req.body
app.use(bodyParser.json());
app.use(bodyParser.urlencoded({extended: true}));

require('./server/config/mongoose');
require('./server/config/routes')(app);

app.listen(PORT, ()=> {
    console.log(`Listening on port ${PORT}`);
})
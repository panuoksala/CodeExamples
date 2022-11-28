// RUN npm install express
// first to install the expressjs

var express = require('express')

var app = express()

app.get('/', function(request, response) {
    response.json({ Name: 'Panu', Age: 37 })
})

var server = app.listen(8000)
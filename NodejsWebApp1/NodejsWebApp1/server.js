var http = require('http');
var port = process.env.port || 1337;
http.createServer(function (req, res) {
    res.writeHead(200, { 'Content-Type': 'text/plain' });

    var msg = require("./msgs.js");
    var msg1 = require("./msg1.js");

    res.end('Hello World\n' + msg1() + msg.first);

}).listen(port);
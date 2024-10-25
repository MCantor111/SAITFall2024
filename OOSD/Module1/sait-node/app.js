const http = require("http");
const fs = require("fs");

http.createServer((req,res) => {
    fs.readFile("demo.html", (err,data) => {

        res.writeHead(200, {"Content-Type" : "text/html"});

        // res.write("<h1>Hello World!</h1>");
        res.write(data);

        res.end();

    }).listen(8000, () => {
        console.log(`Server is running on port 8000`);
    });
});
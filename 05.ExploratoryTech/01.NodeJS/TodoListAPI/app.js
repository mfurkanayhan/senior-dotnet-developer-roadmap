const express = require("express");
const cors = require("cors");
const app = express();

app.use(cors());

// API Methods => GET, POST, PUT, DELETE

const todos = ["Todo 1", "Todo 2", "Todo 3"];

app.get("/api", (req, res) => {
    res.json({message: "API is working"});
});

app.get("/api/getTodos", (req, res) => {
    res.json(todos); // Return the list of todos
})

// Arrow Function
app.listen(7000, () => {
    console.log("API is running on localhost:7000...");
});

// Anonymous Function
/*
app.listen(7000, function() {
    console.log("API is running on localhost:7000...");
});
*/
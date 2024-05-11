const express = require('express');
const cors = require('cors');
const mongoose = require('mongoose');

const app = express();
app.use(cors());
app.use(express.json());

const uri = 'mongodb://127.0.0.1:27017/tododb';
mongoose.connect(uri, { useNewUrlParser: true, useUnifiedTopology: true })
  .then(() => console.log('MongoDB connection successful'))
  .catch(err => console.error('MongoDB connection error:', err));

const todoSchema = new mongoose.Schema({
    work: String,
    date: { type: Date, default: Date.now }
});

const Todo = mongoose.model('Todo', todoSchema);

app.get('/api/getAll', async (req, res) => {
    const todos = await Todo.find({});
    res.json(todos);
});

app.post('/api/save', async (req, res) => {
    const newTodo = new Todo({ work: req.body.work });
    await newTodo.save();
    res.status(201).send(newTodo);
});

app.post('/api/update', async (req, res) => {
    const { _id, work } = req.body;
    const updatedTodo = await Todo.findByIdAndUpdate(_id, { work }, { new: true });
    res.json(updatedTodo);
});

app.post('/api/removeById', async (req, res) => {
    const { _id } = req.body;
    await Todo.findByIdAndDelete(_id);
    res.status(204).send();
});

app.listen(7000, () => console.log('Server is running on http://localhost:7000'));

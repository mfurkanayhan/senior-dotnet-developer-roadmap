import axios from 'axios';
import { useEffect, useState } from 'react';

export function TodoComponent(){
    const [work, setWork] = useState("Write something...");
    const [todos, setTodos] = useState([]);
    const [limit, setLimit] = useState(10);
    
    const save = (e) => {
      e.preventDefault();
      setTodos((prev)=> [...prev, {title: work}]);
      setWork("");
    }
  
    function getTodos(){
      axios.get("https://jsonplaceholder.typicode.com/todos")    
      .then(res => {
        setTodos(res.data.slice(0, limit));
      })
    }
  
    useEffect(()=> {
      getTodos();
    },[limit]);
  
    return(
    <>
        <h1>Hello World!</h1>
        <h2>Todo App</h2>
        <form onSubmit={save}>
          <input value={work} onChange={(e)=> setWork(e.target.value)} className="" />
          <button>Save</button>
        </form>
        <div>
          <label htmlFor="limit">Number of todos to show: </label>
          <input
            id="limit"
            type="number"
            value={limit}
            onChange={(e) => setLimit(Number(e.target.value))}
          />
        </div>
        <ul>
          {todos.map((val,i)=> <li key={i}>{i}. {val.title}</li>)}
        </ul>
      </>
    )
  }
  
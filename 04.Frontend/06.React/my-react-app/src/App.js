// App.js
import React from 'react';
import './App.css';
import { AboutComponent } from './AboutComponent';
import { TodoComponent } from './TodoComponent';

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <div className="App-section">
          <TodoComponent />
        </div>
        <div className="App-section">
          <AboutComponent />
        </div>
      </header>
    </div>
  );
}

export default App;

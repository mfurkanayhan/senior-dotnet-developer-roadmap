const rootEl = document.getElementById("root");

function gotoHome() {
  rootEl.innerHTML = `
    <h1>Home Page</h1>
    <input id="inputField" placeholder="Type something...">
    <p id="welcomeMessage">Welcome to !</p>
  `;
  const inputField = document.getElementById("inputField");
  inputField.addEventListener('input', updateMessage);
}

function gotoAbout() {
  rootEl.innerHTML = `
    <h1>About Page</h1>
    <input id="aboutInputField" placeholder="Type your name...">
    <p id="aboutMessage">Hello, !</p>
  `;
  const aboutInputField = document.getElementById("aboutInputField");
  aboutInputField.addEventListener('input', updateAboutMessage);
}

function updateMessage(event) {
  const welcomeMessage = document.getElementById("welcomeMessage");
  welcomeMessage.textContent = `Welcome to ${event.target.value}!`;
}

function updateAboutMessage(event) {
  const aboutMessage = document.getElementById("aboutMessage");
  aboutMessage.textContent = `Hello, ${event.target.value}!`;
}

gotoHome();
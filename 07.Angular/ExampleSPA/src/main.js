document.addEventListener("DOMContentLoaded", function () {
    loadHomePage();
});

function loadHomePage() {
    fetch('home.html')
        .then(res => res.text())
        .then(html => {
            document.querySelector('app-root').innerHTML = html;
        })
        .catch(error => console.error('Error loading the home page: ', error));
}

function gotoAboutPage() {
    fetch('about.html')
        .then(res => res.text())
        .then(html => {
            document.querySelector('app-root').innerHTML = html;
        })
        .catch(error => console.error('Error loading the about page: ', error));
}

function gotoHomePage() {
    loadHomePage();
}

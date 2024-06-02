function gotoAboutPage() {
    fetch("./about.html")
        .then(res => res.text())
        .then(data => {
            const el = document.querySelector("app-root");
            if (el) {
                el.innerHTML = data;
            } else {
                console.error("app-root element not found.");
            }
        })
        .catch(error => console.error(error));
}
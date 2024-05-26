// script.js
$(document).ready(function() {
  let colorChangeInterval;

  // Button click event to fetch data
  $("#fetchButton").click(function() {
    // Fetch API to get data
    fetch("https://jsonplaceholder.typicode.com/posts")
      .then(res => res.json())
      .then(data => {
        console.log("Fetch API:", data);
        $("#resultContainer").append("<h3>Fetch API Results</h3>");
        data.slice(0, 5).forEach(post => {
          $("#resultContainer").append(`<p class="data-item">${post.title}</p>`);
        });
        $("#resultContainer").removeClass("hidden");
      });

    // Axios to get data
    axios.get("https://jsonplaceholder.typicode.com/users")
      .then(res => {
        console.log("Axios:", res.data);
        $("#resultContainer").append("<h3>Axios Results</h3>");
        res.data.slice(0, 5).forEach(user => {
          $("#resultContainer").append(`<p class="data-item">${user.name}</p>`);
        });
      });

    // jQuery AJAX to get data
    $.ajax({
      method: "GET",
      url: "https://jsonplaceholder.typicode.com/comments",
      success: function(res) {
        console.log("jQuery AJAX:", res);
        $("#resultContainer").append("<h3>jQuery AJAX Results</h3>");
        res.slice(0, 5).forEach(comment => {
          $("#resultContainer").append(`<p class="data-item">${comment.body}</p>`);
        });
      }
    });
  });

  // Function to get a random color
  function getRandomColor() {
    const letters = '0123456789ABCDEF';
    let color = '#';
    for (let i = 0; i < 6; i++) {
      color += letters[Math.floor(Math.random() * 16)];
    }
    return color;
  }

  // Button click event to change colors
  $("#colorChangeButton").click(function() {
    // Change colors of all .data-item elements once
    $(".data-item").each(function() {
      $(this).css("color", getRandomColor());
    });
  });

  // Event handling
  $("#resultContainer").on("mouseenter", "p", function() {
    $(this).css("background-color", "yellow");
  });

  $("#resultContainer").on("mouseleave", "p", function() {
    $(this).css("background-color", "white");
  });
});

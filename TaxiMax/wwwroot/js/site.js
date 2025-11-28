// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
let rows = document.querySelectorAll("tr");

rows.forEach(row => {
    let cells = row.querySelectorAll("td");

    cells.forEach(cell => {
        if (cell.innerHTML.trim() === "Zakończono") {
            row.style.textDecoration = "line-through";
            row.style.filter = "opacity(50%)";
            cell.style.background = "green";
        }else
        if (cell.innerHTML.trim() === "W trakcie") {
            cell.style.background = "orange";
        }else
        if (cell.innerHTML.trim() === "Nowe") {
            cell.style.background = "red";
        }
    });
});

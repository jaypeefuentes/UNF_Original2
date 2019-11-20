// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function confirmCancel()
{
    if (confirm("Are you sure you want to cancel?")) {
        window.location.replace("https://localhost:44347/");
        return true;
    }
    else {
        return false;
    }
}

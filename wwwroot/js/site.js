// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Make sure sw are supported
if ('serviceWorker' in navigator) {
    window.addEventListener('load', () => {
        navigator.serviceWorker
            .register('../serviceworker.js')
            .then(reg => console.log('Service Worker: Registered (Pages)'))
            .catch(err => console.log(`Service Worker: Error: ${err}`));
    });
}



/*

// Replace with your JSON feed
fetch('https://joaosilgo.github.io/dummy_db/posts.json')
    .then((response) => {
        return response.json()
    })
    .then((data) => {
        // Work with JSON data here
        console.log(data);
    })
    .catch((err) => {
        // Do something for an error here
    });

*/

var url ='https://joaosilgo.github.io/dummy_db/posts.json';
var req = new XMLHttpRequest();
req.responseType = 'json';
req.open('GET', url, true);
req.onload = function () {
    var jsonResponse = req.response;
    console.log(jsonResponse);
    // do something with jsonResponse
};
req.send(null);
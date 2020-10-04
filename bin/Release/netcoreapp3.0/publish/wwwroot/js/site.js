// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Make sure sw are supported
if ('serviceWorker' in navigator) {
    window.addEventListener('load', () => {
    let sw = navigator.serviceWorker
            .register('../serviceworker.js')
            .then(reg => console.log('Service Worker: Registered (Pages)'))
            .catch(err => console.log(`Service Worker: Error: ${err}`));

        console.log(sw);
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


/*

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


*/

if (navigator.onLine) {
    console.log('online');
} else {
    console.log('offline');
}




window.addEventListener('offline', function (e) {
    console.log('offline');
    createAlert('Opps!', 'Seems that you are Offline', ' <hr> Try Reconnect to your Internet provider. ', 'alert alert-secondary', true, true, 'pageMessages');


});

window.addEventListener('online', function (e) {
    console.log('online');
    createAlert('Yay!', 'You are Online', ' <hr>Surf Away. ', 'alert alert-light', true, true, 'pageMessages');


});








function createAlert(title, summary, details, severity, dismissible, autoDismiss, appendToId) {
    var iconMap = {
        info: "info",
        success: "success",
        warning: "warning",
        danger: "danger"
    };

    var iconAdded = false;

    var alertClasses = ["alert", "animated", "flipInX"];
    alertClasses.push("alert-" + severity.toLowerCase());

    if (dismissible) {
        alertClasses.push("alert-dismissible");
    }

    var msgIcon = $("<i />", {
        "class": iconMap[severity] // you need to quote "class" since it's a reserved keyword
    });

    var msg = $("<div  />", {
        "class": alertClasses.join(" "), // you need to quote "class" since it's a reserved keyword
        "role":"alert"
    });

    if (title) {
        var msgTitle = $("<h4 />", {
            html: title
        }).appendTo(msg);

        if (!iconAdded) {
            msgTitle.prepend(msgIcon);
            iconAdded = true;
        }
    }

    if (summary) {
        var msgSummary = $("<strong />", {
            html: summary
        }).appendTo(msg);

        if (!iconAdded) {
            msgSummary.prepend(msgIcon);
            iconAdded = true;
        }
    }

    if (details) {
        var msgDetails = $("<p />", {
            html: details
        }).appendTo(msg);

        if (!iconAdded) {
            msgDetails.prepend(msgIcon);
            iconAdded = true;
        }
    }


    if (dismissible) {
        var msgClose = $("<button />", {
            "class": "close", // you need to quote "class" since it's a reserved keyword
            "data-dismiss": "alert",
            "aria-label": "Close",
            "type":"button",
            html: "<span aria-hidden='true'>&times;</span>"
        }).appendTo(msg);
    }

    $('#' + appendToId).prepend(msg);

    if (autoDismiss) {
        setTimeout(function () {
            msg.addClass("flipOutX");
            setTimeout(function () {
                msg.remove();
            }, 500);
        }, 2500);
    }
}



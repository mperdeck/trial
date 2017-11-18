// JavaScript source code

//alert(333)

var xhr = new XMLHttpRequest();

function onStateChanged() {
    console.log("new state - readyState: " + xhr.readyState);
    console.log("new state - status: " + xhr.status);
    // console.log("new state - responseText: " + xhr.responseText);
    console.log("new state - responseText length: " + xhr.responseText ? xhr.responseText.length : 'no response yet');
    console.log("new state - response header Content-Length: " + xhr.getResponseHeader('Content-Length'));
    console.log("---------------");
}

xhr.onreadystatechange = onStateChanged;

var ajaxUrl = "http://jsnlog.com";

console.log("start");

xhr.open('GET', ajaxUrl);

// Set timeout after you've called open, otherwise you get invalidstateerror on IE10
xhr.timeout = 5000;
console.log("opened");

xhr.send();
console.log("sent");






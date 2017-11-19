// JavaScript source code

//alert(333)

var xhr;

var _console = console;
var _XMLHttpRequest = XMLHttpRequest;
xhr = new _XMLHttpRequest();


function showstatus() {
    alert("new state - readyState: " + xhr.readyState);
    alert("new state - status: " + xhr.status);
    // console.log("new state - responseText: " + xhr.responseText);
   // alert("new state - responseText length: " + xhr.responseText ? xhr.responseText.length : 'no response yet');
  //  alert("new state - response header Content-Length: " + xhr.getResponseHeader('Content-Length'));
}

function download() {

    _console.log("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

    var xhrState = this.xhr.readyState;
    if ((xhrState != 0) && (xhrState != 4)) {
        this.xhr.abort();
        _console.log(")))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))");
    }





    var onStateChanged = function() {
        _console.log("new state - readyState: " + xhr.readyState);
        _console.log("new state - status: " + xhr.status);
        // console.log("new state - responseText: " + xhr.responseText);
        _console.log("new state - responseText length: " + xhr.responseText ? xhr.responseText.length : 'no response yet');
        _console.log("new state - response header Content-Length: " + xhr.getResponseHeader('Content-Length'));
        _console.log("---------------");
    }

    xhr.onreadystatechange = onStateChanged;

    var ajaxUrl = "http://jsnlog.com/brokenbigfile.html";
   // ajaxUrl = "http://jsnlog.com";
  //  var ajaxUrl = "http://jsnlog.com/Tasmaniadates.xlsx";

    _console.log("start");

    xhr.open('GET', ajaxUrl);

    // Set timeout after you've called open, otherwise you get invalidstateerror on IE10
    //
    // Note that on IE10 and Edge, if internet disappears while file is being downloaded,
    // timeout does not kick in and xhr stays in readyState 3 forever.
    // If internet is gone when you call send though, it will go directly to readyState 4 and status 0.
    xhr.timeout = 50000;
    _console.log("opened");

    xhr.send();
    _console.log("sent");
}

var timer = null;

//download();

function start() {
    download();
}

//function stop() {
//    if (timer) clearTimeout(timer);
//}

function show() {
    showstatus();
}










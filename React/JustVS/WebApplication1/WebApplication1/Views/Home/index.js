"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var React = require("react");
var ReactDOM = require("react-dom");
var Hello_1 = require("../../src/components/Hello");
//mmmlllddd
(function () {
    var elements = document.getElementsByClassName("example");
    var i;
    var compiler;
    var framework;
    for (i = 0; i < elements.length; i++) {
        compiler = elements[i].dataset.compiler;
        framework = elements[i].dataset.framework;
        ReactDOM.render(React.createElement(Hello_1.Hello, { compiler: compiler, framework: framework }), elements[i]);
    }
})();
//# sourceMappingURL=index.js.map
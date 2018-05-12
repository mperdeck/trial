import * as React from "../../node_modules/@types/react/index";
import * as ReactDOM from "../../node_modules/@types/react-dom/index";
/// <r eference path="../../node_modules/@types/react-dom/index.d.ts" />
import { Hello } from "../../src/components/Hello.js";
// Must use .js extension, because this line will be used by the browser and it requires an extension
// this works for both compiler and browser
//declare var ReactDOM: any;
//declare var React: any;
//mmmllldddhhhh445578866
(function () {
    var elements = document.getElementsByClassName("example");
    var i;
    var compiler;
    var framework;
    for (i = 0; i < elements.length; i++) {
        compiler = elements[i].dataset.compiler;
        framework = elements[i].dataset.framework;
        ReactDOM.render(React.createElement(Hello, { compiler: compiler, framework: framework }), elements[i]);
    }
})();
//# sourceMappingURL=index.js.map
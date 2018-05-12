import { Hello } from "../../src/components/Hello.js";
(function () {
    var elements = document.getElementsByClassName("example");
    var i;
    for (i = 0; i < elements.length; i++) {
        ReactDOM.render(React.createElement(Hello, { compiler: elements[i].dataset.compiler, framework: elements[i].dataset.framework }), elements[i]);
    }
})();
//# sourceMappingURL=index.js.map
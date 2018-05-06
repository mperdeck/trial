import * as React from "react";
import * as ReactDOM from "react-dom";

import { Hello } from "./components/Hello";




(function () {
    var elements = document.getElementsByClassName("example");
    var i;
    for (i = 0; i < elements.length; i++) {
        ReactDOM.render(
            <Hello compiler="TypeScript14" framework="React" />, elements[i]
        );
    }
})();



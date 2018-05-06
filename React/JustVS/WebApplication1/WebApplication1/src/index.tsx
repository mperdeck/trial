import * as React from "react";
import * as ReactDOM from "react-dom";

import { Hello } from "./components/Hello";




(function () {
    var elements = document.getElementsByClassName("example");
    var i: number;
    var compiler: string;
    var framework: string;
    for (i = 0; i < elements.length; i++) {
        compiler = (elements[i] as any).dataset.compiler;
        framework = (elements[i] as any).dataset.framework;

        ReactDOM.render(
            <Hello compiler={compiler} framework={framework} />, elements[i]
        );
    }
})();



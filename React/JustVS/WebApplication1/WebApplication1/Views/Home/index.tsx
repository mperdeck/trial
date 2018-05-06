
// It can't find the typings ########################
import * as React from "../../src/node_modules/react/index";
import * as ReactDOM from "../../src/node_modules/react-dom/index";

import { Hello } from "../../src/components/Hello";




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



/// <r eference path="../../node_modules/@types/react-dom/index.d.ts" />

import { Hello } from "../../src/components/Hello.js";
// Must use .js extension, because this line will be used by the browser and it requires an extension

// this works for both compiler and browser
declare var ReactDOM: any;
declare var React: any;


//mmmllldddhhhh445578866

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



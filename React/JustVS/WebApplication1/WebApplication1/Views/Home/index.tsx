import { Hello } from "../../src/components/Hello.js";
// Must use .js extension, because this line will be used by the browser and it requires an extension

// this works for both compiler and browser
declare var ReactDOM: any;
declare var React: any;

(function () {
    var elements = document.getElementsByClassName("example");
    var i: number;
    for (i = 0; i < elements.length; i++) {
        ReactDOM.render(
            <Hello
                compiler={(elements[i] as any).dataset.compiler}
                framework={(elements[i] as any).dataset.framework} />, elements[i]
        );
    }
})();



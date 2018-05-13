/// <reference path="../../node_modules/@types/react-dom/index.d.ts" />
var __extends = (this && this.__extends) || (function () {
    var extendStatics = Object.setPrototypeOf ||
        ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
        function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
// this works for both compiler and browser
//declare var ReactDOM: any;
//declare var React: any;
//import { React } from "./react-types.js";
//import { ReactDOM } from "./react-dom-types.js";
//import * as React from "react";
//import * as ReactDOM from "react-dom";
if (false) {
}
// 'HelloProps' describes the shape of props.
// State is never set so we use the '{}' type.
var Message = /** @class */ (function (_super) {
    __extends(Message, _super);
    function Message() {
        return _super !== null && _super.apply(this, arguments) || this;
    }
    Message.prototype.render = function () {
        return React.createElement("h1", null, this.props.children);
    };
    return Message;
}(React.Component));
export { Message };
//# sourceMappingURL=Message.js.map
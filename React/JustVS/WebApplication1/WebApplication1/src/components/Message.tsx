/// <reference path="../../node_modules/@types/react-dom/index.d.ts" />


// this works for both compiler and browser
//declare var ReactDOM: any;
//declare var React: any;

//import { React } from "./react-types.js";
//import { ReactDOM } from "./react-dom-types.js";


//import * as React from "react";
//import * as ReactDOM from "react-dom";



if (false) {
}

export interface MessageProps { children: string[] }

// 'HelloProps' describes the shape of props.
// State is never set so we use the '{}' type.
export class Message extends React.Component<MessageProps, {}> {
    render() {
        return <h1>{this.props.children}</h1>;
    }
}


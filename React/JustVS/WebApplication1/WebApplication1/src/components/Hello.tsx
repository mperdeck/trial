// i mport * as React from "react";
declare var ReactDOM: any;
declare var React: any;

export interface HelloProps { compiler: string; framework: string; }

export const Hello = (props: HelloProps) => <h1>Hello!oo! from {props.compiler} and {props.framework}!</h1>;

//kkkkkttt77


import { Message } from "./Message.js";
// Must use .js extension, because this line will be used by the browser and it requires an extension

// this works for both compiler and browser
declare var ReactDOM: any;
declare var React: any;

export interface HelloProps { compiler: string; framework: string; }

export const Hello = (props: HelloProps) => <Message>Hello!oo! from {props.compiler} and {props.framework}!</Message>;

//kkkkkttt77


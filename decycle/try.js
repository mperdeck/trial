
var f = function (k) {

}

console.log(typeof f);

console.log("xxxxxxxxxxxxxxxx")

var x = { a: 1, b: 2 };
var x2 = { q: 99, w: 100, y: 101 };

console.log(typeof x);

var ar = [];
ar[x] = x2;
ar[x] = x2;
console.dir(ar[x]);

console.log("xxxxxxxxxxxxxxxx")

var b1 = { y: 3 };
var a1 = { x: b1 };
b1 = { y: 7 };

console.log("xxxxxxxxxxxxxxxx")

var a2 = {};
var b2 = {}
b2.d = { e: a2 };
a2.c = { b: b2 };

console.log("xxxxxxxxxxxxxxxx")

var replacer = function (key, value) {

    console.log("-----------")
    console.log("key:" + key)
    console.log("value:");
    console.dir(value);
    console.log("this:");
    console.dir(this);

    if (typeof value == 'object') {
        console.log("is object")
    }
    return value;
}


var obj = {
    g: {
        d: [2, 5, x, x, 4, x],
        j: 2
    },
    e: 10
};

//obj.someloopshere = [
//    obj.g,
//    obj,
//    { a: [obj.e, obj] }
//];

var safeStringify = function(o) {
    
    var parents = [];

    var replacer = function (key, value) {

        if (typeof value == 'function') {
            return "__function__";
        }

        if (typeof value != 'object') {
            return value;
        }

        // Detect circular definitions. For example:
        // var a2 = {};
        // var b2 = {}
        // b2.d = { e: a2 };
        // a2.c = { b: b2 };
        //
        // This is done by storing the parent of each sub object in o in the parents 
        // dictionary. Note that this maps an object to its parent.
        // Recommended to read the description of the replacer parameter of JSON.stringify:
        // https://developer.mozilla.org/en/docs/Web/JavaScript/Reference/Global_Objects/JSON/stringify
        // http://stackoverflow.com/questions/9382167/serializing-object-that-contains-cyclic-object-value/9382383#9382383

        parents[value] = this;

        var parent = this;
    //    parents[parent] = null; //<<<<<<

        console.log('================');
        console.log('key=' + key);
        console.log('value');
        console.dir(value);
        console.log('this');
        console.dir(this);
        console.log('parents[value]')
        console.dir(parents[value])
        console.log('parents[parent]')
        console.dir(parents[parent])
        console.log('len=' + parents.length)
        //console.log('================ parents');

        //var j = 0;
        //for (j = 0; j < parents.length; j++) {
        //    console.dir()
        //}

        console.log('================');

        var i;
        for (i=0; i<100;i++) {

            console.log('chck parent');
            console.dir(parent);
            console.log('-------------');


            if (!parent) {
                // Got to the end of the parent chain

                console.log('returning val')
                console.dir(value)
                return value;
            }

            if (parent == value) {
                return "__circular__";
            }

            console.log('after >>>');
            console.dir(parents[parent]);
            console.dir(parent);
            console.log('after <<<');

            parent = parents[parent];

        }
    }

    var result = JSON.stringify(o, replacer, 4);
    return result;
}




var s = safeStringify(a2);

alert(s)





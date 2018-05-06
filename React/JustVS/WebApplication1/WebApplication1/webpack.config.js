/// <binding ProjectOpened='Watch - Development' /> 

// By default, entry point is ./src/index.js and output is ./dist/main.js

const path = require('path');

module.exports = {
    entry: './src/index.js',
    output: {
        // the code "path.resolve(__dirname, 'wwwroot/js')" doesn't work, so just append the '/js'
        path: path.resolve(__dirname, 'wwwroot') + '/js',
        filename: 'main.js'
    }
};

/// <binding ProjectOpened='Watch - Development' /> 

// By default, entry point is ./src/index.js and output is ./dist/main.js

const path = require('path');

module.exports = {
    entry: './src/module.js',
    output: {
        // the code "path.resolve(__dirname, 'wwwroot/js')" doesn't work, so just append the '/js'
        path: path.resolve(__dirname, 'wwwroot') + '/js',
        filename: 'main.js'
    },

    // When importing a module whose path matches one of the following, just
    // assume a corresponding global variable exists and use that instead.
    // This is important because it allows us to avoid bundling all of our
    // dependencies, which allows browsers to cache those libraries between builds.
    externals: {
        "react": "React",
        "react-dom": "ReactDOM"
    }
};

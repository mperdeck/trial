var path = require('path');
var helpers = require('./config/helpers');

module.exports = {
    entry: './src/js/app.ts',
    output: {
        path: path.resolve(__dirname, 'dist'),
        filename: 'bundle.js',
        publicPath: '/dist'
    },
    resolve: {
        extensions: ['.ts', '.js']
    },
    module: {
        rules: [
            {
                test: /\.ts$/,
                use: [
                    {
                        loader: 'awesome-typescript-loader',
                        options: {
                            configFileName: helpers.root('src', 'tsconfig.json')
                        }
                    }
                ]
            }
        ]
    }
};
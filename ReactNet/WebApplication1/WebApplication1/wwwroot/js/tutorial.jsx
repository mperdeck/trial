﻿var Comment = React.createClass({

    rawMarkup: function () {
        var md = new Remarkable();
        var rawMarkup = md.render(this.props.children.toString());
        return { __html: rawMarkup };
    },

    render: function () {
        return (
            <div className="comment">
                <h2 className="commentAuthor">
                    {this.props.author}
                </h2>
                <span dangerouslySetInnerHTML={this.rawMarkup()} />
            </div>
        );
    }
});

var CommentList = React.createClass({
    render: function () {
        return (
            <div className="commentList">
                <Comment author="Daniel Lo Nigro">Hello ReactJS.NET World!</Comment>
                <Comment author="Pete Hunt">This is one comment</Comment>
                <Comment author="Jordan Walke">This is *another* comment</Comment>
            </div>
        );
    }
});

// from this tutorial:
// https://reactjs.net/getting-started/tutorial.html

var CommentBox = React.createClass({
    render: function () {
        return (
            <div className="commentBox">
                <h1>Comments</h1>
                <CommentList />
      </div>
        );
    }
});
ReactDOM.render(
    <CommentBox />,
    document.getElementById('content')
);




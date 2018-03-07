
// from this tutorial:
// https://reactjs.net/getting-started/tutorial.html

var CommentBox = React.createClass({
    render: function () {
        return (
            <div className="commentBox">
                Hello, world! I am a CommentBox.
      </div>
        );
    }
});
ReactDOM.render(
    <CommentBox />,
    document.getElementById('content')
);




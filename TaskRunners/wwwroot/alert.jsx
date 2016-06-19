var Alert = React.createClass({
    render: function () {
        return (
            <div>{this.props.message}</div>
        );
    }
});

React.render(<Alert message="Hello SDP"/>, document.body, callback);
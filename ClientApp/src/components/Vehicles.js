import React, { Component } from 'react';

export class Vehicles extends Component {
    static displayName = Vehicles.name;

    constructor(props) {
        super(props);
        //this.state = { currentCount: 0 };
        //this.incrementCounter = this.incrementCounter.bind(this);
    }


    render() {
        return (
            <div>
                <h1>Vehicles</h1>
                <p>This is a simple example of a React component.</p>
            </div>
        );
    }
}
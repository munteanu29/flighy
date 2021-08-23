import React, { Component } from 'react';
import "../MainPage/MainPage.css";

class MainPage extends Component {
    render() {
        return (
            <div>
                <div></div>
                <div className="col-md-4">
                    <div className="mainButtons">
                        <button className="mainButton"> Marketplace </button>
                        <button className="mainButton"> Artisti </button>
                    </div>
                </div>
                <div></div>
            </div>
        );
    }
}

export default MainPage;
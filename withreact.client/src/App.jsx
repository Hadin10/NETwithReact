import { useEffect, useState } from 'react';
import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import 'bootstrap/dist/js/bootstrap.bundle.min.js';


function App() {
    let allName;
    useEffect(() => {
        allpicturedata();
    }, []);
    let location = "";
    <div className="row">
        {allName.map((name, index) => {
            location = `/Media/${name}`;
            return (
                <div className="row" key={index}>
                    <div className="card">
                        <div className="card-body">
                            <h1 id="tableLabel">{name}</h1>
                            <img src={location} className="img-fluid" alt={name} />
                        </div>
                    </div>
                </div>
            );
        })}
    </div>


    async function allpicturedata() {
        const response = await fetch('dashboard/getallpicturedata');
        const data = await response.json();        
        if (data.success) {
            allName = data.data;
        }
        console.log(allName);
    }
}

export default App;
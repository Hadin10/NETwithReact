import { useEffect, useState } from 'react';
import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import 'bootstrap/dist/js/bootstrap.bundle.min.js';


function App() {
    const [allName, setallName] = useState([]);
    let location = "";
    useEffect(() => {
        allpicturedata();
    }, []);

    async function allpicturedata() {
        const response = await fetch('dashboard/getallpicturedata');
        const data = await response.json();
        if (data.success) {
            setallName(data.data);
        }
    }

    return (
        <div className="row">          
            {allName.map((item, index) => {
                location = `/Media/${item.name}`;
                return (
                    <div className="col-md-3" key={index}>
                        <div className="card mb-3">
                            <div className="card-body">
                                <h1 id="tableLabel">{item.title}</h1>
                                <img src={location} className="img-fluid" alt="..." />
                                <p>{item.description}</p>
                            </div>
                        </div>
                    </div>
                );
            })}
        </div>
    );
}

export default App;
import { useEffect, useState } from 'react';
import { useNavigate, Routes, Route } from 'react-router-dom';
import './App.css';
import ProductDetails from './ProductDetailes.jsx';



function App() {
    return (
        <Routes>
            <Route path="/" element={<Dashboard />} />
            <Route path="/product/:id" element={<ProductDetails />} />
        </Routes>
    );
}
function Dashboard() {
    const [allName, setallName] = useState([]);
    let location = "";
    const navigate = useNavigate();
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
    function handleClick(id) {
        navigate(`/product/${id}`);
    }
    return (
        <div className="row">          
            {allName.map((item, index) => {
                location = `/Media/${item.name}`;
                return (
                    <div className="col-md-3" key={index} onClick={() => handleClick(item.id)}>
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
import { useParams } from 'react-router-dom';
import { useEffect, useState } from 'react';
import { useNavigate, Routes, Route } from 'react-router-dom';
function ProductDetails() {
    const { id } = useParams();
    const [product, setProduct] = useState([]);
    const navigate = useNavigate();
    useEffect(() => {
        picturedetailes();
    }, []);

    async function picturedetailes() {
        const response = await fetch(`/dashboard/getpicturedetailesdata?id=${id}`);
        const data = await response.json();
        if (data.success) {
            setProduct(data.data);
        }
    }
    let location = `/Media/${product.name}`;
    return (
        <div className="container mt-5">
            <div className="card">
                <h2>{product.title}</h2>
                <img src={location} className="img-fluid" style={{ maxHeight: "500px" }} alt="..." />
            </div>            
            <p>{product.description}</p>
        </div>
    );
}

export default ProductDetails;

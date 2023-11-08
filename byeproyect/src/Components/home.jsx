import React, { useState, useEffect } from 'react';

const Home = () => {
    const [productos, setProductos] = useState([]);
    const [carrito, setCarrito] = useState([]);

    useEffect(() => {
        // llenar el array para emular datos
        const productosArray = [];
        productos.push( new Producto("Producto 1", "Descripción del producto 1", 99.99, "/BYE/Images/Img1.jpg",10));
        productos.push( new Producto("Producto 2", "libny te amo", 79.99, "/BYE/Images/Img2.jpg",8));
        productos.push( new Producto("Producto 2", "libny te amo", 79.99, "/BYE/Images/Img3.jpg",8));
        productos.push( new Producto("Producto 2", "libny te amo", 79.99, "/BYE/Images/Img4.jpg",8));
        productos.push( new Producto("Producto 2", "libny te amo", 79.99, "/BYE/Images/Img5.jpg",8));
        productos.push( new Producto("Producto 2", "libny te amo", 79.99, "/BYE/Images/Img6.jpg",8));
        productos.push( new Producto("Producto 2", "libny te amo", 79.99, "/BYE/Images/Img7.jpg",8));
        productos.push( new Producto("Producto 2", "libny te amo", 79.99, "/BYE/Images/Img8.jpg",8));
        productos.push( new Producto("Producto 2", "libny te amo", 79.99, "/BYE/Images/Img9.jpg",8));
        productos.push( new Producto("Producto 2", "libny te amo", 79.99, "/BYE/Images/Img10.jpg",8));

        setProductos(productosArray);
    }, []);


    return (
        <div className="container_Products" id="productosContainer">
            {/* Itera sobre los productos y renderiza cada uno */}
            {productos.map((producto, index) => (
                <div key={index} className="product-card">
                    <img src={producto.imagenURL} alt="" />
                    <div className="product-info">
                        <div>
                            <p className="card-title">{producto.nombre}</p>
                            <p className="card-text">{producto.descripcion}</p>
                            <p className="card-text">{producto.precio.toFixed(2)}</p>
                            <div className="cantidad">
                                <p className="card-text">cantidad:</p>
                                <p className="card-text">{producto.cantidad}</p>
                            </div>
                        </div>
                        <figure>
                            <buttonnpm
                                className="btn btn-primary"
                                onClick={() => agregarAlCarrito(producto)}
                            >
                                Agregar al carrito
                            </buttonnpm>
                        </figure>
                    </div>
                </div>
            ))}
        </div>
    );
};

export default Home;
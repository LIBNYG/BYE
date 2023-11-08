import React from 'react';

const Producto = ({ producto }) => {
    return (
        <div className="product-card">
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
                    <button className="btn btn-primary" id="addToCartButton">
                        Agregar al carrito
                    </button>
                </figure>
            </div>
        </div>
    );
};

export default Producto;

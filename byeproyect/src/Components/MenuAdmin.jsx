import React from 'react';

const MenuAdmin = () => {
    return (
        <div>
            <nav className="navbar navbar-expand-lg navbar-light bg-light">
                <ul className="navbar-nav">
                    <li className="nav-item">
                        <a className="nav-link" href="#">Inventario</a>
                    </li>
                    <li className="nav-item">
                        <a className="nav-link" href="#">Historial de Compras</a>
                    </li>
                    <li className="nav-item">
                        <a className="nav-link" href="#">Generar Registro de Ventas</a>
                    </li>
                </ul>
            </nav>
        </div>
    );
};

export default MenuAdmin;

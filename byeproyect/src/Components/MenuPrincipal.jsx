import React from 'react';

const MenuPrincipal = () => {
    return (
        <nav className="navbar navbar-expand-lg navbar-light bg-light">
            <div className="busqueda_container">
                <form className="form-inline">
                    <input className="form-control mr-sm-2" type="search" placeholder="Buscar productos" aria-label="Search" />
                    <button className="btn btn-outline-success my-2 my-sm-0" type="submit">Buscar</button>
                </form>
            </div>
            <ul className="navbar-nav ml-auto">
                <li className="nav-item dropdown">
                    <a className="nav-link dropdown-toggle" href="#" id="navbarDropdownMenuLink" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                        Perfil
                    </a>
                    <div className="dropdown-menu" aria-labelledby="navbarDropdownMenuLink">
                        <a className="dropdown-item" href="CreateAccount.html">Editar Perfil</a>
                        <a className="dropdown-item" href="ChangePassword.html">Cambiar Contraseña</a>
                    </div>
                </li>
                <li className="nav-item">
                    <a className="nav-link" href="ShoppingCart.html">Carrito</a>
                </li>
                <li className="nav-item">
                    <a className="nav-link" href="Orders.html">Historial de Compras</a>
                </li>
                <li className="nav-item">
                    <a className="nav-link" href="admin.html">Configuración</a>
                </li>
                <li className="nav-item">
                    <a className="nav-link" href="login.html">Cerrar Sesión</a>
                </li>
            </ul>
        </nav>
    );
};

export default MenuPrincipal;

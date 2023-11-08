import React from 'react';

const Registro = () => {
    return (
        <div>
            <nav className="navbar navbar-expand-lg navbar-light bg-light">
                <a className="navbar-brand" href="#">BYE</a>
                <button className="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                    <span className="navbar-toggler-icon"></span>
                </button>
                <div className="collapse navbar-collapse" id="navbarNav">
                    <ul className="navbar-nav">
                        <li className="nav-item active">
                            <a className="nav-link" href="index.html">Inicio</a>
                        </li>
                        <li className="nav-item">
                            <a className="nav-link" href="login.html">Iniciar Sesión</a>
                        </li>
                        <li className="nav-item">
                            <a className="nav-link" href="logup.html">Registrarse</a>
                        </li>
                    </ul>
                </div>
            </nav>
            <nav className="navbar navbar-expand-lg navbar-light bg-light">
            </nav>

            <div className="container mt-5">
                <h2>Registrarse</h2>
                <form>
                    <div className="form-row">
                        <div className="form-group col-md-6">
                            <label htmlFor="firstName">Nombre:</label>
                            <input type="text" className="form-control" id="firstName" placeholder="Nombre" />
                        </div>
                        <div className="form-group col-md-6">
                            <label htmlFor="lastName">Apellidos:</label>
                            <input type="text" className="form-control" id="lastName" placeholder="Apellidos" />
                        </div>
                    </div>
                    <div className="form-group">
                        <label htmlFor="email">Correo Electrónico:</label>
                        <input type="email" className="form-control" id="email" placeholder="Ingrese su correo electrónico" />
                    </div>
                    <div className="form-group">
                        <label htmlFor="password">Contraseña:</label>
                        <input type="password" className="form-control" id="password" placeholder="Contraseña" />
                    </div>
                    <div className="form-group">
                        <label htmlFor="confirmPassword">Confirmar Contraseña:</label>
                        <input type="password" className="form-control" id="confirmPassword" placeholder="Confirmar contraseña" />
                    </div>
                    <div className="form-group">
                        <label htmlFor="address">Dirección:</label>
                        <input type="text" className="form-control" id="address" placeholder="Dirección" />
                    </div>
                    <button type="submit" className="btn btn-primary">Registrarse</button>
                </form>
                <p>¿Ya tienes una cuenta? <a href="login.html">Iniciar Sesión</a></p>
            </div>
        </div>
    );
};

export default Registro;

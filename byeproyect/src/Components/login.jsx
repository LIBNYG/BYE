import React, { useState } from 'react';

const Login = () => {
    const [email, setEmail] = useState("");
    const [password, setPassword] = useState("");

    const validarFormulario = () => {
        if (email.trim() === "" || password.trim() === "") {
            alert("Por favor, complete todos los campos.");
            return;
        }

        // Validar el formato del correo electrónico utilizando una expresión regular simple
        const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
        if (!emailRegex.test(email)) {
            alert("El correo electrónico no tiene un formato válido.");
            return;
        }

        alert("Formulario válido. ¡Iniciando sesión!");
        // Aquí puedes redirigir a la página deseada en tu aplicación de React
        // Puedes usar useHistory de react-router-dom o cualquier otra lógica de enrutamiento que estés utilizando
        // Ejemplo: history.push("/home");
    };

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

            <div className="container mt-5">
                <h2>Iniciar Sesión</h2>
                <form id="loginForm">
                    <div className="form-group">
                        <label htmlFor="email">Correo Electrónico:</label>
                        <input type="email" className="form-control" id="email" placeholder="Ingrese su correo electrónico" />
                    </div>
                    <div className="form-group">
                        <label htmlFor="password">Contraseña:</label>
                        <input type="password" className="form-control" id="password" placeholder="Contraseña" />
                    </div>
                    <a href="forgot_password.html">¿Olvidó su contraseña?</a>
                    <button type="button" className="btn btn-primary" onClick={validarFormulario}>Iniciar Sesión</button>
                </form>
                <p>¿No tienes una cuenta? <a href="logup.html">Regístrate</a></p>
            </div>
        </div>
    );
};

export default Login;

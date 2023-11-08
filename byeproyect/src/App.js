import React from 'react';
import { BrowserRouter as Router, Route, Switch } from 'react-router-dom';
import Login from './Components/login';
const App = () => {
  return (
    <Router>
      <div>
        <Switch>
          <Route exact path="/" component={Login} /> {}
        </Switch>
      </div>
    </Router>
  );
};

export default App;
import { Container } from "semantic-ui-react";
import NavBar from "./NavBar";
import { observer } from "mobx-react-lite";
import { Outlet, useLocation } from "react-router-dom";
import HomePage from "../../features/home/HomePage";

// TODO: figure out why it is trying to re-create every activity whenever you click any buttons

function App() {
  const location = useLocation();

  return (
    // could also use Fragment 
     <> 
     {location.pathname === '/' ? <HomePage /> : (
      <>
        <NavBar />
        <Container style={{marginTop: '7em'}}>
          <Outlet />
        </Container>
      </>
     )}
    </>
  );
}

export default observer(App);

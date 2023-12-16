import DuckItem from "./DuckItem";
import { ducks } from "./Ducks";

function App() {
  return (
    <div>
      <h1>React-ivities</h1>
      {ducks.map(duck => (
        <DuckItem key={duck.name} duck={duck}/>
      ))}
    </div>
  );
}

export default App;

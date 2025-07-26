import { CalculateScore } from './Components/CalculateScore';

function App() {
  return (
    <div>
      <CalculateScore 
        Name={"Arnob Chakraborty"} 
        School={"KIIT"} 
        total={284} 
        goal={3} 
      />
    </div>
  );
}

export default App;

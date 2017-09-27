namespace CarbuilderConsoleApp
{
    internal class Engine: Part
    {
        private int Qubic;
        //private object cost;

        public Engine(int qubic, decimal cost):base(cost)
        {
            this.Qubic = qubic;
            //this.cost = cost;
        }
    }
}
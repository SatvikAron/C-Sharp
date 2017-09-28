namespace GrandTotal_StudentConsoleApp
{
    internal class Class: NumberofStudents
    {
        private string Name;
        //public int Total;

        public Class(string name, int total):base(total)
        {
            this.Name = name;
            //this.Total = total;
        }
    }
}
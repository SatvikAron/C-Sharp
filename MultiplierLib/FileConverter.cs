using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplierLib
{
     public class FileConverter
    {
        public string Transfer(string row)
        {
            string[] tokens = row.Split(';');
            var firstName = tokens[0].ToUpper();
            var lastNmae = tokens[1].ToUpper();
            var years =DateTime .Now.Year-int.Parse(tokens[2]);
            var message =$"{ firstName} {lastNmae} {years} ÅR GAMMAL";
            return message;
        }
        public void TransferFile(string inputName, string outputName)
        {
            StringWriter sw = new StringWriter();
            string[] lines = File.ReadAllLines(inputName);
            foreach (var item in lines)
            {
                sw.WriteLine(Transfer(item));
            }
            sw.Close();
            File.WriteAllText(outputName, sw.ToString());
        }
    }
}

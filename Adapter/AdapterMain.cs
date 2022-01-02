using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Adapter
{
    class AdapterMain
    {
        public void Run()
        {
            // Skriv en adapter för ReturningStrings som kan konsumeras av PrintingInts           
            ReturningStrings returningStrings = new();
            PrintingInts printingInts = new();
            
            int tempstorage = int.Parse(returningStrings.ReturnString());
            printingInts.Print(tempstorage);
        }
    }
}

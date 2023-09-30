using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.models;

 static class DATABASE
{
    
    static public List<Worker> workers = new List<Worker>() { new Worker("Leman", "Ismanli", "Baku", "+995516538408", 25, "leman@gmail.com", "Leman-1234",
        new CV("IT", "TDV-BTL", 658, "Programming", "None", "English", "None", "gitlink", "linkedin")) };
    static public List<Employer> employers = new List<Employer>() { new Employer("Ilknur", "Memmedova", "Baku",
        "+994555555555",30, "ilknur@gmail.com", "Ilknur-1234") };

    
}

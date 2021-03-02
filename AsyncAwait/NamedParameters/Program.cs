using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedParameters
{
    class Program
    {
        public static void GetCohortDetails(string Cohortname,int Genccount, string Mode,string Track,string Currentmodule)
        {
            Console.WriteLine("It is {0} with {1} Gencs undergoing training for {3} thru {2}. The current module of training is {4}",Cohortname,Genccount,Mode,Track,Currentmodule);
        }
        static void Main(string[] args)
        {
            GetCohortDetails("ADM", 21, "JAVA", "PARC", "Stage 3");
            GetCohortDetails(Mode: "PARC", Track: "JAVA", Currentmodule: "Stage 3", Cohortname: "ADM", Genccount: 21);
            Console.ReadLine();

        }
    }
}

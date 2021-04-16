using System;

namespace RepoPattern
{
    class Sample
    {
        Guid Id
        {
            get { return Id; }
            set { Id = value; }
        }

        string DnaSequence
        {
            get { return DnaSequence; }
            set { DnaSequence = value; }
        }

        DateTime AnalysisTime;
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

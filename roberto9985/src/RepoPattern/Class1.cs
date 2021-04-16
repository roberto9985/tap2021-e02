using System;
using System.Collections.Generic;
using System.Text;

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

        public Boolean IsValidDnaSequence(String DnaSequence)
        {
            if (DnaSequence.Length == 1000){
                for ( int i=0; i<DnaSequence.Length; i++)
                {
                    if (DnaSequence[i] != 'A' || DnaSequence[i] != 'C' || DnaSequence[i] != 'G' || DnaSequence[i] != 'T') return false;
                        
                }
            }
            return true;
        }


    }
}

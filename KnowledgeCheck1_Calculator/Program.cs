using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    public class Program
    {

        static void Main(string[] args)
        {
            Processor processor = new Processor();

            //If the user entered valid data, continue operations
            //If the user enters invalid data, skip operations and reset processor
            if (processor.SelectOperator() && processor.SelectOperands())
            {
                processor.Operate();
                processor.DisplayProblem();
                processor.DisplayAnswer();
                processor.Reset();
            }
            else processor.Reset();
        }
    }
}

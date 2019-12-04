using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DesignPatternDemo.Operator;

namespace DesignPatternDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<string> concreteOperators = GetConcreteOperators();

            Parallel.ForEach(concreteOperators, current => { CallOperator(current); });

            foreach (string operatorName in concreteOperators)
            {
                Task concreteTask = new Task(() => { CallOperator(operatorName); });
                concreteTask.Start();
            }

            Console.ReadKey();
        }
        private static List<string> GetConcreteOperators()
        {
            List<string> concreteOperators = new List<string>
            {
                nameof(AOperator),
                nameof(BOperator),
                nameof(COperator),
                nameof(DOperator),
                nameof(EOperator)
            };
            return concreteOperators;
        }

        private static void CallOperator(string operatorName, params string[] operatorParams)
        {
            AuxiliaryToolSingleton auxiliaryTool = AuxiliaryToolSingleton.Instance;
            auxiliaryTool.CallOperator(operatorName, operatorParams);
        }
    }
}
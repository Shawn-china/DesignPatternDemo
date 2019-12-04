using System;
using System.Threading;
using DesignPatternDemo.Operator;

namespace DesignPatternDemo
{
    public class AuxiliaryToolSingleton
    {
        public static Semaphore OperatorSemaphore = new Semaphore(1, 1);
        private static readonly object OperatorLock = new object();

        public static AuxiliaryToolSingleton Instance = new AuxiliaryToolSingleton();
        private AuxiliaryToolSingleton()
        {
            RegistorOperator(OperatorFactory.Instance);
        }

        public void CallOperator(string operatorName, params string[] operatorParams)
        {
            //OperatorSemaphore.WaitOne();
            lock (OperatorLock)
            {
                Console.WriteLine($"Call method CallOperator :{operatorName} .Current Thread:{Thread.CurrentThread.ManagedThreadId}");

                BaseOperator concreteOperator = OperatorFactory.Instance.GetOperator(operatorName);
                concreteOperator.InitializationParameters(operatorParams);
                concreteOperator.Execute();
            }

            //OperatorSemaphore.Release();
        }

        public static void RegistorOperator(OperatorFactory factory)
        {
            factory.Register(nameof(AOperator), new AOperator());
            factory.Register(nameof(BOperator), new BOperator());
            factory.Register(nameof(COperator), new COperator());
            factory.Register(nameof(DOperator), new DOperator());
            factory.Register(nameof(EOperator), new EOperator());
        }
    }
}
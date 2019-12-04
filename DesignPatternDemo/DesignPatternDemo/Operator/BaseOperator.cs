using System;
using System.Threading;

namespace DesignPatternDemo.Operator
{
    public class BaseOperator
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public void Execute()
        {
            //ToDo
            Thread.Sleep(new Random().Next(0, 5) * 1000);
            Console.WriteLine($"Execute concrete operator:{GetType().Name} .Current Thread:{Thread.CurrentThread.ManagedThreadId}");
            ConcreteOperate($"{GetType().Name}");
        }
        public void InitializationParameters(params string[] operatorParams)
        {
            //ToDo

            Console.WriteLine($"Initialization Parameters :{GetType().Name}");
        }
        private void ConcreteOperate(string mark)
        {
            // ToDo
            Console.WriteLine($"The concrete operation :{mark} was performed successfully .\r\n");
        }
        public virtual void ClickButtonByMark(string mark)
        {
            // ToDo
            ConcreteOperate(mark);
        }

        public virtual void ClickPopupMenuByMark(string mark)
        {
            // ToDo
            ConcreteOperate(mark);
        }

        public virtual void SelectDropdownBoxByIndex(int dropBoxIndex)
        {
            // ToDo
            ConcreteOperate($"{dropBoxIndex}");
        }
    }
}
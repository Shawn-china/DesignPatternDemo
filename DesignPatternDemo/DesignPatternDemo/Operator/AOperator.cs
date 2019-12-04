using System;

namespace DesignPatternDemo.Operator
{
    public class AOperator : BaseOperator, ISpecialOperateA
    {
        public void SetContent(string content)
        {
            //ToDo
            Console.WriteLine($"Filled the content:{content} successfully");
        }
        public string GetContent()
        {
            //ToDo
            return $"{new Random().Next()}{Guid.NewGuid()}";
        }
    }
}
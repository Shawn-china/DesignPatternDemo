using System;

namespace DesignPatternDemo.Operator
{
    public class EOperator : BaseOperator, ISpecialOperateE
    {
        public void ClickTreeviewByMark(string mark)
        {
            //ToDo
            Console.WriteLine($"{mark}: execution succeed");
        }
    }
}
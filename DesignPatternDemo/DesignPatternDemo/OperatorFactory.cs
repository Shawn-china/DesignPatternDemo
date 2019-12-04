using DesignPatternDemo.Operator;

namespace DesignPatternDemo
{
    public class OperatorFactory : Factory<OperatorFactory, BaseOperator>
    {
        public BaseOperator GetOperator(string operatorName)
        {
            return GetItem(operatorName);
        }
    }
}
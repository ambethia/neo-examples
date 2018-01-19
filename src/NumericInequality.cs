using Neo.SmartContract.Framework.Services.Neo;

namespace Neo.SmartContract
{
    public class NumericInequality : Framework.SmartContract
    {
        public static bool Main(int a)
        {
            return a != a / 2;
        }
    }
}

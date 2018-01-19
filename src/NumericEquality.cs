using Neo.SmartContract.Framework.Services.Neo;

namespace Neo.SmartContract
{
    public class NumericEquality : Framework.SmartContract
    {
        public static bool Main(int a)
        {
            int b = a * 2 / 2;
            return a == b;
        }
    }
}

using Neo.SmartContract.Framework.Services.Neo;

namespace Neo.SmartContract
{
    public class LessThan : Framework.SmartContract
    {
        public static bool Main(int a, int b)
        {
            return a < b;
        }
    }
}

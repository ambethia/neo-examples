using Neo.SmartContract.Framework.Services.Neo;

namespace Neo.SmartContract
{
    public class MethodCall : Framework.SmartContract
    {
        public static bool Main(int n)
        {
            return Even(n);
        }

        public static bool Even(int n)
        {
            return n % 2 == 0;
        }
    }
}

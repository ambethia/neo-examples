using Neo.SmartContract.Framework.Services.Neo;

namespace Neo.SmartContract
{
    public class Negate : Framework.SmartContract
    {
        public static int Main(int a)
        {
            return -a;
        }
    }
}

using Neo.SmartContract.Framework.Services.Neo;

namespace Neo.SmartContract
{
    public class Increment : Framework.SmartContract
    {
        public static int Main(int a)
        {
            return ++a;
        }
    }
}

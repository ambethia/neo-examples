using Neo.SmartContract.Framework.Services.Neo;

namespace Neo.SmartContract
{
    public class Decrement : Framework.SmartContract
    {
        public static int Main(int a)
        {
            return --a;
        }
    }
}

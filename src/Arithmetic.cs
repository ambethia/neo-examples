using Neo.SmartContract.Framework.Services.Neo;

namespace Neo.SmartContract
{
    public class Arithmetic : Framework.SmartContract
    {
        public static int Main()
        {
            return (4 + 8 - 15 * 16 / 23) * 42;
        }
    }
}

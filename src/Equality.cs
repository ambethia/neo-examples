using Neo.SmartContract.Framework.Services.Neo;

namespace Neo.SmartContract
{
    public class Equality : Framework.SmartContract
    {
        public static bool Main()
        {
            return 42.Equals(21 * 2);
        }
    }
}

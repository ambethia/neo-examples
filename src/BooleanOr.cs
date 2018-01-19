using Neo.SmartContract.Framework.Services.Neo;

namespace Neo.SmartContract
{
    public class BooleanOr : Framework.SmartContract
    {
        public static bool Main(bool a, bool b)
        {
            return a || b;
        }
    }
}

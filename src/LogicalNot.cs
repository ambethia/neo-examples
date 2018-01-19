using Neo.SmartContract.Framework.Services.Neo;

namespace Neo.SmartContract
{
    public class LogicalNot : Framework.SmartContract
    {
        public static bool Main()
        {
            return !true;
        }
    }
}

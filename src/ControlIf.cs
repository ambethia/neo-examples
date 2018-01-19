using Neo.SmartContract.Framework.Services.Neo;

namespace Neo.SmartContract
{
    public class ControlIf : Framework.SmartContract
    {
        public static int Main(bool x)
        {
            if (x)
            {
                return 42;
            }
            return 666;
        }
    }
}

using Neo.SmartContract.Framework.Services.Neo;

namespace Neo.SmartContract
{
    public class ControlIfElse : Framework.SmartContract
    {
        public static int Main(int a)
        {
            if (a % 2 == 0)
            {
                return a * 2;
            }
            else
            {
                return a / 2;
            }
        }
    }
}

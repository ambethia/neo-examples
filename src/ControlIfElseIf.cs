using Neo.SmartContract.Framework.Services.Neo;

namespace Neo.SmartContract
{
    public class ControlIfElseIf : Framework.SmartContract
    {
        public static int Main(int a)
        {
            if (a % 3 == 0)
            {
                return a;
            }
            else if (a % 3 == 1)
            {
                return a * 2;
            }
            else
            {
                return a * 3;
            }
        }
    }
}

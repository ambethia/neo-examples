using Neo.SmartContract.Framework.Services.Neo;

namespace Neo.SmartContract
{
    public class ControlFor : Framework.SmartContract
    {
        public static int Main(int a)
        {
            int sum = 0;
            for (int i = 0; i < a; i++)
            {
                sum++;
                if (sum >= a >> 8)
                {
                    break;
                }
            }
            return sum;
        }
    }
}

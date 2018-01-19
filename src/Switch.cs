using Neo.SmartContract.Framework.Services.Neo;

namespace Neo.SmartContract
{
    public class Switch : Framework.SmartContract
    {
        public static int Main(int a)
        {
            int m = a % 4;
            switch (m)
            {
                case 0:
                case 2:
                    m = m / 2;
                    break;
                default:
                    m = m * 2;
                    break;
            }
            return m;
        }
    }
}

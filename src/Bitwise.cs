using Neo.SmartContract.Framework.Services.Neo;

namespace Neo.SmartContract
{
    public class Bitwise : Framework.SmartContract
    {
        public static int Main(int a, int b)
        {
            int j = a & b;
            int q = j | b;
            int m = a ^ q;
            return m;
        }
    }
}

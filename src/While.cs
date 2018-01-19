using Neo.SmartContract.Framework.Services.Neo;

namespace Neo.SmartContract
{
    public class While : Framework.SmartContract
    {
        public static int Main(int a)
        {
            int i = 0;
            int n = a >> 8;
            
            while (i < n)
            {
                i++;
            }
            return i;
        }
    }
}

using Neo.SmartContract.Framework.Services.Neo;

namespace Neo.SmartContract
{
    public class Fibonacci : Framework.SmartContract
    {
        public static int Main(int n)
        {
            return Fibb(n);
        }

        public static int Fibb(int n)
        {   
            if (n == 1 || n == 2) return 1;
            int fibM1 = Fibb(n - 1);
            int fibM2 = Fibb(n - 2);
            return fibM1 + fibM2;
        }
    }
}

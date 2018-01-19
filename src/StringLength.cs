using Neo.SmartContract.Framework.Services.Neo;

namespace Neo.SmartContract
{
    public class StringLength : Framework.SmartContract
    {
        public static int Main(string str)
        {
            return str.Length;
        }
    }
}

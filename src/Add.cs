using Neo.SmartContract.Framework.Services.Neo;

namespace Neo.SmartContract
{
  public class Add : Framework.SmartContract
  {
      public static int Main(int a, int b)
      {
        return a + b;
      }
  }
}

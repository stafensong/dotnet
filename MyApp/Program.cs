using System.Runtime.InteropServices;
namespace NetCore
{
  public class Program 
  {
      [DllImport(@"MyNativeLibrary\build\Release\MyNativeLibrary.dll", EntryPoint = 
       "add", CallingConvention = CallingConvention.StdCall)]
     public static extern int Add(int a, int b);
     public static void Main(string[] args)
     {
        int result = Add(1 ,2);
        Console.WriteLine("result is {0}", result);
        Console.ReadKey();
      }
   }
}
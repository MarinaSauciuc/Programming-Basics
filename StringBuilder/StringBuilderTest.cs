using System.Text;

namespace StringBuildTest


{
    internal class StringBuilderTest
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Holla ");
            sb.AppendLine("Hello!");
            sb.Append("How are you");
            sb.Append("Testing");
            sb.AppendFormat("ss");
            Console.WriteLine(sb);
        }
    }
}
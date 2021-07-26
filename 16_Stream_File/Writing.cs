using System.IO;
using System.Text;

namespace CodeBlogCsh
{
    static public class Writing
    {

        static public void WriteTofile(string fileName, string str)
        {
            using (var sw = new StreamWriter(fileName, true, Encoding.UTF8))
            {

                sw.WriteLine(str);

            }

        }


    }
}

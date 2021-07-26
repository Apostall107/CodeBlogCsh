using System.IO;

namespace CodeBlogCsh
{
    static public class Reading
    {
        static public void ReadFile(string fileName)
        {
            using (var sr = new StreamReader(fileName))
            {

                string text = sr.ReadToEnd();
                System.Console.WriteLine(text);


            }
        }
    }
}



namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "hello";

            ForFile forFile = new ForFile();

            forFile.CreateOrWriteFile(path, "Qande");
        }
    }
    class ForFile
    {
        public void OpenFile(string path)
        {
            for (int i = 1; i <= 10; i++)
            {
                File.Open(path + $"{i}.txt", FileMode.CreateNew);
            }
            Console.WriteLine("File yaratildi");
        }
        public void CreateOrWriteFile(string path, string text)
        {
            for (int i = 1; i <= 10; i++)
            {
                File.WriteAllText(path + $"{i}.txt", text);
            }
            Console.WriteLine("Filega yozildi");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    public class MockingExample
    {
        private readonly IFileWriter _writer;

        public MockingExample(IFileWriter writer)
        {
            _writer = writer;
        }

        public string TestMeMethod(string content)
        {
            _writer.WriteToFile(content);

            return content;
        }
    }

    public class FileWriter : IFileWriter
    {
        public void WriteToFile(string content)
        {
            System.IO.File.WriteAllText(@"c:\temp\testfile.txt", content);
        }
    }

    public interface IFileWriter
    {
        void WriteToFile(string content);
    }
}

using System;
using System.Collections.Generic;

namespace CSharpGenericsAndCollections._TheProblem
{
    public class Writer
    {
        public List<string> LogLines { get; set; } = new List<string>();

        public void Write(int value)
        {
            LogLines.Add("This is the value: " + value);
        }

        public void Write(decimal value)
        {
            LogLines.Add("This is the value: " + value);
        }

        public void Write(double value)
        {
            LogLines.Add("This is the value: " + value);
        }

        public void Write(string value)
        {
            LogLines.Add("This is the value: " + value);
        }

        public void Write(bool value)
        {
            LogLines.Add("This is the value: " + value);
        }
    }
}

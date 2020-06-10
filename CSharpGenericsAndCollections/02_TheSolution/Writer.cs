using System;
using System.Collections.Generic;

namespace CSharpGenericsAndCollections._TheSolution
{
    public class Writer
    {
        public List<string> LogLines { get; set; } = new List<string>();

        public void Write<T>(T value)
        {
            LogLines.Add("This is the value: " + value);
        }
    }
}

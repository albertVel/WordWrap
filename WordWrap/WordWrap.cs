using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordWrapNamespace
{
    public class WordWrap
    {
        public string WordWrapString(string text, int width)
        {
            var temp = string.Empty;

            if (width >= text.Length)
            {
                temp = text;
            }
            else
            {
                temp = text.Replace(' ', '\n');
            }

            return temp;
        }
    }
}

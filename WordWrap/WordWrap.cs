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
            var temp = text;

            if (width < text.Length)
            {
                var cuttingPoint = text.LastIndexOf(" ");
                if (cuttingPoint != -1)
                {
                    var wrappedText = text.Substring(cuttingPoint).Trim();
                    var remainingText = text.Substring(0, cuttingPoint);
                    return this.WordWrapString(remainingText, width) + "\n" + wrappedText;
                }
            }

            return temp;
        }
    }
}

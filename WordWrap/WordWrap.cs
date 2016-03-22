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

            if (this.TextDoNotFit(text, width))
            {
                var cuttingPoint = text.LastIndexOf(" ");
                if (cuttingPoint != -1)
                {
                    return this.WrapWord(cuttingPoint, text, width);
                }
                else
                {
                    if (this.TextDoNotFit(text, width))
                    {
                        var cuttingPointTextNoSpaces = text.Length - width;

                        return this.WrapWord(cuttingPointTextNoSpaces, text, width);
                    }
                }
            }

            return temp;
        }

        private string WrapWord(int cuttingPoint, string text, int width)
        {
            var wrappedText = text.Substring(cuttingPoint).Trim();
            var remainingText = text.Substring(0, cuttingPoint);
            return this.WordWrapString(remainingText, width) + "\n" + wrappedText;
        }

        private bool TextDoNotFit(string text, int width)
        {
            return width < text.Length;
        }
    }
}

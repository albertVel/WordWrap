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
                    var wrappedText = text.Substring(cuttingPoint).Trim();
                    var remainingText = text.Substring(0, cuttingPoint);
                    return this.WordWrapString(remainingText, width) + "\n" + wrappedText;
                }
                else
                {
                    if (this.TextDoNotFit(text, width))
                    {
                        var cuttingPointTextNoSpaces = text.Length - width;

                        var wrappedText = text.Substring(cuttingPointTextNoSpaces).Trim();
                        var remainingText = text.Substring(0, cuttingPointTextNoSpaces);
                        return this.WordWrapString(remainingText, width) + "\n" + wrappedText;
                    }
                }
            }

            return temp;
        }

        private bool TextDoNotFit(string text, int width)
        {
            return width < text.Length;
        }
    }
}

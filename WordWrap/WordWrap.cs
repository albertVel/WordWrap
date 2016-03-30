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
                var cuttingPoint = FindCuttingPoint(text, width);
                if (cuttingPoint != -1)
                {
                    return this.WrapWord(cuttingPoint, text, width);
                }
                else
                {
                    if (this.TextDoNotFit(text, width))
                    {
                        var cuttingPointTextNoSpaces = width;

                        return this.WrapWord(cuttingPointTextNoSpaces, text, width);
                    }
                }
            }

            return temp;
        }

        private static int FindCuttingPoint(string text, int width)
        {
            int cuttingPoint = -1;
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsWhiteSpace(text[i]))
                {
                    if (i <= width)
                    {
                        cuttingPoint = i;
                    }
                }
            }
            return cuttingPoint;
        }

        private string WrapWord(int cuttingPoint, string text, int width)
        {
            var wrappedText = text.Substring(0, cuttingPoint);
            var remainingText = text.Substring(cuttingPoint).Trim();
            return wrappedText + "\n" + this.WordWrapString(remainingText, width);

        }

        private bool TextDoNotFit(string text, int width)
        {
            return width < text.Length;
        }
    }
}

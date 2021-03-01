using System;
using System.Collections.Generic;
using System.Linq;

namespace NFSRaider.Helpers
{
    public static class Extensions
    {
        public static IEnumerable<string> SplitBy(this string text, char[] splitBy, char escape, StringSplitOptions stringSplitOptions = StringSplitOptions.None)
        {
            var word = string.Empty;
            var listOfWords = new List<string>();
            var cancelNextEscape = false;
            for (int i = 0; i < text.Length; i++)
            {
                if (splitBy.Contains(text[i]))
                {
                    if (i > 0)
                    {
                        if (text[i - 1] == escape && !cancelNextEscape)
                        {
                            word = word.Substring(0, word.Length - 1);
                            word += text[i];
                        }
                        else
                        {
                            cancelNextEscape = false;
                            listOfWords.Add(word);
                            word = string.Empty;
                        }
                    }
                    else
                    {
                        listOfWords.Add(word);
                        word = string.Empty;
                    }
                }
                else
                {
                    if (i > 0)
                    {
                        if (text[i - 1] == escape && text[i] == escape)
                        {
                            cancelNextEscape = !cancelNextEscape;
                            if (cancelNextEscape)
                            {
                                word = word.Substring(0, word.Length - 1);
                            }
                        }
                        else if (!cancelNextEscape && text[i - 1] == escape)
                        {
                            word = word.Substring(0, word.Length - 1);
                        }
                        else if (cancelNextEscape)
                        {
                            cancelNextEscape = false;
                        }
                    }

                    word += text[i];
                }
            }

            listOfWords.Add(word);

            if (stringSplitOptions == StringSplitOptions.RemoveEmptyEntries)
                listOfWords = listOfWords.Where(s => !string.IsNullOrEmpty(s)).ToList();

            return listOfWords;
        }
    }
}

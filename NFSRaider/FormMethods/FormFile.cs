using NFSRaider.Enum;
using NFSRaider.GeneratedStrings;
using NFSRaider.Hash;
using NFSRaider.Helpers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NFSRaider.FormMethods
{
    public static class FormFile
    {
        public static uint[] Open(string txtStartOffset, string txtEndOffset, string txtReadHashes, string txtSkipHashes, string filePath)
        {
            var startOffset = Convert.ToInt64(txtStartOffset);
            var endOffset = Convert.ToInt64(txtEndOffset);
            var readHashes = Convert.ToInt32(txtReadHashes);
            var skipHashes = Convert.ToInt32(txtSkipHashes);

            var arrayFromFile = new FileRead().ReadFile(filePath, startOffset, endOffset);
            var arrayFromFileWithHashesSkipped = new List<uint>();

            var countHashesRead = 1;

            for (int i = 0; i < arrayFromFile.Length; i++)
            {
                arrayFromFileWithHashesSkipped.Add(arrayFromFile[i]);

                if (countHashesRead >= readHashes)
                {
                    i += skipHashes;
                    countHashesRead = 1;
                }
                else
                    countHashesRead++;
            }

            return arrayFromFileWithHashesSkipped.ToArray();
        }

        public static (List<(uint, string)> listBox, int knownHashes, int unknownHashes) UnhashFromFile(Endianness unhashingEndianness, HashFactory hashFactory, uint[] arrayFromFile)
        {
            var allParts = new AllStrings().ReadHashesFile(hashFactory);
            var listBox = new List<(uint, string)>();
            var knownHashes = 0;
            var unknownHashes = 0;

            if (unhashingEndianness == Endianness.BigEndian)
            {
                foreach (var hash in arrayFromFile)
                {
                    if (allParts.TryGetValue(hash, out var result))
                    {
                        knownHashes += 1;
                    }
                    else
                    {
                        if (hash == 0 || hash == uint.MaxValue)
                        {
                            knownHashes += 1;
                            result = "--------";
                        }
                        else
                        {
                            result = "HASH_UNKNOWN";
                            unknownHashes += 1;
                        }
                    }

                    listBox.Add((hash, result));
                }
            }
            else
            {
                uint hashReversed;
                foreach (var hash in arrayFromFile)
                {
                    hashReversed = hash.Reverse();

                    if (allParts.TryGetValue(hashReversed, out var result))
                    {
                        knownHashes += 1;
                    }
                    else
                    {
                        if (hashReversed == 0 || hashReversed == uint.MaxValue)
                        {
                            knownHashes += 1;
                            result = "--------";
                        }
                        else
                        {
                            result = "HASH_UNKNOWN";
                            unknownHashes += 1;
                        }
                    }

                    listBox.Add((hash, result));
                }
            }

            return (listBox, knownHashes, unknownHashes);
        }
    }
}

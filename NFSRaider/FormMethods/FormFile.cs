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

        public static List<RaiderResult> UnhashFromFile(Endianness unhashingEndianness, HashFactory hashFactory, uint[] arrayFromFile, CaseOptions caseOption)
        {
            var allStrings = new AllStrings().ReadHashesFile(hashFactory, caseOption);
            var listBox = new List<RaiderResult>();
            var isKnown = false;

            void AddResult(uint hash)
            {
                if (allStrings.TryGetValue(hash, out var result))
                {
                    isKnown = true;
                }
                else
                {
                    if (hash == 0 || hash == uint.MaxValue)
                    {
                        result = "--------";
                        isKnown = true;
                    }
                    else
                    {
                        result = "HASH_UNKNOWN";
                        isKnown = false;
                    }
                }

                listBox.Add(new RaiderResult() { Hash = hash, Value = result, IsKnown = isKnown });
            }

            if (unhashingEndianness == Endianness.BigEndian)
            {
                foreach (var hash in arrayFromFile)
                {
                    AddResult(hash);
                }
            }
            else
            {
                foreach (var hash in arrayFromFile)
                {
                    AddResult(hash.Reverse());
                }
            }

            return listBox;
        }
    }
}

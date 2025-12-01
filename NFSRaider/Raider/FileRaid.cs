using NFSRaider.Case;
using NFSRaider.Consts;
using NFSRaider.Enums;
using NFSRaider.Hash;
using NFSRaider.Helpers;
using NFSRaider.Keys;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace NFSRaider.Raider
{
    public static class FileRaid
    {
        public static uint[] Open(string txtStartOffset, string txtEndOffset, string txtReadHashes, string txtSkipHashes, string filePath)
        {
            var startOffset = Convert.ToInt64(txtStartOffset);
            var endOffset = Convert.ToInt64(txtEndOffset);
            var readHashes = Convert.ToInt32(txtReadHashes);
            var skipHashes = Convert.ToInt32(txtSkipHashes);

            var arrayFromFile = FileRead.ReadFile(filePath, startOffset, endOffset);
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

        public static string[] Open(string filePath)
        {
            var listString = new List<string>();

            using (var fileStream = System.IO.File.OpenRead(filePath))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true))
            {
                var line = string.Empty;

                while ((line = streamReader.ReadLine()) != null)
                {
                    listString.Add(line);
                }
            }

            return listString.ToArray();
        }

        public static List<RaiderResult> UnhashFromFile(Endianness unhashingEndianness, HashFactory hashFactory, uint[] arrayFromFile, CaseFactory caseFactory, decimal processorCount, bool checkForMainKeys, bool checkForUserKeys, bool checkMergedKeys)
        {
            var allKeys = new BuildKeys(hashFactory, caseFactory, checkForMainKeys, checkForUserKeys, checkMergedKeys, processorCount).GetKeyValue();
            var listBox = new List<RaiderResult>();
            var isKnown = false;

            void AddResult(uint hash)
            {
                if (allKeys.TryGetValue(hash, out var result))
                {
                    isKnown = true;
                }
                else
                {
                    result = RaiderConsts.HashUnknown;
                    isKnown = false;
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

        public static List<RaiderResult> HashFromFile(HashFactory hashFactory, string[] arrayFromFile)
        {
            var listBox = new List<RaiderResult>();

            foreach (var hashString in arrayFromFile)
            {
                listBox.Add(new RaiderResult() { Hash = hashFactory.Hash(hashString), Value = hashString, IsKnown = true });
            }

            return listBox;
        }
    }
}

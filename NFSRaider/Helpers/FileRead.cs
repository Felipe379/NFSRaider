using System;
using System.Collections.Generic;
using System.IO;

namespace NFSRaider.Helpers
{
    public static class FileRead
    {
        public static uint[] ReadFile(string filePath, long startOffset, long endOffset)
        {
            var array = File.ReadAllBytes(filePath);

            var arrayOfInts = Array.Empty<uint>();

            using (var ms = new MemoryStream(array))
            {
                ms.Seek(startOffset, SeekOrigin.Begin);
                endOffset = startOffset >= endOffset ? ms.Length : endOffset;
                using (var br = new BinaryReader(ms))
                {
                    var leftover = endOffset % 4;
                    arrayOfInts = new uint[(endOffset - startOffset) / 4];
                    for (int loop = 0; br.BaseStream.Position < endOffset - leftover; ++loop)
                    {
                        arrayOfInts[loop] = br.ReadUInt32();
                    }
                }
            }

            return arrayOfInts;
        }

        public static HashSet<string> ReadFiles(IEnumerable<string> files)
        {
            var keys = new HashSet<string>();

            foreach (var file in files)
            {
                var lines = File.ReadAllLines(file);
                keys.UnionWith(lines);
            }

            return keys;
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFSRaider.Helpers
{
    public class FileRead
    {
        public uint[] ReadFile(string filePath, long startOffset, long endOffset)
        {
            var array = File.ReadAllBytes(filePath);

            var arrayOfInts = new uint[] { };

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
    }
}

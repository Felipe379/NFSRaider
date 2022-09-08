using System;
using System.IO;

namespace NFSRaider.Helpers
{
    public class FileDelete
    {
        public static void DestroyFile(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                else if (!File.Exists(path))
                {
                    throw new IOException(string.Format($"Failed to delete file: '{path}'."));
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}

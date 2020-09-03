using System;
using System.IO;
using System.IO.Compression;

namespace PANIN_ILYA_BACO._02._19_PRAKTIKA_4
{
  class Program
  {
    static void Main(string[] args)
    {
      string inFilename = @"c:\afd.txt";
      string outFilename = @"c:\afd.txt.gz";


      string inFilename1 = @"c:\afdd.txt";
      FileStream sourceFile = File.OpenRead(outFilename);
      FileStream destFile = File.Create(inFilename1);
      GZipStream compStream =
      new GZipStream(sourceFile, CompressionMode.Decompress);
      int theByte = compStream.ReadByte();
      while (theByte != -1)
      {
        destFile.WriteByte((byte)theByte);
        theByte = compStream.ReadByte();
      }

      compStream.Close();
    }
  }
}

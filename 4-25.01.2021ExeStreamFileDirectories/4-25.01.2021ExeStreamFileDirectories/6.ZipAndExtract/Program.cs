﻿using System;
using System.IO.Compression;

namespace _6.ZipAndExtract
{
    class Program
    {
        static void Main(string[] args)
        {
           using ZipArchive zip = ZipFile.Open("../../../zipFile.zip",ZipArchiveMode.Create);
            ZipArchiveEntry zipArchiveEntry = zip.CreateEntryFromFile("../../../copyMe.png", "img.png");
        }
    }
}

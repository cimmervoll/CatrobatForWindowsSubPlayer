﻿using System.IO;
using Catrobat.IDE.Core.Services.Storage;
using SharpCompress.Archive.Zip;
using SharpCompress.Common;
using SharpCompress.Reader;

namespace Catrobat.IDE.Core.Services.Common
{
    public static class CatrobatZipService
    {
        public static void UnzipCatrobatPackageIntoIsolatedStorage(Stream zipStream, string localStoragePath)
        {
            if (zipStream != null)
            {
                var reader = ReaderFactory.Open(zipStream);

                using (var storage = StorageSystem.GetStorage())
                {
                    while (reader.MoveToNextEntry())
                    {
                        var absolutPath = Path.Combine(localStoragePath, reader.Entry.FilePath);
                        absolutPath = absolutPath.Replace("\\", "/");

                        if (!reader.Entry.IsDirectory)
                        {
                            if (storage.FileExists(absolutPath))
                            {
                                storage.DeleteFile(absolutPath);
                            }

                            var fileStream = storage.OpenFile(absolutPath,
                                                              StorageFileMode.Create,
                                                              StorageFileAccess.Write);
                            reader.WriteEntryTo(fileStream);
                            fileStream.Dispose();
                        }
                    }
                }

                reader.Dispose();
            }
            //TODO: Error message? Why is the stream every restart null?
        }

        public static void ZipCatrobatPackage(Stream zipStream, string localStoragePath)
        {
            using (var storage = StorageSystem.GetStorage())
            {
                using (var archive = ZipArchive.Create())
                {
                    WriteFilesRecursiveToZip(archive, storage, localStoragePath);
                    archive.SaveTo(zipStream, CompressionType.None);
                }
            }
        }

        private static void WriteFilesRecursiveToZip(ZipArchive archive, IStorage storage, string basePath)
        {
            var searchPattern = basePath;
            var fileNames = storage.GetFileNames(searchPattern);

            foreach (string fileName in fileNames)
            {
                var tempPath = Path.Combine(basePath, fileName);
                var fileStream = storage.OpenFile(tempPath, StorageFileMode.Open, StorageFileAccess.Read);
                archive.AddEntry(fileName, fileStream);
            }

            var directrryNames = storage.GetDirectoryNames(searchPattern);
            foreach (string directoryName in directrryNames)
            {
                var tempZipPath = Path.Combine(basePath, directoryName);
                WriteFilesRecursiveToZip(archive, storage, tempZipPath);
            }
        }
    }
}
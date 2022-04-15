using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OperationFile
{
    public class Files
    {
        public string filePath = @"H:\VS\OperationFile\text1.txt";
        public void FileReadAllText()
        {

            string testData = File.ReadAllText(filePath);
            Console.WriteLine(testData);
        }
        public void FileReadAllLines()
        {
            string[] testDataLineByLine = File.ReadAllLines(filePath);
            foreach (var item in testDataLineByLine)
            {
                Console.WriteLine(item);
            }
        }
        public void FileReadAllBytes()
        {
            byte[] testDataRawBytes = File.ReadAllBytes(filePath);
            foreach (var item in testDataRawBytes)
            {
                Console.Write(item);
            }
        }

        public void FileWriteAllText()
        {
            string data = "C# Corner MVP & Microsoft MVP;";
            File.WriteAllText(filePath, data);
        }
        public void FileWriteAllLines()
        {
            string[] data = { "MCT", "MCPD", "MCTS", "MCSD.NET", "MCAD.NET", "CSM" };
            File.WriteAllLines(filePath, data);
        }
        public void FileAppendAllText()
        {
            string data = "Also Certified from IIT Kharagpur";
            File.AppendAllText(filePath, data);
        }
        public void FileAppendAllLines()
        {
            string[] otherData = { "Worked with Microsoft", "Lived in USA" };
            File.AppendAllLines(filePath, otherData);
        }
        public void FileCopy()
        {
            string destinationFilePath = @"H:\VS\OperationFile\Text2.txt";
            bool overWrite = true;
            File.Copy(filePath, destinationFilePath, overWrite);
            Console.WriteLine("File Copy Successfully");
        }
        public void FileDelete()
        {
            string destinationFilePath = @"H:\VS\OperationFile\Text2.txt";
            File.Delete(destinationFilePath);
        }
        public void FileExistorNot()
        {
            bool doesFileExist = File.Exists(filePath);
            Console.WriteLine(doesFileExist);
        }
        public void GetFileCreationTime()
        {
            DateTime fileCreatedOn = File.GetCreationTime(filePath);
            Console.WriteLine(fileCreatedOn);
        }
        public void FileInfo()
        {
            FileInfo fInfo = new FileInfo(filePath);
            Console.WriteLine(fInfo);
        }
        public void FileCopyTo()
        {
            string destinationFilePath = @"H:\data.txt";
            bool overwrite = true;
            FileInfo fInfo = new FileInfo(filePath);
            fInfo.CopyTo(destinationFilePath, overwrite);
        }
        public void FileDeleteTo()
        {
            string sourceFilePath = @"H:\data.txt";
            FileInfo fInfo = new FileInfo(sourceFilePath);
            fInfo.Delete();
        }
        public void DirectoryName()
        {
            string sourceFilePath = @"H:\data.txt";
            FileInfo fInfo = new FileInfo(sourceFilePath);
            string directoryPath = fInfo.DirectoryName;
            Console.WriteLine(directoryPath);
            //returns H:\
        }
        public void FileExist()
        {
            FileInfo fInfo = new FileInfo(filePath);
            bool filesExists = fInfo.Exists;
            Console.WriteLine(filesExists);
        }
        public void FileExtension()
        {
            FileInfo fInfo = new FileInfo(filePath);
            string filesExtn = fInfo.Extension;
            Console.WriteLine("File Extension is : " + filesExtn);
        }
        public void FileLength()
        {
            FileInfo fInfo = new FileInfo(filePath);
            long length = fInfo.Length;
            Console.WriteLine("file length is : " + length);
        }
        public void CreateDirectory()
        {
            string sourceDirPath = @"H:\MyDirectory\";
            Directory.CreateDirectory(sourceDirPath);
        }
        public void DeleteDirectory()
        {
            string sourceDirPath = @"H:\MyDirectory\";
            bool deleteRecursively = true;
            Directory.Delete(sourceDirPath, deleteRecursively);
        }
        public void ExistDirectory()
        {
            string sourceDirPath = @"H:\Data\Data1";
            bool tempDataDirectoryExists = Directory.Exists(sourceDirPath);
            Console.WriteLine(tempDataDirectoryExists);
        }
        public void GetDirectory()
        {
            string sourceDirPath = @"H:\";
            string[] subDirectories = Directory.GetDirectories(sourceDirPath);
            foreach (string subDirectory in subDirectories)
            {
                Console.WriteLine(subDirectory);
            }
        }
        public void GetFiles()
        {
            string sourceDirPath = @"C:\Users\";
            string[] files = Directory.GetFiles(sourceDirPath);
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
        }

        

    }

}



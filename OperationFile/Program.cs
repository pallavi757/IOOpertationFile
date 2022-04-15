using System;
namespace OperationFile
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Files f=new Files();
            
          //Program program = new Program();
            Console.WriteLine("Select an option");
            int option;
            do
            {
                Console.WriteLine("1 for FileReadAllText");
                Console.WriteLine("2 for FileReadAllLines");
                Console.WriteLine("3 for FileReadAllBytes");
                Console.WriteLine("4 for FileWriteAllText");
                Console.WriteLine("5 for FileWriteAllLines");
                Console.WriteLine("6 for FileAppendAllText");
                Console.WriteLine("7 for FileAppendAllLines");
                Console.WriteLine("8 for FileCopy");
                Console.WriteLine("9 for FileDelete");
                Console.WriteLine("10 for FileExistorNot");
                Console.WriteLine("11 for GetFileCreationTime");
                Console.WriteLine("12 for FileInfo");
                Console.WriteLine("13 for FileCopyTo");
                Console.WriteLine("14 for FileDeleteTo");
                Console.WriteLine("15 for DirectoryName");
                Console.WriteLine("16 for FileExist");
                Console.WriteLine("17 for FileExtension");
                Console.WriteLine("18 for FileLength");
                Console.WriteLine("19 for CreateDirectory");
                Console.WriteLine("20 for DeleteDirectory");
                Console.WriteLine("21 for ExistDirectory");
                Console.WriteLine("22 for GetDirectory");
                Console.WriteLine("23 for GetFiles");
                Console.WriteLine("0 for Exit");

                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        // OperationFile.FileReadAllText();
                        f.FileReadAllText();
                        break;
                    case 2:
                        f.FileReadAllLines();
                        break;
                    case 3:
                        f.FileReadAllBytes();
                        break;
                    case 4:
                        f.FileWriteAllText();
                        break;
                    case 5:
                        f.FileWriteAllLines();
                        break;
                    case 6:
                        f.FileAppendAllText();
                        break;
                    case 7:
                        f.FileAppendAllLines();
                        break;
                    case 8:
                       f.FileCopy();
                        break;
                    case 9:
                        f.FileDelete();
                        break;
                    case 10:
                        f.FileExistorNot();
                        break;
                    case 11:
                        f.GetFileCreationTime();
                        break;
                    case 12:
                        f.FileInfo();
                        break;
                    case 13:
                        f.FileCopyTo();
                        break;
                    case 14:
                       f.FileDeleteTo();
                        break;
                    case 15:
                        f.DirectoryName();
                        break;
                    case 16:
                       f.FileExist();
                        break;
                    case 17:
                       f.FileExtension();
                        break;
                    case 18:
                        f.FileLength();
                        break;
                    case 19:
                        f.CreateDirectory();
                        break;
                    case 20:
                      f.DeleteDirectory();
                        break;
                    case 21:
                        f.ExistDirectory();
                        break;
                    case 22:
                   f.GetDirectory();
                        break;
                    case 23:
                        f.GetFiles();
                        break;
                    case 0:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
            } while (option!= 0);
        }
    }
}

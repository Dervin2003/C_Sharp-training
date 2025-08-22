using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class DirecTory
    {
        public void Creation()
        {
            string folderPath = @"D:\DemoCreation";

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
                Console.WriteLine("Directory created.");
            }
            else
            {
                Console.WriteLine("Directory already exists.");
            }
        }

        public void FileAdd()
        {
            string filePath = @"D:\DemoCreation\demoo.txt";

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Adding a file demoo.txt");
                writer.WriteLine("Multiple line test");
                writer.WriteLine("New Line");
            }

            using (StreamReader reader = new StreamReader(filePath))
            {
                string content = reader.ReadToEnd();
                Console.WriteLine(content);
            }
        }
        public void CsvAdd()
        {
            string csvPath = @"D:\DemoCreation\data.csv";
            string[] lines = {
                "Id,Name,Age",
                "1,John,45",
                "2,Cena,60"
            };

            File.WriteAllLines(csvPath, lines);

            foreach (string line in File.ReadAllLines(csvPath))
            {
                Console.WriteLine(line);
            }
        }
        public void BinaryAdd()
        {
            string binPath = @"D:\DemoCreation\data.bin";

            using (FileStream fs = new FileStream(binPath, FileMode.Create))
            using (BinaryWriter writer = new BinaryWriter(fs))
            {
                writer.Write(101);
                writer.Write(45.67);
                writer.Write("Binary File Example");
            }

            using (FileStream fs = new FileStream(binPath, FileMode.Open))
            using (BinaryReader reader = new BinaryReader(fs))
            {
                int num = reader.ReadInt32();
                double val = reader.ReadDouble();
                string text = reader.ReadString();

                Console.WriteLine($"{num}, {val}, {text}");
            }
        }
        public void FileMethods()
        {
            string filePath = @"D:\DemoCreation\quick.txt";

            File.WriteAllText(filePath, "Hello from WriteAllText");
            File.AppendAllText(filePath, "\nAppended line");
            File.WriteAllLines(filePath, new string[] { "Line1", "Line2", "Line3" });
            File.AppendAllLines(filePath, new string[] { "Appended1", "Appended2" });

            Console.WriteLine("ReadAllText:\n" + File.ReadAllText(filePath));

            Console.WriteLine("ReadAllLines:");
            foreach (var line in File.ReadAllLines(filePath))
            {
                Console.WriteLine(line);
            }

            Console.WriteLine("ReadAllBytes:");
            byte[] bytes = File.ReadAllBytes(filePath);
            Console.WriteLine(string.Join(" ", bytes));
        }

        public void DirectoryMethods()
        {
            string path = @"D:\DemoCreation";

            Console.WriteLine("Files in directory:");
            foreach (var file in Directory.GetFiles(path))
                Console.WriteLine(file);

            Console.WriteLine("Subdirectories:");
            foreach (var dir in Directory.GetDirectories(path))
                Console.WriteLine(dir);

            Console.WriteLine("Enumerating Files (*.txt):");
            foreach (var file in Directory.EnumerateFiles(path, "*.txt"))
                Console.WriteLine(file);

            Console.WriteLine("CreationTime: " + Directory.GetCreationTime(path));
            Console.WriteLine("LastAccessTime: " + Directory.GetLastAccessTime(path));
            Console.WriteLine("LastWriteTime: " + Directory.GetLastWriteTime(path));

            string newPath = @"D:\DemoMoved";
            if (Directory.Exists(path))
            {
                if (!Directory.Exists(newPath))
                {
                    Directory.Move(path, newPath);
                    Console.WriteLine("Directory moved.");
                }
            }
        }

        public void FileManagement()
        {
            string sourcePath = @"D:\DemoCreation\demoo.txt";
            string copyPath = @"D:\DemoCreation\copy.txt";
            string movePath = @"D:\DemoCreation\moved.txt";

            if (File.Exists(sourcePath))
            {
                File.Copy(sourcePath, copyPath, true);
                Console.WriteLine("File copied.");

                File.Move(copyPath, movePath);
                Console.WriteLine("File moved.");

                File.SetAttributes(movePath, FileAttributes.ReadOnly);
                Console.WriteLine("Attributes set: " + File.GetAttributes(movePath));

                File.Delete(movePath);
                Console.WriteLine("File deleted.");
            }
        }

        public void FileInfoDemo()
        {
            FileInfo f = new FileInfo(@"D:\DemoCreation\demoo.txt");
            if (f.Exists)
            {
                Console.WriteLine("Name: " + f.Name);
                Console.WriteLine("FullName: " + f.FullName);
                Console.WriteLine("Extension: " + f.Extension);
                Console.WriteLine("Length: " + f.Length);
                Console.WriteLine("CreationTime: " + f.CreationTime);
            }
        }

        public void DirectoryInfoDemo()
        {
            DirectoryInfo d = new DirectoryInfo(@"D:\DemoCreation");
            if (d.Exists)
            {
                Console.WriteLine("Name: " + d.Name);
                Console.WriteLine("FullName: " + d.FullName);
                Console.WriteLine("CreationTime: " + d.CreationTime);

                Console.WriteLine("Files:");
                foreach (var file in d.GetFiles())
                    Console.WriteLine(file.Name);

                Console.WriteLine("Subdirectories:");
                foreach (var dir in d.GetDirectories())
                    Console.WriteLine(dir.Name);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    class State
    {
        private int index;
        public int Index
        {
            get { return index; }
            set
            {
                int maxVal = Folder.GetFileSystemInfos().Length;
                if (value >= 0 && value < maxVal)
                {
                    index = value;
                }
            }
        }
        public DirectoryInfo Folder { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"What is the name of directory you are searching for?");
            String S = Console.ReadLine();
            Stack<DirectoryInfo> layers = new Stack<DirectoryInfo>();
            layers.Push(new DirectoryInfo(S));
            //string path = @"C:\Users\Амина\Desktop";
            //string lastFolderName = Path.GetFileName(Path.GetDirectoryName(path));
            //Console.WriteLine(lastFolderName);
            while (layers.Count > 0)
            {
                DirectoryInfo CurrentState = layers.Peek();
                layers.Pop();
                for (int i = 0; i < CurrentState.GetFileSystemInfos().Length; i++)
                {
                    if (CurrentState.GetFileSystemInfos()[i] is DirectoryInfo)
                    {
                        layers.Push(new DirectoryInfo(CurrentState.GetFileSystemInfos()[i].FullName));
                    }
                
                    else
                    {
                        if (CurrentState.GetFileSystemInfos()[i].Extension == ".txt")
                        {
                            if (DoesItContain(CurrentState.GetFileSystemInfos()[i].FullName,"abcd"))
                            {
                                Console.WriteLine(CurrentState.GetFileSystemInfos()[i].FullName);
                            }
                        }
                    }
                }
            }
            Console.ReadKey();

        }
        static bool DoesItContain(string fullName, string p)
        {

            StreamReader tmp = new StreamReader(new FileStream(fullName, FileMode.Open, FileAccess.Read));
            string s = tmp.ReadToEnd();
            tmp.Close();
            return s.Contains(p);
        }


    }
}
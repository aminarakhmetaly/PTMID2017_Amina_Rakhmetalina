using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            using System;
            using System.Collections.Generic;
            using System.IO;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace SearchString
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

                //Setting default color for manager

                Console.WriteLine(@"Please write directory name");
                String Q = Console.ReadLine();
                Stack<DirectoryInfo> layers = new Stack<DirectoryInfo>();
                layers.Push(new DirectoryInfo(Q));
                while (layers.Count > 0)
                {
                    DirectoryInfo CurState = layers.Peek();
                    layers.Pop();
                    for (int i = 0; i < CurState.GetFileSystemInfos().Length; i++)
                    {
                        if (CurState.GetFileSystemInfos()[i] is DirectoryInfo)
                        {
                            layers.Push(new DirectoryInfo(CurState.GetFileSystemInfos()[i].FullName));
                        }
                        else
                        {
                            if (CurState.GetFileSystemInfos()[i].Extension == ".txt")
                            {
                                if (DoesItContain(CurState.GetFileSystemInfos()[i].FullName, "abcd"))
                                {
                                    Console.WriteLine(CurState.GetFileSystemInfos()[i].FullName);
                                }
                            }
                        }
                    }
                }
                Console.ReadKey();

            }


            static bool DoesItContain(string fullName, string query)
            {

                StreamReader tmp = new StreamReader(new FileStream(fullName, FileMode.Open, FileAccess.Read));
                string s = tmp.ReadToEnd();
                tmp.Close();
                return s.Contains(query);
            }



        }
    }
}
    }
}

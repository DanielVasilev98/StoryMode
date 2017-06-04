using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft
{
   public static class IOManager
    {
        public static void TraverseDirectory(string path)
        {
            
            int initialIdentation = path.Split('\\').Length;
            Queue<string> subFolders = new Queue<string>();
            OutputWriter.WriteMessageOnLine(path);
            subFolders.Enqueue(path);

            while (subFolders.Count != 0)
            {
                string currentPath = subFolders.Dequeue();
                int identation = currentPath.Split('\\').Length - initialIdentation;
                identation++;
                foreach (var directoryPath in Directory.GetDirectories(currentPath))
                {
                    
                    OutputWriter.WriteMessageOnLine(string.Format("{0}{1}", new string('-', identation), directoryPath));
                    subFolders.Enqueue(directoryPath);
                }
                
            }
        }
    }
}

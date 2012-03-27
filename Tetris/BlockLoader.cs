using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Tetris
{
    /// <summary>
    /// A way of designing and loading custom block sets
    /// </summary>
    public static class BlockLoader
    {
        /// <summary>
        /// Check the directory that the program is running in for any blockset files
        /// </summary>
        /// <returns>A list of names of all the blocksets</returns>
        public static String[] names()
        {
            String[] files = Directory.GetFiles(".");
            List<String> names = new List<String>();
            foreach (String file in files)
            {
                Console.WriteLine(file);
                String fileType = file.Split('.').Last();
                Console.WriteLine(fileType);
                if (fileType == "exe")
                {
                    names.Add(file);
                    Console.WriteLine("added");
                }
            }
                
            return names.ToArray();
        }
    }
}

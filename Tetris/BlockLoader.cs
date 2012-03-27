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
        /// The file type that block sets are stored in
        /// </summary>
        public static readonly String filetype = "blockset";

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
                String fileType = file.Split('.').Last();
                if (fileType == BlockLoader.filetype)
                {
                    names.Add(file);
                }
            }
                
            return names.ToArray();
        }

        /// <summary>
        /// Load a block set with the specified name
        /// </summary>
        /// <param name="set">The name of the blockset to load</param>
        public static void load(String set)
        {
            String fileName = Path.Combine(set + "." + BlockLoader.filetype);
            Console.WriteLine("happy " + fileName);
            if (File.Exists(fileName))
            {
                Console.WriteLine("it exists");
                try
                {
                    String[] contents = File.ReadAllLines(fileName);
                    foreach(String line in contents){
                        Console.WriteLine(line);
                    }
                }
                catch(Exception e){
                }
            }
        }
    }
}

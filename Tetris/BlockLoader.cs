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
        /// A character to indicate that he block is solid at that point
        /// </summary>
        public static readonly char solidIndicator = '#';

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
                    names.Add(file.Split('.').ElementAt(1).Substring(1));
                }
            }
                
            return names.ToArray();
        }

        /// <summary>
        /// Load a block set with the specified name
        /// Assumes the blocks are all square with an even dimension
        /// </summary>
        /// <param name="set">The name of the blockset to load</param>
        public static List<String[]> load(String set)
        {
            String fileName = Path.Combine(set + "." + BlockLoader.filetype);
            
            if (File.Exists(fileName))
            {
                try
                {
                    String[] contents = File.ReadAllLines(fileName);
                    List<String[]> blockStrings = new List<String[]>();
                    List<String> currentArr = new List<String>();
                    bool readingIn = false;

                    // read in the file
                    foreach(String line in contents){
                        // start reading a block if you're not currently and the size is valid
                        if (!readingIn && line.Length > 0 && line.Length % 2 == 0)
                        {
                            currentArr.Clear();
                            readingIn = true;
                        }
                        // if reached the end of a block
                        if (readingIn && line.Length == 0)
                        {
                            // and something in the block has been read
                            if (currentArr.Count > 0)
                            {
                                blockStrings.Add(currentArr.ToArray());
                                readingIn = false;
                            }
                        }
                        // read in the contents of a block
                        if (readingIn && line.Length > 0)
                        {
                            currentArr.Add(line);
                        }
                    }

                    // do validation
                    foreach (String[] block in blockStrings)
                    {
                        bool isSolid = false;

                        if (block.Length == 0 || block[0].Length == 0 || block[0].Length % 2 != 0)
                            blockStrings.Remove(block);

                        foreach (String row in block)
                        {
                            if (row.Length != block[0].Length)
                                blockStrings.Remove(block);

                            if (row.Contains(BlockLoader.solidIndicator))
                                isSolid = true;
                        }

                        if(!isSolid)
                            blockStrings.Remove(block);
                    }

                    return blockStrings.Count == 0 ? null : blockStrings;
                }
                catch(Exception e){
                }
            }

            return null;
        }
    }
}

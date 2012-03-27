using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Tetris
{
    class BlockPositionSpawner
    {
        /// <summary>
        /// A method of tracking which blocks have been spawned recently, creating a bucket which
        /// prevents long strings of the same block.
        /// </summary>
        public BlockPositionSpawner()
        {
            currentBucket = new BlockStartPosition[7];
            nextBucket = new BlockStartPosition[7];

            setPossiblePositions(ref currentBucket);
            setPossiblePositions(ref nextBucket);
        }

        /// <summary>
        /// Create a block position spawner where the block positions are loaded from a file
        /// </summary>
        /// <param name="name">The name of the file to load</param>
        public BlockPositionSpawner(String name)
        {
            loadedPositions = BlockLoader.load(name);

            if (loadedPositions != null && loadedPositions.Count != 0)
            {
                Console.WriteLine("loaded " + loadedPositions.Count);
                currentBucket = new BlockStartPosition[loadedPositions.Count];
                nextBucket = new BlockStartPosition[loadedPositions.Count];
            }

            setPossiblePositions(ref currentBucket);
            setPossiblePositions(ref nextBucket);
        }

        #region variables

        /// <summary>
        /// The current bucket of blocks that should be taken from when selecting a new one
        /// </summary>
        private BlockStartPosition[] currentBucket;

        /// <summary>
        /// The next bucket of blocks that should be taken from when selecting a new one
        /// </summary>
        private BlockStartPosition[] nextBucket;

        /// <summary>
        /// A random number generator
        /// </summary>
        private Random rand = new Random();

        /// <summary>
        /// A counter to determine which block should be chosen next
        /// </summary>
        private int nextBlock = 0;

        /// <summary>
        /// Start positions that have been loaded from a file
        /// </summary>
        private List<String[]> loadedPositions = null;

        #endregion variables

        /// <summary>
        /// Returns the position of the next block to play with
        /// </summary>
        /// <returns>The position block to play with</returns>
        public BlockStartPosition Next()
        {
            BlockStartPosition blockToReturn = currentBucket[nextBlock];
            currentBucket[nextBlock] = nextBucket[nextBlock];
            nextBlock++;

            if (nextBlock >= currentBucket.Length)
            {
                nextBlock = 0;
                setPossiblePositions(ref nextBucket);
            }
            
            return blockToReturn;
        }

        /// <summary>
        /// Set the possible positions that a block can start in
        /// </summary>
        private void setPossiblePositions(ref BlockStartPosition[] bucket)
        {
            if (loadedPositions == null || loadedPositions.Count == 0)
            {
                setKnownPossiblePositions(ref bucket);
                setKnownPossiblePositions(ref bucket);
            }
            else
            {
                int count = 0;

                foreach (String[] block in loadedPositions)
                {
                    bucket[count] = new BlockStartPosition();
                    bucket[count].position = new Boolean[block.Length, block.Length];
                    // load the positions
                    for (var row = 0; row < block.Length; row++)
                    {
                        char[] rowArr = block[row].ToCharArray();
                        for (var col = 0; col < block[row].Length; col++)
                        {
                            bucket[count].position[row, col] = rowArr[col] == BlockLoader.solidIndicator;
                        }
                    }
                    // give it a random color. Pretty ^_^
                    KnownColor[] names = (KnownColor[]) Enum.GetValues(typeof(KnownColor));
                    KnownColor randomColorName = names[new Random().Next(names.Length)];
                    bucket[count].color = Color.FromKnownColor(randomColorName);

                    count++;
                }
            }
        }

        /// <summary>
        /// Specify the possible positions that a block can start in if nothing has loaded from a file
        /// </summary>
        private void setKnownPossiblePositions(ref BlockStartPosition[] bucket)
        {
            // straight across in a line
            bucket[0] = new BlockStartPosition();
            bucket[0].position = new Boolean[,]
                                        {{false, false, false, false},
                                        {false, false, false, false},
                                        {true, true, true, true},
                                        {false, false, false, false}};
            bucket[0].color = Color.Cyan;
            // L with a spike on the left
            bucket[1] = new BlockStartPosition();
            bucket[1].position = new Boolean[,]
                                        {{false, false, false, false},
                                        {false, true, false, false},
                                        {false, true, true, true},
                                        {false, false, false, false}};
            bucket[1].color = Color.Blue;
            // L with a spike on the right
            bucket[2] = new BlockStartPosition();
            bucket[2].position = new Boolean[,]
                                        {{false, false, false, false},
                                        {false, false, false, true},
                                        {false, true, true, true},
                                        {false, false, false, false}};
            bucket[2].color = Color.Orange;
            // square
            bucket[3] = new BlockStartPosition();
            bucket[3].position = new Boolean[,]
                                        {{false, false, false, false},
                                        {false, true, true, false},
                                        {false, true, true, false},
                                        {false, false, false, false}};
            bucket[3].color = Color.Yellow;
            // zig-zag up to the right
            bucket[4] = new BlockStartPosition();
            bucket[4].position = new Boolean[,]
                                        {{false, false, false, false},
                                        {false, false, true, true},
                                        {false, true, true, false},
                                        {false, false, false, false}};
            bucket[4].color = Color.Red;
            // zig-zag up to the left
            bucket[5] = new BlockStartPosition();
            bucket[5].position = new Boolean[,]
                                        {{false, false, false, false},
                                        {true, true, false, false},
                                        {false, true, true, false},
                                        {false, false, false, false}};
            bucket[5].color = Color.Green;
            // T shape
            bucket[6] = new BlockStartPosition();
            bucket[6].position = new Boolean[,]
                                        {{false, false, false, false},
                                        {false, false, true, false},
                                        {false, true, true, true},
                                        {false, false, false, false}};
            bucket[6].color = Color.Purple;

            shuffle(ref bucket);
        }

        /// <summary>
        /// Shuffle a bucket to randomise the order that blocks spawn in
        /// Uses a Fisher–Yates shuffle
        /// http://en.wikipedia.org/wiki/Fisher%E2%80%93Yates_shuffle
        /// http://www.codinghorror.com/blog/2007/12/the-danger-of-naivete.html
        /// </summary>
        /// <param name="bucket">The bucket that should be shuffled</param>
        private void shuffle(ref BlockStartPosition[] bucket)
        {
            BlockStartPosition temp;
            for (int i = bucket.Length - 1; i > 0; i--)
            {
                int n = rand.Next(i + 1);
                temp = bucket[i];
                bucket[i] = bucket[n];
                bucket[n] = temp;
            }
        }
    }
}

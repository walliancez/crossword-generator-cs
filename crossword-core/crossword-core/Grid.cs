using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crossword_core
{
    class Grid
    {
        private int width;
        private int height;
        private int[] grid;
        private int size;

        public Grid(int width, int height)
        {
            this.width = width;
            this.height = height;
            this.size = width * height;
            grid = new int[width * height];
            foreach (int cell in grid)
            {
                grid[cell] = 0;
            }
        }
        public void insertLine(int startingPoint, int length, bool orientationIsHorizontal)
        {
            if (orientationIsHorizontal)
            {
                for (int i = startingPoint; i < startingPoint + length; i++)
                {
                    grid[i] = 1;
                }
            }
            else
            {
                for (int i = 0; i < length; i++)
                {
                    grid[startingPoint + (width * length)] = 1;
                }
            }
        }
        public string returnTest()
        {
            string test = "";

            foreach (int baz in grid)
            {
                test = test + grid[baz].ToString();
            }

            return test;
        }
        public override string ToString()
        {
            string value = String.Join("", grid);
            StringBuilder sb = new StringBuilder();
            int index = 0;
            for (int i = 0; i < size; i++)
            {
                if (i - (index * width) == width) { 
                    sb.Append('\n');
                    sb.Append(value[i]);
                    index++;
                }
                sb.Append(value[i]);
            }
            return sb.ToString();
        }
    }
}

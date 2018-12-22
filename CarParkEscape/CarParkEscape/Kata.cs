using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParkEscape
{
    public class Kata
    {
        private const int CAR = 2;
        private const int STAIR = 1;
        private List<string> route = new List<string>();
        private int level = 0;
        private int space = 0;
        private int curLevel = 0;
        private int curSpace = 0;

        public string[] escape(int[,] carpark)
        {
            level = carpark.GetLength(0);
            space = carpark.GetLength(1);

            findCar(carpark);
            while(curLevel != level - 1)
            {
                findStair(carpark);
                goDown(carpark);
            }
            findExit();

            return route.ToArray();
        }

        private void goRight(int step)
        {
            route.Add("R" + step);
        }
        private void goLeft(int step)
        {
            route.Add("L" + step);
        }
        private void goDown(int[,] carpark)
        {
            var count = 0;
            while(carpark[curLevel, curSpace] == STAIR)
            {
                count++;
                curLevel++;
            }
            route.Add("D" + count);
        }
        private void findCar(int[,] carpark)
        {
            for(var i = 0; i < level; i++)
            {
                for (var j = 0; j < space; j++)
                {
                    if(carpark[i, j] == CAR)
                    {
                        curLevel = i;
                        curSpace = j;
                        return;
                    }
                }
            }
        }
        private void findStair(int[,] carpark)
        {
            var stair = 0;
            for(stair = 0; stair < space; stair++)
            {
                if(carpark[curLevel, stair] == STAIR)
                {
                    var count = stair - curSpace;
                    if (count > 0)
                        goRight(count);
                    else
                        goLeft(-count);
                    break;
                }
            }
            curSpace = stair;
        }
        private void findExit()
        {
            var count = space - 1 - curSpace;
            if (count > 0)
                goRight(count);
        }
    }
}

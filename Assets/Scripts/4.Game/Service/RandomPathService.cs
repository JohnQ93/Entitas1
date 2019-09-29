using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class RandomPathService
    {
        public static string RandomPath()
        {
            int index = Random.Range(0, 6);

            string temp = "";
            switch (index)
            {
                case 0:
                    temp = ResPath.ItemPath0;
                    break;
                case 1:
                    temp = ResPath.ItemPath1;
                    break;
                case 2:
                    temp = ResPath.ItemPath2;
                    break;
                case 3:
                    temp = ResPath.ItemPath3;
                    break;
                case 4:
                    temp = ResPath.ItemPath4;
                    break;
                case 5:
                    temp = ResPath.ItemPath5;
                    break;
            }
            return temp;
        }
    }
}
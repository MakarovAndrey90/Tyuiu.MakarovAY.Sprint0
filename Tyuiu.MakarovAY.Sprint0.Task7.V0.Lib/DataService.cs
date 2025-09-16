using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace Tyuiu.MakarovAY.Sprint0.Task7.V0.Lib
{
    public class DataService
    {
        public static int[] AdditionArrays(int[] numOnen, int[] numTwo)
        {
            int[] resultArray = new int[5];
            for (var i = 0; i < resultArray.Length; i++)
            {
                resultArray[i] = numOnen[i] + numTwo[i];
            }
            return resultArray;
        } 
    }
}

using System;

namespace Algo;

class Algo {
    static void Main(String[] strings)
    {
        int[] array= new int[6]{1,2,4,5,6,2};
        int k = 4;
        for(int i = 0; i < array.Length; i++){
            if (array[i] < k){
                for (int j = i+1; j < array.Length; j++){
                    if (array[i] + array[j] == k){
                        Console.WriteLine("true");
                        break;
                    }
                }
            }
        }
    }
}

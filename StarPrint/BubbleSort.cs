/******************************************************************************
Bubble sort 

i/p : [2,4,3,7,6,1,5]
o/p : [1,2,3,4,5,6,7]

*******************************************************************************/
using System;
class HelloWorld {
  static int[] BubbleSort(int[] ar, int len){
      for(int i=0;i<len-1;i++){
          for(int j=0;j<len-i-1;j++){
            if(ar[j]>ar[j+1]){
                int temp = ar[j];
                ar[j] = ar[j+1];
                ar[j+1] = temp; 
            }
          }
      }
      return ar;
  }  
  static void Main() {
    int size = Convert.ToInt32(Console.ReadLine());
    int[] ar = new int[size];
    for(int i=0;i<size;i++){
       ar[i] = Convert.ToInt32(Console.ReadLine());
    }
    int [] sortedAray = BubbleSort(ar,size);
    for(int i=0;i<size;i++){
        Console.Write(sortedAray[i]+" ");
    }
    Console.ReadKey();
  }
}

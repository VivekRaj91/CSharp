/******************************************************************************
Selection sort 

i/p : [2,4,3,7,6,1,5]
o/p : [1,2,3,4,5,6,7]

*******************************************************************************/
using System;
class HelloWorld {
  static int[] SelectionSort(int[] ar, int len){
      for(int i=0;i<len-1;i++){
          int min_index = i;
          for(int j=i+1;j<len;j++){
              if(ar[min_index] > ar[j]){
                  min_index = j;
              }
          }
          int temp = ar[i];
          ar[i] = ar[min_index];
          ar[min_index] = temp;
      }
      return ar;
  }  
  static void Main() {
    int size = Convert.ToInt32(Console.ReadLine());
    int[] ar = new int[size];
    for(int i=0;i<size;i++){
       ar[i] = Convert.ToInt32(Console.ReadLine());
    }
    int [] sortedAray = SelectionSort(ar,size);
    for(int i=0;i<size;i++){
        Console.Write(sortedAray[i]+" ");
    }
    Console.ReadKey();
  }
}

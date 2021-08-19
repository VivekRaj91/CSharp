/******************************************************************************

*
* *
* * *

*******************************************************************************/
using System;
class StarPrint1 {
  static void Main() {
      int n=Convert.ToInt32(Console.ReadLine());
      for(int i=0;i<n;i++){
          for(int j=0;j<=i;j++){
              Console.Write(" * ");
          }
          Console.WriteLine("");
      }
    
  }
}
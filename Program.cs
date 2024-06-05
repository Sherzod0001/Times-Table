using System;
using System.Runtime.Intrinsics.Arm;
Console.WriteLine("Bu dastur siz kiritgan raqamlarning oralig'idagi karra jadvalini chiqarib beradi : (3 6)");
int start = Convert.ToInt32(Console.ReadLine());
int finish = Convert.ToInt32(Console.ReadLine());

for (int row = 1; row <= 10; row++)
{
    for (int column = start; column <= finish; column++)
    {
        Console.Write($"{column} * {row} = {row * column} \t");
    }
    Console.WriteLine();
}







// for(int i=1;i<11;i++){
//     for(int j=1;j<11;j++){
//         Console.Write($"{j} * {i} = {i*j} \t");

//     }
//     Console.WriteLine();
// }
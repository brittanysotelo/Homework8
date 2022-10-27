namespace Homework8;
class Program
{
    static void Main(string[] args)
    {
//Question1
        int[] int_array = {11, 23, 31, 42, 53};
        int sum = 0;

        foreach (int x in int_array){
            sum += x;
        }
        Console.WriteLine($"The Sum of int_array is: {sum}");

//Question2.1
        int[,] arr = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };
        foreach(int val in arr){
            if(val%2 != 0){
                Console.Write(val+" ");
            }
        }
//Question2.2
        int sum = 0;
        foreach(int x in arr){
            sum += x;
        }
        Console.WriteLine($"The Sum of array elements: {sum}");
//Question2.3
        int[ ] a = new int[10];
        for (int k = 1; k < 10; k++) {
            a[ k ] = k * 2;
        }
        foreach (int k in a) {
            Console.Write(k);
        }
    }
}

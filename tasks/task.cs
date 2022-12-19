////// task1 ////////
using System;
namespace Tasks;
public class Task{
/*
    public static void Main(){
        Console.Write(" please write string : ");
        var x =Console.ReadLine();
        if (x==null) return;
        for(var i=x.Length-1;i>=0;i--){
         Console.Write(x[i]);
         
        }
    }
    */
////////// task2 //////
/*
public static void Main(){
    Console.Write("enter string contain a :");
    var x=Console.ReadLine();
    if (x==null) return;
    int count=0;
    for(int i=0;i<x.Length;i++){
        if(x[i]=='a'){
      count++;
        }
    }
    Console.Write(count);
}
*/
///// task 3 //////

/*
public static void Main(){
    Console.Write("enter string contain a :");
    var x=Console.ReadLine();
    if (x==null) return;
    for(int i=x.Length-1;i>=0;i--){
      if (x[i] != 'a') continue;
         Console.Write($"A's last index is {i}");
           break;
 }
    }
*/
/////// task 4///////
/*
public static void Main(string[] args)     {
         Console.Write("please enter a  string:");
         var x = Console.ReadLine();
         if (x == null) return;
         for (int i = 0; i < x.Length; i++)
        {
             if (x[i] != 'a')continue;
             x = x.Replace(x[i].ToString(), "");
         }
         Console.Write(x);
     }
*/
//////task 5 ////
/*
public static void Main()     {
         Console.Write("please enter a  string:");
         var x = Console.ReadLine();
         if (x == null) return;
         for (int i = 0; i < x.Length; i++)
        {

             if (x[i] != 'a') continue;
             x=x.Insert(i+1,"0");
         }
         Console.Write(x);
     }
     */
     //////task 6 //////
     /*
      public static void Main()
     {
         Console.Write("please enter a  string:");
         var x = Console.ReadLine();
         if (x == null) return;
         var count = 0;

for (var i=0;i<x.Length;i++){
if(x[i]>=65 && x[i]<=122){
    continue;
}else{
    count++;
}
}
         Console.Write($"there was {count} non-literal character");
     }


*/
/////// task 7 //////
/*
    public static void Main()
    {
        Console.Write("please enter a  string:");
        var x = Console.ReadLine();
        if (x == null) return;
        var arr = x.ToCharArray();
        Array.Reverse(arr);
       for (int i = 0; i < x.Length; i++)
        {
            if (x[i] == arr[i]){
                Console.Write("string is Palindrome");
                break;
            } else{
                Console.Write("string is not Palindrome");
                break;
 
            }

        }


        
    }
    */

    //// task 8 /////
    /*
    static void Main(string[] args)
        {
            Console.Write("Enter a String : ");
            var input = Console.ReadLine();
            string result="";
            for (int i = 0; i < input.Length; i++)
            {
                if (!result.Contains(input[i]))
                {
                    result += input[i];
                }
            }
            Console.WriteLine(result);
        }
        */

        ///// task 9 ///////
        /*
         public static void Main(string[] args)
    {
        Console.Write("please enter a  size of list:");
        var size = Convert.ToInt32(Console.ReadLine());
        var arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write($"please enter element {i+1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        var average = arr.Average();
        var min = double.PositiveInfinity;
        var num = -1;
        for (int i = 0; i < arr.Length; i++)
        {
            var distance = average - arr[i];
            if (!(Math.Abs(distance) < min)) continue;
            min = Math.Abs(distance);
            num = arr[i];
        }
        
        Console.WriteLine($"{average} is the average ");
        Console.Write($"{num} is the nearest to the mean \n the difference is {min} ");
    }
    */
    /// task 10////
/*
    public static void Main(string[] args)
    {
        Console.Write("please enter a  size of list:");
        var size = Convert.ToInt32(Console.ReadLine());
        var arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write($"please enter element {i+1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        var min = arr[0];
        var max = arr[0];
        for (var i=1;i<arr.Length;i++){
            if (arr[i]>max )
            {
                max = arr[i];
            }
            if (arr[i]<min)
            {
               min = arr[i];
            }
        }
        var avg=(min+max)/2;
        Console.WriteLine($"the min of the array is {min}");
        Console.WriteLine($"the max of the array is {max}");
        Console.WriteLine($"the avg of the array is { avg}");

    }
    */
    ////// task 11///
    /*
     public static void Main(string[] args)
    {
        Console.Write("please enter a list separated by space :");
        var x = Console.ReadLine()?.Split();
        if (x== null)return;
        var newString = "";
        for (int i = 0; i < x.Length; i++)
        {
            if (i == x.Length-1)
            {
                newString = newString.Insert(newString.Length  , x[i]);
                break;
            }
            newString = newString.Insert(newString.Length  , $"{x[i]} , ");
            var current = Convert.ToInt32(x[i]);
            var next = Convert.ToInt32(x[i+1]);
            while ((current + 1) != next)
            {
                newString = newString.Insert(newString.Length, $"{++current} , ");
            }
        }
        Console.Write(newString);
    }
    */
////// task 12///////

 public static void Main(string[] args)
    {
         Console.Write("please enter a  size of list:");
        var size = Convert.ToInt32(Console.ReadLine());
        var arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write($"please enter element {i+1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        var min = arr[0];
        var max = arr[0];
        for (var i=1;i<arr.Length;i++){
            if (arr[i]>max )
            {
                max = arr[i];
            }
            if (arr[i]<min)
            {
               min = arr[i];
            }
        }
        double avg=(min+max)/2;
        // int count=0;
        for(var i=0;i<arr.Length;i++){
        if (arr[i]< avg)
        //count++;
        Console.WriteLine(arr[i]);
        }
        }
     
    

//// task 13////
/*
    public static void Main(string[] args)
    {
        Console.Write("please enter a  size of list:");
        var size = Convert.ToInt32(Console.ReadLine());
        var arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write($"please enter element {i+1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        var min = arr[0];
        var max = arr[0];
        for (var i=1;i<arr.Length;i++){
            if (arr[i]>max )
            {
                max = arr[i];
            }
            if (arr[i]<min)
            {
               min = arr[i];
            }
        }
        double avg=(min+max)/2;
        Console.WriteLine($"the min of the array is {min}");
        Console.WriteLine($"the max of the array is {max}");
        Console.WriteLine($"the avg of the array is { avg}");


        for(var x=0;x<arr.Length;x++){
            if(arr[x]>avg){
            Console.Write($"the number is {arr[x]}");
                break;
            }
        }
    }
*/
}



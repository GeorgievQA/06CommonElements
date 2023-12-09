int[] firstArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

int[] secondArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
bool isEqual = true;

for (int index1 = 0; index1 < firstArray.Length; index1++)
{
    for (int index2 = 0; index2 < secondArray.Length; index2++)
    {
        if (firstArray[index1] != secondArray[index2])
        {
            isEqual = false;
            continue;
        }
        else if (isEqual)
        {
            Console.WriteLine(string.Join(" ", );
        }
    }
}
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {

//        int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


//        int[] arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

//        int[] commonElements = FindCommonElements(arr1, arr2);

//        Console.WriteLine(string.Join(" ", commonElements));
//    }

//    static int[] FindCommonElements(int[] arr1, int[] arr2)
//    {
//        var commonElements = arr1.Intersect(arr2).ToArray();
//        return commonElements;
//    }
//}

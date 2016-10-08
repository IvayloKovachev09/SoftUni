using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
      
        var firstString = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int numberOfRotate = int.Parse(Console.ReadLine());
       
        List<int> nums = firstString.ToList();
        var newNums = nums.Skip(1).Take(nums.Count() - 1).ToList();
        newNums.Add(nums[0]);
        Console.WriteLine(nums);
    }
    
}


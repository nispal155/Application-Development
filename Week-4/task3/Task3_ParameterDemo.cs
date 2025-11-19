using System;
namespace task3;
class ParameterDemo
{
    // 'ref' means the original variable passed into this method will be changed
    public void Increase(ref int number)
    {
        number += 10;
    }

    // 'out' means this method MUST give a value back to the variable sent in
    public void GetFullName(out string fullname)
    {
        fullname = "Nispal Bhattarai"; 
    }

    // 'params' allows you to pass any number of integers (1, 2, or many)
    public int SumAll(params int[] numbers)
    {
        int sum = 0;
        // Loop through each number and add it to sum
        foreach (int n in numbers) 
            sum += n;

        return sum; // this will return the total
    }
}
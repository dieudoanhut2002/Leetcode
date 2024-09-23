// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
DuplicateZeros([8, 4, 5, 0, 0, 0, 0, 7]);
// [8,4,5,0,0,0,0,0]

void DuplicateZeros(int[] arr)
{
    // Count the possible Zeros position that will be duplicated without expanding the arr size.
    // If we found one "Zero", the last element will be shifted out the arr
    // So the for range would be decreased by 1 each "Zero"
    int possibleZerosCount = 0;
    for (int i = 0; i < arr.Length - possibleZerosCount; i++)
    {
        if (arr[i] == 0)
            possibleZerosCount++;
    }

    // Shift each element from the [arr.Length -1 - possibleZerosCount] index to n step 
    // n initialized by possibleZerosCount then decreased by 1 when the shifting element is "Zero" and add a new "Zero" infront of the shifted element
    // decrease the n by 1 whenever we meet a "Zero"

    for (int i = arr.Length - 1 - possibleZerosCount; i >= 0; i--)
    {
        arr[i + possibleZerosCount] = arr[i];
        if (arr[i + possibleZerosCount] == 0)
        {
            // Edge case: the last shifted element is "Zero" so we wont add new Zero infont of it
            arr[i + possibleZerosCount - 1] = 0;
            possibleZerosCount--;
            if (possibleZerosCount == 0)
                break;
        }
    }
}



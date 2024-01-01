static int GetMax(int num1, int num2)
{
    return (num1 > num2) ? num1 : num2;
}


int[] nums = [-15, -6, -3, -2, 0, 0, 1, 2, 5, 6, 8, 9];
int posNums = 0;
int negNums = 0;

for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] < 0)
    {
        negNums++;
    }
    else if (nums[i] > 0)
    {
        posNums++;
    }
}

Console.WriteLine("Max is: " + GetMax(posNums, negNums).ToString());







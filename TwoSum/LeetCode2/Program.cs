int[] TwoSum(int[] nums, int target) {
    int[] result = new int[2];
    for (int i = 0; i < nums.Length; i++) {
        for(int j = i + 1; j < nums.Length; j++) {
            if (nums[i] + nums[j] == target) {
                result[0] = i;
                result[1] = j;
                return result;
            }
        }
    }
    result[0] = -1;
    result[1] = -1;
    return result;
}


int[] nums = [ 2, 7, 11, 15 ];
int target = 70;

int[] result = TwoSum(nums, target);
Console.WriteLine(result[0]);
Console.WriteLine(result[1]);

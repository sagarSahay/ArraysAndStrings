namespace Search2DMatrix
{
    public class Solution
    {
        public bool SearchMatrix(int[][] matrix, int target) {
        
            if(matrix.Length == 0){
                return false;
            }
            for(int i=0; i< matrix.Length;i++){
                if(matrix[i].Length > 0){
                    if(target >= matrix[i][0]){
                        if(target == matrix[i][0]){
                            return true;
                        }
                        return BinarySearch(matrix[i], target);
                    }
                } 
            }
        
            return false;
        }
    
        private bool BinarySearch(int[] nums, int target){
            var start = 0;
            var end = nums.Length -1;
        
            while(start<=end){
                var mid = start+ (end-start)/2;
                if(nums[mid] == target){
                    return true;
                }
                if(target > nums[mid]){
                    start = mid +1;
                }
                else
                {
                    end= mid-1;
                }
            }
        
            return false;
        }
    }
}
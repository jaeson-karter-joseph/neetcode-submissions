public class Solution {
    public bool IsValidSudoku(char[][] board) {
        // validate rows
        for (int row = 0; row < 9; row++) {
            HashSet<char> seen = [];
            for (int col = 0; col < 9; col++) {
                char num = board[row][col];
                if (num == '.')
                    continue;
                if (!seen.Add(num)) {
                    return false;
                }
            }
        }
        // Validate columns
        for (int col = 0; col < 9; col++) {
            HashSet<char> seen = [];

            for (int row = 0; row < 9; row++) {
                char num = board[row][col];

                if (num == '.')
                    continue;

                if (!seen.Add(num))
                    return false;
            }
        }

        // validate box

        for(int startRow = 0; startRow < 9; startRow+=3){
            for(int startCol = 0; startCol < 9; startCol+=3){
                HashSet<char> seen = [];
                for(int row = startRow; row < startRow + 3 ; row++){
                    for(int col = startCol; col < startCol + 3; col++){
                        char num = board[row][col];
                        if(num == '.') continue;
                        if(!seen.Add(num)) return false;
                    }
                }
            }
        }

        return true;
    }
}

public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var rows = new HashSet<int>[9];
        var cols = new HashSet<int>[9];
        var boxes = new HashSet<int>[9];

        for(int i = 0; i < 9;i++){
            rows[i] = new HashSet<int>();
            cols[i] = new HashSet<int>();
            boxes[i] = new HashSet<int>();
        }
        for(int i =0; i< 9; i++){
            for(int j =0; j < 9; j++){
                if(board[i][j] == '.'){
                    continue;
                }
                var box  = (i/3) *3 + (j/3);
                if( rows[i].Contains(board[i][j]) || 
                    cols[j].Contains(board[i][j]) || 
                    boxes[box].Contains(board[i][j])
                ){
                    return false;
                }
                else{
                    rows[i].Add(board[i][j]);
                    cols[j].Add(board[i][j]);
                    boxes[box].Add(board[i][j]);
                }
            }
        }
        return true;
    }
}

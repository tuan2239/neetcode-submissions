public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var row = new HashSet<int>[9];
        var col = new HashSet<int>[9];
        var box = new HashSet<int>[9];
        for(int i=0; i < 9; i++){
            row[i] = new HashSet<int>();
            col[i] = new HashSet<int>();
            box[i] = new HashSet<int>();
        }
        for(int i=0; i < 9; i++){
            for(int j=0; j < 9; j++){
                if(board[i][j] =='.'){
                    continue;
                }
                var boxnum  = (i/3)*3+(j/3);
                var num = board[i][j]-'0';
                if(row[i].Contains(num) || col[j].Contains(num) || box[boxnum].Contains(num)){
                    return false;
                }
                
                row[i].Add(num);
                col[j].Add(num);
                box[boxnum].Add(num);
            }
        }
        return true;
    }
}

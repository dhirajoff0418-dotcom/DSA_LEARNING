public class Solution {
    public IList<int> DiffWaysToCompute(string expression) {
        List<int> result = new List<int>();
        
        // Base case: agar expression me koi operator nahi hai (sirf number hai)
        bool hasOperator = false;
        for (int i = 0; i < expression.Length; i++) {
            char c = expression[i];
            if (c == '+' || c == '-' || c == '*') {
                hasOperator = true;
                break;
            }
        }
        
        if (!hasOperator) {
            result.Add(int.Parse(expression));
            return result;
        }
        
        for (int i = 0; i < expression.Length; i++) {
            char c = expression[i];
            
            if (c == '+' || c == '-' || c == '*') {
                string leftExpr = expression.Substring(0, i);
                string rightExpr = expression.Substring(i + 1);
                
                IList<int> leftResults = DiffWaysToCompute(leftExpr);
                IList<int> rightResults = DiffWaysToCompute(rightExpr);
                
                foreach (int left in leftResults) {
                    foreach (int right in rightResults) {
                        int computed = 0;
                        if (c == '+') computed = left + right;
                        else if (c == '-') computed = left - right;
                        else if (c == '*') computed = left * right;
                        
                        result.Add(computed);
                    }
                }
            }
        }
        
        return result;
    }
}
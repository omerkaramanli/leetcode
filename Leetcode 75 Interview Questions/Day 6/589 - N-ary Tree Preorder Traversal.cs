/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val,IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    public IList<int> Preorder(Node root) {
        Stack<Node> stack = new Stack<Node>();
        List<int> res = new List<int>();
        
        if(root == null) return res;
        
        stack.Push(root);        
        while(stack.Count>0){
            var currNode = stack.Pop();
            //Console.WriteLine($"val: {currNode.val}");
            res.Add(currNode.val);
            
            foreach(var node in currNode.children.Reverse()){
                if(node!=null){
                    stack.Push(node);
                }
            }
        }
        
        
        return res;
    }
}
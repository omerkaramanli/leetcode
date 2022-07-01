/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}
*/

public class Solution {
    public Node Connect(Node root) {
        if(root == null){return root;}
        if(root.right == null){return root;}
        
        if(root.left.next == null){
            root.left.next = root.right;
        }
        if(root.next != null){
            root.right.next = root.next.left;
        }
        
        Connect(root.left);
        Connect(root.right);
        
        return root;


    }
}
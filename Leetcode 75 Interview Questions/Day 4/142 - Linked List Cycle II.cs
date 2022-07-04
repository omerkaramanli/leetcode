/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public ListNode DetectCycle(ListNode head) {
        var hs = new HashSet<ListNode>();
        
        var node = head;
        
        while(node!=null){
            if(!hs.Contains(node))
                hs.Add(node);
            else
			    return node;
            node = node.next;
        }
        return null;
        
        /*if (head == null || head.next == null) return null;
        var fast = head;
        var slow = head;
        bool isCycle = false;
        while(fast!=null && fast.next!=null){
            slow = slow.next;
            fast = fast.next.next;
            if(fast == slow){
                isCycle = true;
                break;
            }
        }
        
        
        if(isCycle){
            slow = head;
            while(head!=fast){
                slow=slow.next;
                fast=fast.next;
            }
        }
        else return null;
        
        return fast;*/
        
    }
}
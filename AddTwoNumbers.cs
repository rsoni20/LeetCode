// https://leetcode.com/problems/add-two-numbers/submissions/

 //Definition for singly-linked list.
  public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
    }
  }
 
public class AddTwoNumbers {
    public static ListNode Execute(ListNode l1, ListNode l2) {
        var head = new ListNode(0);
        var current = head;
        var p = l1;
        var q = l2;
        var carry = 0;
        
        while(p != null || q != null)
        {
            int x = (p != null) ? p.val : 0;
            int y = (q != null) ? q.val : 0;
            var sum = x + y + carry;
            carry = sum / 10;
            current.next = new ListNode(sum % 10);
            current = current.next;
            if (p != null) p = p.next;
            if (q != null) q = q.next;
        }
        
        if (carry > 0) {
            current.next = new ListNode(carry);
        }
        
        return head.next;
    }
}
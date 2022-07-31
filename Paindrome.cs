

ListNode head = new ListNode();
head.val = 0;
head.next = new ListNode();
head.next.val = 1;
head.next.next = new ListNode();
head.next.next.val = 2;

head.next.next.next = new ListNode();
/*head.next.next.next.val = 2;
head.next.next.next.next = new ListNode();
head.next.next.next.next.val = 1;
head.next.next.next.next.next = new ListNode();
*/Console.WriteLine(Mew.IsPalindrome(head));

class Mew{
    public static bool IsPalindrome(ListNode head)
{
    int num1 = 0;
        ListNode n = head.next;
    while (n.next != null)
    {
            num1 = num1 * 10 + n.val;

            n = n.next;
    }

        int ll = 1,lll = num1.ToString().Length, r = 0,l;
        for (int i = 0; i < lll-1; i++)
        {
            ll *= 10;
        }

        for (int i = 0; i < num1.ToString().Length/2; i++)
        {

            int rr = 1;
            for (int j = 0; j < i+1; j++)
            {
                rr *= 10;
            }
                r = num1 % rr;
            if (i!= 0)
            {
                r /= i*10;
            }
            
            l = num1 / ll%10;
            Console.WriteLine($"l = {l} and r = {r} , i = {i}");
            if (l==r)
            {
                ll /= 10;
                continue;
                
            }
            else
            {
                return false;
            }

            
        }
        return true;
    }
    
}
public class ListNode
{
     public int val = 0;
 public ListNode next;
 public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
        }
 }

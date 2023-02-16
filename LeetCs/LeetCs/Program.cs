

/*ListNode head = new ListNode();
head.val = 2;
head.next = new ListNode();
head.next.val = 4;
head.next.next = new ListNode();
head.next.next.val = 9;
head.next.next.next = new ListNode();

ListNode head2 = new ListNode();
head2.val = 5;
head2.next = new ListNode();
head2.next.val = 6;
head2.next.next = new ListNode();
head2.next.next.val = 4;
head2.next.next.next = new ListNode();
head2.next.next.next.val = 9;
head2.next.next.next.next = new ListNode();*/
ListNode head = new ListNode();
head.val = 5;
head.next = new ListNode();
head.next.val = 6;
head.next.next = new ListNode();


ListNode head2 = new ListNode();
head2.val = 5;
head2.next = new ListNode();
head2.next.val = 4;
head2.next.next = new ListNode();
head2.next.next.val = 9;
head2.next.next.next = new ListNode();



/*ListNode n = Mew.AddTwoNumbers(head, head2);*/
/*while (n!= null)
{
    Console.Write(n.val);
    n = n.next;
}*/
Mew.Pailindrome(212);

class Mew{
    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        int tn = 0, carry = 0; string str = "";
        while (l1 != null || l2 != null)
        {
            
            int val = 0;
            val = l1 != null ? l1.val : 0;
            val += l2 != null ? l2.val : 0;


            val = val  + carry;







            Console.WriteLine($"tn is {tn} , and adding value is = {val}");
            

            if (val > 9)
            {
                if (val == 10 && tn == 0)
                {
                    tn = tn * 10 + val/10;
                    carry = val % 10;
                }
                else
                {
                    carry = val / 10;
                    tn = tn * 10 + (val % 10);
                }
                
                
                

            }
            else
            {
                tn = (tn * 10) + (val);
            }

            Console.WriteLine($" carry is {carry}");
            Console.WriteLine("break");

            if (l1 != null)
            {
                l1 = l1.next;


            }
            if (l2 != null)
            {
                l2 = l2.next;
            }

            if (l1 == null && l2 == null && carry > 0)
            {
                tn = tn * 10 + carry;
            }



        }
        Console.WriteLine($"this is tn = {tn}");
        str = tn.ToString();
        l1 = new ListNode();
        l2 = new ListNode();
        l2 = l1;
        foreach (var item in str)
        {
            l1.next = new ListNode(int.Parse(item.ToString()));
            l1 = l1.next;
        }
        return l2.next;

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
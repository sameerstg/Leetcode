using System;

namespace Leetcs2
{
    

  public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
      }
  }
    class Program
    {
        static void Main(string[] args)
        {

            string strs = "{([{}])}{}({})";
            Console.WriteLine(IsValid(strs));
            bool IsValid(string s)
            {
                string sl = "";
                for (int i = 0; i < s.Length; i++)
                {
                    if (sl == "" || s[i] != sl[sl.Length-1])
                    {
                        if (s[i] == '(')
                        {
                            sl += ')';
                        }
                        else if (s[i] == '{')
                        {
                            sl += '}';
                        }
                        else if (s[i] == '[')
                        {
                            sl += ']';
                        }
                        else
                        {
                            return false;
                        }
                        continue;
                    }
                    else if (s[i] == sl[sl.Length-1])
                        {
                            sl = sl.Substring(0, sl.Length - 1);
                        }
                    
                        

                }
                
                if (sl == "")
                {
                    return true;
                }
                else return false;
            }


        }
    }
}

namespace Palindrome_Linked_List
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            Node node1 = new Node();
            Node node2 = new Node();
            Node node3 = new Node();
            Node node4 = new Node();
            Node node5 = new Node();
            node1.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node5;
            node1.value = 1;
            node2.value = 2;
            node3.value = 3;
            node4.value = 2;
            node5.value = 1;

            Node head = node1;
            bool result = IsPalindrome(head);
            Console.WriteLine(result);




        }

        public static bool IsPalindrome(Node node)
        {
            List<int> values = new List<int>();

            var temp = node;

            while (temp != null)
            {
                values.Add(temp.value);
                // use temp.value
                temp = temp.next;

            }
            int left = 0;
            int right = values.Count - 1;
            while (left < right)
                if (values[left] != values[right])
                    return false;
                else
                {
                    left++;
                    right--;
                }
            return true;
        }
    }
}

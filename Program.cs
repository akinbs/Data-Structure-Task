using System; 

namespace VeriYapilariOdev2
{
    class Program
    {
        static void Main(string[]args)
        {
            MyList CircularList = new MyList();
            int UserValue;
            Console.Write("Type an int value: ");

            UserValue = int.Parse(Console.ReadLine()); 
            for(int i = UserValue; i <= UserValue + 100; i++)
            {
                CircularList.AddElemnent(i);
            }
            Console.WriteLine("Creating a list...");
            CircularList.ShowList();
            
            


            Console.ReadKey();
        }
    } 
    class Node
    {
        public int data;
        public Node next;
        public Node prev;

        public Node(int data)
        {
            this.data = data;
            this.next = null;
            this.prev = null;

        } 

        
    }
    class MyList
    {
        public Node head;
        public Node tail;
        public MyList()
        {
            this.head = null;
            this.tail = null; 

        } 
        public void AddElemnent(int data)
        {
            Node element = new Node(data); 
            if(head == null)
            {
                head = tail = element;

                tail.next = head;
                tail.prev = head;
                head.next = tail;
                head.prev = tail;
                Console.WriteLine("List has been created.");
            }
            else
            {
                tail.next = element;
                element.prev = tail;
                tail = element;
                tail.next = head;
                head.prev = tail;
                
            }
        }
        public void ShowList()
        {
            if(head == null)
            {
                Console.WriteLine("It's empty");
            }
            else
            {
                Node temp = head;
                while (temp != tail)
                {
                    Console.Write(temp.data + " > ");
                    temp = temp.next;
                }
                Console.Write(temp.data + " last ");
            }
        }
    }
}

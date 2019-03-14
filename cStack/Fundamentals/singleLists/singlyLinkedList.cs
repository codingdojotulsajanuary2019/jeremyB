public class SinglyLinkedList
{
    public SllNode Head;
    public SinglyLinkedList() 
    {
        Head = null;
        // your code here
    }
    // SLL methods go here. As a starter, we will show you how to add a node to the list.
    public void Add(int value) 
    {
        SllNode newNode = new SllNode(value);
        if(Head == null) 
        {
            Head = newNode;
        } 
        else
        {
            SllNode runner = Head;
            while(runner.Next != null) {
                runner = runner.Next;
            }
            runner.Next = newNode;
        }
    }   

    public void Remove()
    {
        if(Head ==null)
        {
            Console.WriteLine("There are no nodes in the list to remove.");
        }
        else if(Head.Next == null)
        {
            Head = null;
        }
        else
        {
            SllNode runner = Head;
            while(runner.Next.Next !=null)
            {
                runner = runner.Next;
            }
            runner.Next = null;
        }
    }

    public void PrintValues()
    {
        if(Head ==null)
        {
            Console.WriteLine("There are no nodes in the list.");
        }
        else if(Head.Next == null)
        {
            Console.WriteLine(Head.Value);
        }
        else
        {
            SllNode runner = Head;

            while(runner !=null)
            {
                Console.WriteLine(runner.Value);
                runner = runner.Next;
            }
        }
    }
}


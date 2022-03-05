using System;

class Node
{
    public int data;
    public Node next;
    public Node prev;
    public Node(int data)
    {
        this.data = data;
        this.prev = null;
        this.next = null;
    }
}

class LinkedList
{
    public Node head;
    public Node tail;
    public int length = 0;
    public LinkedList()
    {
        this.head = null;
        this.tail = null;
    }

    public void Add(int data)
    {
        Node newNode = new Node(data);
        if (this.head == null)
        {
            this.head = newNode;
            this.tail = newNode;
        }
        else
        {
            this.tail.next = newNode;
            newNode.prev = this.tail;
            this.tail = newNode;
        }
        this.length++;
    }

    public void InsertAtIndex(int index, int data)
    {
        if (index > this.length)
        {
            Console.WriteLine("\nIndex out of range");
            return;
        }

        Node newNode = new Node(data);
        Node current = this.head;
        int count = 0;

        if (index == 0)
        {
            newNode.next = current;
            current.prev = newNode;
            this.head = newNode;
        }
        else if (index == this.length)
        {
            while (count < index )
            {
                current = current.next;
                count++;
            }
            current.next = newNode;
            newNode.prev = current;
            this.tail = newNode;
        }
        else
        {
            while (count < index - 1)
            {
                current = current.next;
                count++;
            }
            newNode.next = current.next;
            current.next.prev = newNode;
            newNode.prev = current;
            current.next = newNode;
        }
        Console.WriteLine();
    }

    public void DeleteAtIndex(int index)
    {
        if (this.head == null)
        {
            Console.WriteLine("List is empty");
        }
        else
        {
            int count = 0;
            Node current = this.head;
            while (current != null)
            {
                if (count == index)
                {
                    Node prev = current.prev;
                    Node next = current.next;
                    if (prev != null)
                    {
                        prev.next = next;
                    }
                    else
                    {
                        this.head = next;
                    }

                    if (next != null)
                    {
                        next.prev = prev;
                    }
                    else
                    {
                        this.tail = prev;
                    }
                    break;
                }
                current = current.next;
                count++;
            }
        }
        Console.WriteLine();
    }

    public void Print()
    {
        Node current = this.head;
        while (current != null)
        {
            Console.Write(current.data + " ");
            current = current.next;
        }
    }

    public static void Main(string[] args)
    {
        LinkedList list = new LinkedList();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        list.Add(5);
        Console.WriteLine("Daftar Linked List :");
        list.Print();
        list.InsertAtIndex(0, 50);
        Console.WriteLine("\nSetelah Insert di Head");
        list.Print();
        list.InsertAtIndex(5, 20);
        Console.WriteLine("\nSetelah Insert di Tail");
        list.Print();
        list.InsertAtIndex(3, 100);
        Console.WriteLine("\nSetelah Insert di Index ke 3");
        list.Print();
        list.DeleteAtIndex(0);
        Console.WriteLine("\nSetelah Delete Head");
        list.Print();
        list.DeleteAtIndex(6);
        Console.WriteLine("\nSetelah Delete Tail");
        list.Print();
        list.DeleteAtIndex(2);
        Console.WriteLine("\nSetelah Delete di Index ke 2");
        list.Print();
        Console.ReadLine();
    }
}
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
    public Node top;
    public LinkedList()
    {
        this.top = null;
    }
    public void Add(int data)
    {
        Node newNode = new Node(data);
        if (this.top == null)
        {
            this.top = newNode;
        }
        else
        {
            this.top.next = newNode;
            newNode.prev = this.top;
            this.top = newNode;
        }
    }
    public void Remove()
    {
        if (this.top == null)
        {
            Console.WriteLine("List is empty");
        }
        else
        {
            this.top = this.top.prev;
        }
    }
    public void Print()
    {
        Node current = this.top;
        while (current != null)
        {
            Console.Write(current.data + " ");
            current = current.prev;
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
        list.Remove();
        Console.WriteLine("\nDaftar Linked List :");
        list.Print();
        list.Remove();
        Console.WriteLine("\nDaftar Linked List :");
        list.Print();
        list.Remove();
        Console.WriteLine("\nDaftar Linked List :");
        list.Print();
        list.Remove();
        Console.WriteLine("\nDaftar Linked List :");
        list.Print();
        list.Remove();
        Console.WriteLine("\nDaftar Linked List :");
        list.Print();
    }
}
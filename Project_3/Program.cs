﻿//khởi tạo class Node gồm thuộc tính data và next
public class Node
{
    public int data;
    public Node next;

    public Node(int data)
    {
        this.data = data;
        this.next = null;
    }
}

//khởi tạo class Linkedlist bao gồm các phương thức trong linkedlist 
public class LinkedList
{
    private Node head;
    public LinkedList()
    {
        head = null;
    }

    public void PushBack(int data) //hàm chèn vào phía sau
    {
        Node newNode = new Node(data); //khởi tạo node mới với tham chiếu là data
        if (head == null) head = newNode;//nếu head chưa có gì thì gán head cho node mới vừa tạo

        else //ngược lại nếu head đã tham chiếu tới một node thì thực hiện các bước
        {
            Node tmp = head;//*B1:  copy head để thực hiện duyệt tìm node cuối cùng trong danh sách
            while (tmp.next != null)
            {
                tmp = tmp.next;
            }//khi kết thúc vòng lập, vị trí của tmp hiện tại chính là node cuối cùng
            tmp.next = newNode;//*B2: cho node cuối cùng này trỏ tới node vừa tạo

        }

    }

    public void Show()//hàm duyệt qua từng phần tử của linkedlist
    {
        //*tương tự như trên
        Node tmp = head;
        while (tmp != null)
        {
            Console.Write($"{tmp.data} ");
            tmp = tmp.next;
        }
    }
}

public class Program
{
    public static void Main()
    {
        LinkedList mylist1 = new LinkedList();//khởi tạo đối tượng mylist1 có kiểu LinkedList
        for (int i = 0; i < 10; i++)
        {
            mylist1.PushBack(i);//gọi hàm pushback và gán giá trị cho mỗi lần gọi
        }
        mylist1.Show();
    }
}
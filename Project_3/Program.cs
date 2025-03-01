//khởi tạo class Node gồm thuộc tính data và next
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

    public void pushFront(int data)
        {
            Node newNode = new Node(data);
            if(head == null)
                head = newNode;
            else{
                newNode.next = head.next;
                head = newNode;
            }
        }
    public void insert(int data, int pos)
        {
            Node newNode = new Node(data);
            
            if(head == null)
                head=newNode;
            else
            {
                Node tmp = head;
                int count=0;                //Điếm vị trí đã duyệt
                
                if(pos == 0)                //Sử dụng Pushfront nếu nó ở vị trí là 0;
                {
                    pushFront(data);
                } else {
                    while(tmp.next != null)
                    {   
                        if(count == pos-1)              //Nếu đang duyệt đến phần tử trước vị trí muốn chèn
                        {
                            newNode.next = tmp.next;
                            tmp.next=newNode;
                            count++;
                        } else {                        //Nếu không phải vị trí đó thì tiếp tục duyệt
                            tmp=tmp.next;
                            count++;
                        }
                    }   
                }
                
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
            mylist1.insert(20,3);
        }
        mylist1.Show();
    }
}
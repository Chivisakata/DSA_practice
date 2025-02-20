//Chivisakata's classs
public class MyHouse
{
    //khai báo thuộc tính
    public int count;
    public int max_size;
    public int[] msn;


    //hàm khởi tạo instance
    public MyHouse(int size)
    {
        this.count = 0;
        this.max_size = size;
        msn = new int[size];
  
    }

    //check full
    public bool is_full(int count)
    {
        if (count == msn.Length) return true;
        else return false;
    }

    //chèn vào đầu
    public void push_front(int x)
    {
        if (is_full(count))
        {
            Console.WriteLine("The house is full now!");
        }
        else
        {

            for (int i = count; i > 0; i--)
            {
                msn[i] = msn[i - 1];
            }
            msn[0] = x;
            count++;
        }
    }

    //chèn vào cuối 
    public void push_back(int x)
    {
        if (is_full(count)) Console.WriteLine("The house is full now!");

        else
        {
            msn[count] = x;
            count++;
        }
    }

    //chèn giữa
    public void insert(int x, int position)
    {
        if (is_full(count)) Console.WriteLine("The house is full now!");

        else if (position > msn.Length || position < 1) Console.WriteLine("invalid position!");

        else
        {
            for (int i = count; i > position - 1; i--)
            {
                msn[i] = msn[i - 1];
            }
            msn[position - 1] = x;
            count++;
        }

    }

    //xóa phần tử ở vị trí xác định
    public void pop(int position)
    {
        if (count == 0) Console.WriteLine("The house is empty!");
        else if (position > msn.Length || position < 1) Console.WriteLine("invalid position!");
        else
        {

            for (int i = position; i < msn.Length; i++)
            {
                msn[i - 1] = msn[i];
            }
            count--;
            Console.WriteLine("Deleted!");
        }
    }

    //cập nhật phần tử 
    public void update(int x, int position)
    {
        if (position < 1 || position > count) Console.WriteLine("invalid position!");
        else
        {
            msn[position - 1] = x;
            Console.WriteLine("Updated!");
        }

    }

    //tìm kím phần tử
    public bool search(int value)
    {

        for (int i = 0; i < count; i++)
        {
            if ((msn[i] == value))
            {
                Console.WriteLine($"Found {value}!");
                return true;
            }
        }
        Console.WriteLine($"NotFound {value!}");
        return false;

    }

    //duyệt 
    public void show()
    {
        for (int i = 0; i < count; i++)
        {
            Console.Write($"{msn[i]} ");
        }
    }


}

//viết class ở đây

public class Program
{
    //viết hàm ở đây
    public static void Main()
    {
        MyHouse my_house_1 = new MyHouse(5);
        my_house_1.push_back(5);
        my_house_1.push_back(4);

        MyHouse my_house_2 = new MyHouse(5);
        my_house_2.push_back(3);
        my_house_2.push_back(2);
        my_house_2.push_back(1);

        my_house_1.show();
        Console.WriteLine();
        my_house_2.show();
    }
}


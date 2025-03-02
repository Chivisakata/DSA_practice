public class MyHouse
{
    public int count = 0;
    public int max_size;
    public int[] msn;

    public MyHouse(int size)
    {
        msn = new int[size];
        max_size = size;
    }

    public bool is_full(int count)
    {
        if (count == msn.Length) return true;
        else return false;
    }


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
    public void push_back(int x)
    {
        if (is_full(count)) Console.WriteLine("The house is full now!");

        else
        {
            msn[count] = x;
            count++;
        }
    }

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

    public void update(int x, int position)
    {
        if (position < 1 || position > count) Console.WriteLine("invalid position!");
        else
        {
            msn[position - 1] = x;
            Console.WriteLine("Updated!");
        }

    }
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


    public void duyet()
    {
        for (int i = 0; i < count; i++)
        {
            Console.Write($"{msn[i]} ");
        }
    }


}

public class Program
{
    public static void Main()
    {
        MyHouse my_house_1 = new MyHouse(5);
    }
}


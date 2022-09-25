int Main()
{
    Homework.Palindrome();

    return 0;
}
Main();
class Homework
{
    static public void Palindrome(string num = "19321")
    {
        Console.WriteLine(num.Length);
        int leng = num.Length - 1;
        for(int i = 0; i < num.Length; i++)
        {
            if(num[i] == num[leng] && leng != 0)
                leng--;
            else
                break;
            Console.WriteLine($"{i} | {leng}");
        }
        Console.WriteLine(leng);
        if(leng == 0)
            Console.WriteLine("Number is palindrome.");
        else
            Console.WriteLine("Number isn't a palindrom");
    }
    static public void Cube(int num = 0)
    {

        for(int i = 0; i <= num; i++)
            Console.Write($"|{i*i*i}| ");
        Console.WriteLine();

    }
}

class Distance
{

    public double[] A = {1f,2f,3f};
    public double[] B = {1f,2f,3f};
    public Distance()
    {
        string num = "NULL";
        Console.WriteLine("Enter the coordinates of the first point in 3D space.");
        for(int i = 0; i < 3; i++)
        {
            num = Console.ReadLine();            
            A[i] = System.Double.Parse(num);
        }
            
        Console.WriteLine("Enter the coordinates of the second point in 3D space.");
        num = Console.ReadLine();
        for(int i = 0; i < 3; i++)
        {
            num = Console.ReadLine();            
            B[i] = System.Double.Parse(num);
        }
    }

    public double GetDistance()
    {
        double d = Math.Sqrt(Math.Pow((B[0] - A[0]),2) + Math.Pow((B[1] - A[1]),2) + Math.Pow((B[2] - A[2]),2));
        return d;
    }

}
int Main()
{
    Distance AandB = new Distance();
    
    
    return 0;
}
Main();
class Homework
{
    static public void Palindrome(string num = "12321")
    {
        Console.WriteLine(num.Length);
        int leng = num.Length - 1;
        for(int i = 0; i < num.Length; i++)
        {
            if(num[i] == num[leng] && leng != 0)
                leng--;
            else
                break;
        }
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

    public double[] A;
    public double[] B;


    public Distance(double[] vecA, double[] vecB)
    {
        A = vecA;
        B = vecB;
    }
    public void SetDistance()
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

class LookForPalindrome
{
    
}
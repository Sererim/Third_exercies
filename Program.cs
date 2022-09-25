

int Main()
{
    double[] A = new double[3] {0,0,0};
    double[] B = new double[3] {0,0,0};



    string num = "NULL";

    string key = "-1";
    while(true)
    {
        Console.WriteLine("Enter 1 to find out if number of five digits is a palindrome or not.\n" +
        "Enter 2 to print a list of all cubes from 1 to N.\n" +
        "Enter 3 to find distance between two points in 3D space.\n" +
        "Enter 0 to terminate the program."
        );

        key = Console.ReadLine();

        string pal = "NULL";

        int n = 0;


        switch(key)
        {
            case "1":
                Console.WriteLine("Enter a number to find if it is a palindrome or not.");
                pal = Console.ReadLine();
                Homework.Palindrome(pal);
                break;
            case "2":
                Console.WriteLine("Enter a number to print a list of cubes.");
                pal = Console.ReadLine();
                n = System.Int32.Parse(pal);
                Homework.Cube(n);
                break;
            case "3":
                Console.WriteLine("Enter the coordinates of the first point in 3D space.");
                for(int i = 0; i < 3; i++)
                {
                    num = Console.ReadLine();            
                    A[i] = System.Double.Parse(num);
                }
                Console.WriteLine("Enter the coordinates of the second point in 3D space.");
                for(int i = 0; i < 3; i++)
                {
                    num = Console.ReadLine();            
                    B[i] = System.Double.Parse(num);
                }

                Distance r = new Distance(A,B);
                Console.WriteLine($"The distance between two points in 3D space is {r.GetDistance}");
                break;

            case "0":
                Console.WriteLine("Program is terminated.");
                return 0;

            default:
                break;
        }


    }    
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

    public double GetDistance()
    {
        double d = 0;
        d = Math.Sqrt(Math.Pow((B[0] - A[0]),2) + Math.Pow((B[1] - A[1]),2) + Math.Pow((B[2] - A[2]),2));
        return d;
    }

}

/*

class LookForPalindrome
{

}

*/
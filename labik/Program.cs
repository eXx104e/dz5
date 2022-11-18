internal class Program
{
    static int[] Task6(Dictionary<string, int[]> t)
    {
        string[] month = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
        int[] avg_temperature = new int[12];
        for (int i = 0; i < month.Length; i++)
        {
            avg_temperature[i] = t[month[i]].Sum() / 30;
        }
        foreach (int i in avg_temperature)
        {
            Console.Write(" " + i);
        }
        return avg_temperature;
    }
    static void Task4(char[] str, out int n1, out int n2)
    {
        n1 = 0;
        n2 = 0;
        char[] c = { 'o', 'i', 'a', 'e', 'u', 'y' };
        foreach (char c2 in str)
        {
            if (c.Contains(c2))
                n1++;
            else
                n2++;
        }
        Console.WriteLine("гласные: " + n1);
        Console.WriteLine("согласные: " + n2);
    }
    static int[,] Multiplication(int[,] a, int[,] b)
    {
        if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
        int[,] r = new int[a.GetLength(0), b.GetLength(1)];
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < b.GetLength(1); j++)
            {
                for (int k = 0; k < b.GetLength(0); k++)
                {
                    r[i, j] += a[i, k] * b[k, j];
                }
            }
        }
        return r;
    }
    static LinkedList<LinkedList<int>> Multiply(LinkedList<LinkedList<int>> a, LinkedList<LinkedList<int>> b)
    {
        LinkedList<LinkedList<int>> r = new LinkedList<LinkedList<int>>();
        return r;
    }
    static void Print(int[,] a)
    {
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                Console.Write("{0} ", a[i, j]);
            }
            Console.WriteLine();
        }
    }
    static void Print1(LinkedList<LinkedList<int>> Mtrx)
    {
        foreach (LinkedList<int> subline in Mtrx)
        {
            Console.WriteLine(string.Join(" ", subline.ToArray()));
        }
    }
    static int[] Task3(int[,] t)
    {
        int[] sr = new int[12];
        for (int i = 0; i < 12; i++)
        {
            int cnt = 0;
            for (int j = 0; j < 30; j++)
            {
                cnt += t[i, j];
            }
            sr[i] = cnt / 30;
        }
        sr = sr.OrderBy(x => x).ToArray();
        return sr;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Задание 1");
        char[] smth = File.ReadAllText("D:\\Test.txt").ToArray<char>();
        Task4(smth, out _, out _);
        Console.Clear();


        Console.WriteLine("Задание 2");
        Console.WriteLine("Введите размерность первой матрицы");
        int[,] A = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write("A[{0},{1}] = ", i, j);
                A[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("Введите размерность второй матрицы: ");
        int[,] B = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                Console.Write("B[{0},{1}] = ", i, j);
                B[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("\nМатрица A:");
        Print(A);
        Console.WriteLine("\nМатрица B:");
        Print(B);
        Console.WriteLine("\nМатрица C = A * B:");
        int[,] C = Multiplication(A, B);
        Print(C);
        Console.Clear();


        Console.WriteLine("Задание 3");
        int[,] temp = new int[12, 30];
        Random rnd = new Random();
        for (int i = 0; i < temp.GetLength(0); i++)
        {
            for (int j = 0; j < temp.GetLength(1); j++)
            {
                temp[i, j] = rnd.Next(-10, 30);
            }
        }
        Console.WriteLine(string.Join(",", Task3(temp)));
        Console.Clear();


        Console.WriteLine("Задание 4");
        List<char[]> syms = new List<char[]>();
        syms.Add(smth);
        Task4(syms[0], out _, out _);
        Console.Clear();


        Console.WriteLine("Задание 5");
        LinkedList<LinkedList<int>> A1m = new LinkedList<LinkedList<int>>();
        Console.WriteLine("Введите размерность первой матрицы: ");
        int xA = Convert.ToInt32(Console.ReadLine());
        int yA = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < xA; i++)
        {
            A1m.AddLast(new LinkedList<int>());
        }
        Console.WriteLine("Введите значения матрицы");
        foreach (LinkedList<int> sublist in A1m)
        {
            for (int j = 0; j < yA; j++)
            {
                Console.Write("A[{0},{0}] = ", j);
                sublist.AddLast(Convert.ToInt32(Console.ReadLine()));
            }
        }
        LinkedList<LinkedList<int>> B1m = new LinkedList<LinkedList<int>>();
        Console.WriteLine("Введите размерность второй матрицы: ");
        int xB = Convert.ToInt32(Console.ReadLine());
        int yB = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < xB; i++)
        {
            B1m.AddLast(new LinkedList<int>());
        }
        Console.WriteLine("Введите значения матрицы");
        foreach (LinkedList<int> sublist in B1m)
        {
            for (int j = 0; j < yB; j++)
            {
                Console.Write("A[{0},{0}] = ", j);
                sublist.AddLast(Convert.ToInt32(Console.ReadLine()));
            }
        }
        Print1(A1m);
        Print1(B1m);
        Multiply(A1m, B1m);
        Console.Clear();


        Console.WriteLine("Задание 6");
        Dictionary<string, int[]> Temp = new Dictionary<string, int[]>
        {
            ["Jan"] = Enumerable.Range(-10, 30).OrderBy(a => rnd.Next()).ToArray(),
            ["Feb"] = Enumerable.Range(-10, 30).OrderBy(b => rnd.Next()).ToArray(),
            ["Mar"] = Enumerable.Range(-10, 30).OrderBy(c => rnd.Next()).ToArray(),
            ["Apr"] = Enumerable.Range(-10, 30).OrderBy(d => rnd.Next()).ToArray(),
            ["May"] = Enumerable.Range(-10, 30).OrderBy(e => rnd.Next()).ToArray(),
            ["Jun"] = Enumerable.Range(-10, 30).OrderBy(f => rnd.Next()).ToArray(),
            ["Jul"] = Enumerable.Range(-10, 30).OrderBy(g => rnd.Next()).ToArray(),
            ["Aug"] = Enumerable.Range(-10, 30).OrderBy(h => rnd.Next()).ToArray(),
            ["Sep"] = Enumerable.Range(-10, 30).OrderBy(i => rnd.Next()).ToArray(),
            ["Oct"] = Enumerable.Range(-10, 30).OrderBy(j => rnd.Next()).ToArray(),
            ["Nov"] = Enumerable.Range(-10, 30).OrderBy(k => rnd.Next()).ToArray(),
            ["Dec"] = Enumerable.Range(-10, 30).OrderBy(l => rnd.Next()).ToArray()
        };
        Console.WriteLine(string.Join(",", Task6(Temp)));
        Console.ReadKey();
    }
}

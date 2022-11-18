using System.Security.Cryptography.X509Certificates;
using System.Collections;
class Student
{
    public string surname { get; set; }
    public string name { get; set; }
    public ushort year_birth { get; set; }
    public string exam { get; set; }
    public byte points { get; set; }
}

class Program
{
    static string Vikings(byte[] array1, byte[] array2)
    {
        ushort cnt1 = 0;
        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i] == 5)
            {
                cnt1++;
            }
        }
        ushort cnt2 = 0;
        for (int i = 0; i < array2.Length; i++)
        {
            if (array2[i] == 5)
            {
                cnt2++;
            }
        }
        if (cnt1 == cnt2)
        {
            return "Drinks All Round! Free Beers on Bjorg!";
        }
        else
        {
            return "Ой, Бьорг - пончик! Ни для кого пива!";
        }
    }

    struct Person
    {
        public string name;
        public uint number_passport;
        public string problem;
        public byte temperament;
        public byte mind;
        public Person(string name, uint number_passport, string problem, byte temperament, byte mind)
        {
            this.name = name;
            this.number_passport = number_passport;
            this.problem = problem;
            this.temperament = temperament;
            this.mind = mind;
        }
    }

    static void Main(String[] args)
    {

        Console.WriteLine("Задание 1");
        Dictionary<int, Student> students = new Dictionary<int, Student>
        {
            [0] = new Student { surname = "Бакреев", name = "Сергей", year_birth = 2004, exam = "физика", points = 51 },
            [1] = new Student { surname = "Ильина", name = "Елена", year_birth = 2005, exam = "физика", points = 87 },
            [2] = new Student { surname = "Федоров", name = "Юрий", year_birth = 2004, exam = "информатика", points = 100 },
            [3] = new Student { surname = "Андреев", name = "Роман", year_birth = 2004, exam = "английский", points = 78 },
            [4] = new Student { surname = "Попов", name = "Александр", year_birth = 2005, exam = "информатика", points = 82 },
            [5] = new Student { surname = "Тарасов", name = "Алексей", year_birth = 2004, exam = "информатика", points = 88 },
            [6] = new Student { surname = "Лебедев", name = "", year_birth = 2003, exam = "английский", points = 67 },
            [7] = new Student { surname = "Морозова", name = "Наталья", year_birth = 2004, exam = "информатика", points = 91 },
            [8] = new Student { surname = "Беляев", name = "Николай", year_birth = 2005, exam = "информатика", points = 84 },
            [9] = new Student { surname = "Зайцев", name = "Марк", year_birth = 2004, exam = "английский", points = 58 },
        };
        Console.WriteLine("Введите один из вариантов: \n Новый студент - добавить в список нового студента " +
            "\n Удалить - удаление выбранного студента \n Сортировать - список студентов сортируется по баллам");
        string word = Console.ReadLine();
        if (word == "Новый студент")
        {
            Console.WriteLine("Введите информацию о новом студенте");
            Console.WriteLine("Фамилия");
            string surname = Console.ReadLine();
            Console.WriteLine("Имя");
            string name = Console.ReadLine();
            Console.WriteLine("Год рождения");
            ushort year_birth = ushort.Parse(Console.ReadLine());
            Console.WriteLine("По какому экзамену поступил: информатика/английский/физика");
            string exam = Console.ReadLine();
            Console.WriteLine("Сколько баллов по экзамену");
            byte points = byte.Parse(Console.ReadLine());

            students.Add(10, new Student { surname = surname, name = name, year_birth = year_birth, exam = exam, points = points });
        }
        else if (word == "Удалить")
        {
            Console.WriteLine("Введите через пробел с большой буквы: фамилию и имя удаляемого студента");
            string[] temp = Console.ReadLine().Split(' ');
            string del_surname = temp[0];
            string del_name = temp[1];
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].surname == del_surname && students[i].name == del_name)
                {
                    students.Remove(i);
                }
            }
            foreach (var n in students)
            {
                Console.WriteLine($"Фамилия: {n.Value.surname}, Имя: {n.Value.name}, Год рождения: {n.Value.year_birth}, Экзамен: {n.Value.exam}, Баллы: {n.Value.points}");
            }
        }
        else if (word == "Сортировать")
        {
            var stud_sort = students.OrderBy(student => student.Value.points);
            foreach (var n in stud_sort)
            {
                Console.WriteLine($"Фамилия: {n.Value.surname}, Имя: {n.Value.name}, Год рождения: {n.Value.year_birth}, Экзамен: {n.Value.exam}, Баллы: {n.Value.points}");
            }
        }
        Console.Clear();


        Console.WriteLine("Задание 2");
        byte[] Viking1 = new byte[] { 5, 8, 5, 1, 7, 9, 2, 3, 9, 0, 5, 9, 1, 5, 7, 0, 6 };
        byte[] Viking2 = new byte[] { 3, 5, 2, 6, 5, 1, 5, 7, 9, 1, 3, 2, 5, 1, 8, 2, 5 };
        Console.WriteLine(Vikings(Viking1, Viking2));
        Console.Clear();


        Console.WriteLine("Задание 3");
        Random random = new Random();
        List<Person> turn1 = new List<Person>();
        List<Person> turn2 = new List<Person>();
        List<Person> turn3 = new List<Person>();
        Stack<Person> Sina = new Stack<Person>();
        List<Person> Sina_temp = new List<Person>
        {
            new Person("Святослав", 9014, "подключение отопления", 2, 1),
            new Person("Наташа", 8441, "оплата отопления", 8, 0),
            new Person("Григорий", 2981, "высокие цены", 9, 1),
            new Person("Артем", 5695, "оплата отопления", 5, 0),
            new Person("Ольга", 2958, "подключение отопления", 3, 1),
            new Person("Алиса", 4192, "подключение отопления", 7, 0),
            new Person("Виталий", 2958, "высокие цены", 0, 1)
        };
        for (int i = Sina_temp.Count - 1; i != -1; i--)
        {
            Sina.Push(Sina_temp[i]);
        }
        foreach (Person x in Sina)
        {
            if (x.problem == "подключение отопления")
            {
                if (x.mind == 0)
                {
                    int num1 = random.Next(2, 3);
                    if (num1 == 2)
                    {
                        turn2.Add(x);
                    }
                    else
                    {
                        turn3.Add(x);
                    }
                }
                else
                {
                    turn1.Add(x);
                }
            }
            else if (x.problem == "оплата отопления")
            {
                if (x.mind == 0)
                {
                    int num2 = random.Next(1, 3);
                    if (num2 == 1)
                    {
                        turn1.Add(x);
                    }
                    else if (num2 == 2)
                    {
                        turn1.Add(x);
                    }
                    else
                    {
                        turn3.Add(x);
                    }
                }
                else
                {
                    turn2.Add(x);
                }
            }
            else
            {
                if (x.mind == 0)
                {
                    int num3 = random.Next(1, 2);
                    if (num3 == 1)
                    {
                        turn1.Add(x);
                    }
                    else
                    {
                        turn2.Add(x);
                    }
                }
                else
                {
                    turn3.Add(x);
                }
            }
        }
        for (int i = 1; i < turn1.Count; i++)
        {
            if (turn1[i].temperament >= 5)
            {
                var temp = turn1[i];
                Console.WriteLine($"{turn1[i].name} скандалист, введите сколько людей он/она обгонит (можно обогнать {i} людей)");
                byte num = byte.Parse(Console.ReadLine());
                while (temp.name != turn1[i - num].name)
                {
                    for (int j = i; j > i - num; j--)
                    {
                        (turn1[j], turn1[j - 1]) = (turn1[j - 1], turn1[j]);
                    }
                }
            }
        }

        for (int i = 1; i < turn2.Count; i++)
        {
            if (turn2[i].temperament >= 5)
            {
                var temp = turn2[i];
                Console.WriteLine($"{turn2[i].name} скандалист, введите сколько людей он/она обгонит (можно обогнать {i} людей)");
                byte num = byte.Parse(Console.ReadLine());
                while (temp.name != turn2[i - num].name)
                {
                    for (int j = i; j > i - num; j--)
                    {
                        (turn2[j], turn2[j - 1]) = (turn2[j - 1], turn2[j]);
                    }
                }
            }
        }

        for (int i = 1; i < turn3.Count; i++)
        {
            if (turn3[i].temperament >= 5)
            {
                var temp = turn3[i];
                Console.WriteLine($"{turn3[i].name} скандалист, введите сколько людей он/она обгонит (можно обогнать {i} людей)");
                byte num = byte.Parse(Console.ReadLine());
                while (temp.name != turn3[i - num].name)
                {
                    for (int j = i; j > i - num; j--)
                    {
                        (turn3[j], turn3[j - 1]) = (turn3[j - 1], turn3[j]);
                    }
                }
            }
        }
        Console.Clear();


        Console.WriteLine("Задание 4");
        clsGraph graph = new clsGraph(7);
        graph.AddEdge(0, 1);
        graph.AddEdge(0, 2);
        graph.AddEdge(0, 3);
        graph.AddEdge(1, 0);
        graph.AddEdge(1, 2);
        graph.AddEdge(1, 6);
        graph.AddEdge(2, 0);
        graph.AddEdge(2, 1);
        graph.AddEdge(2, 3);
        graph.AddEdge(3, 0);
        graph.AddEdge(3, 4);
        graph.AddEdge(3, 2);
        graph.AddEdge(4, 3);
        graph.AddEdge(4, 5);
        graph.AddEdge(5, 2);
        graph.AddEdge(5, 4);
        graph.AddEdge(6, 1);
        graph.PrintMatrix();

        Console.WriteLine("BFS начинается с 0:");
        graph.BFS(0);
        Console.WriteLine("DFS начинается с 0:");
        graph.DFS(0);
        Console.ReadKey();
    }

    class clsGraph
    {
        private int cnt_nodes;
        private List<Int32>[] adjacency_nodes;
        public clsGraph(int v)
        {
            cnt_nodes = v;
            adjacency_nodes = new List<Int32>[v];
            for (int i = 0; i < v; i++)
            {
                adjacency_nodes[i] = new List<Int32>();
            }
        }

        public void AddEdge(int v, int w)
        {
            adjacency_nodes[v].Add(w);
        }

        public void BFS(int s)
        {
            bool[] visited = new bool[cnt_nodes];
            Queue<int> queue = new Queue<int>();
            visited[s] = true;
            queue.Enqueue(s);
            while (queue.Count != 0)
            {
                s = queue.Dequeue();
                Console.WriteLine("next->" + s);
                foreach (Int32 next in adjacency_nodes[s])
                {
                    if (!visited[next])
                    {
                        visited[next] = true;
                        queue.Enqueue(next);
                    }
                }
            }
        }

        public void DFS(int s)
        {
            bool[] visited = new bool[cnt_nodes];
            Stack<int> stack = new Stack<int>();
            visited[s] = true;
            stack.Push(s);
            while (stack.Count != 0)
            {
                s = stack.Pop();
                Console.WriteLine("next->" + s);
                foreach (int i in adjacency_nodes[s])
                {
                    if (!visited[i])
                    {
                        visited[i] = true;
                        stack.Push(i);
                    }
                }
            }
        }

        public void PrintMatrix()
        {
            for (int i = 0; i < cnt_nodes; i++)
            {
                Console.Write(i + ":[");
                string s = "";
                foreach (var k in adjacency_nodes[i])
                {
                    s = s + (k + ",");
                }
                s = s.Substring(0, s.Length - 1);
                s = s + "]";
                Console.Write(s);
            }
        }
    }
}
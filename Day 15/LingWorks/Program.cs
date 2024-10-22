using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LingWorks
{
    //class Products
    //{
    //    public int ID { get; set; }
    //    public int Price { get; set; }
    //}
    
    class Employee
    {
        public string  Name { get; set; }
        public int DeptID { get; set; }
    }

    class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1
            //var lst = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var data = lst.Where(x => x % 2 == 0);

            //foreach (var item in data)
            //{
            //    Console.WriteLine(item);
            //}

            //Q2
            //var lst = new List<string> { "Anu", "Adi", "Bob" };
            //var res = lst.Where(x => x.StartsWith("A"));
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            //Q3
            //var data = new List<int> { 1, 2, 4, 5, 6, 7, 3 };
            //var res = data.OrderByDescending(x => x);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            //Q4
            //var data = new List<int> { 1, 2, 4, 5, 6, 7, 3 };
            //var res = data.Select(x => x * x);  
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);  
            //}

            //Q5
            //var data = new List<int> { 1, 2, 4, 5, 6, 7, 3 };
            //var res = data.Where(x => x % 2 == 0).Select(x => x * x).ToList();
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            //Q6
            //var data = new List<string> { "Anu", "Adi", "Bob" };
            //var res = data.FirstOrDefault(x => x.StartsWith("B"));
            //Console.WriteLine(res);

            //Q7
            //var names = new List<string>() { "Anu", "Adi", "Bob" };
            //var grades = new List<int>() { 60, 80, 90 };
            //Dictionary<string, int> Grade = new Dictionary<string, int>();

            //for (int i = 0; i < names.Count; i++)
            //{
            //    Grade.Add(names[i], grades[i]);
            //}
            //var res = Grade.Where(x => x.Value > 80).Select(x => x.Key).ToList();
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            //Q8
            //var data = new List<string>() { "Hi", "Hello", "Happy", "Am" };
            //var res = data.GroupBy(s => s.Length).ToList();
            //foreach (var item in res)
            //{
            //    Console.WriteLine($"{item.Key}:");

            //    foreach (var group in item)
            //    {
            //        Console.Write(group + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Q9
            //var data = new List<int> { 1, 2, 3, 4, 5, 6, 10 };
            //var res = data.Max(x => x);
            //Console.WriteLine(res);

            //Q10
            //var data = new List<int> { 1, 2, 3, 4, 5, 6, 10 };
            //var res = data.Min(x => x);
            //Console.WriteLine(res);

            //Q11
            //var data = new List<int> { 10, 20, 30, 50, 60 };
            //var res = data.Where(x => x>50);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            //Q12
            //var data = new List<int> { 1, -2, 3, 4, -5 };
            //var res = data.Where(x => x > 0);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            //Q13
            //var data = new List<int> { 10, 20, 30, 50, 60 };
            //var res = data.Sum(x => x);
            //Console.WriteLine(res);

            //Q14
            //var data = new List<float> { 10.1f, 20.2f, 30.3f, 50.5f, 60.6f };
            //var res = data.Average();
            //Console.WriteLine(res);

            //Q15
            //var data = new List<int> { 10, 20, 30, 20, 10, 50, 60 };
            //var res = data.Distinct().ToList();
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            //Q16
            //var data = new List<int> { 10, 20, 30, 20, 10, 50, 60 };
            //var res = data.Count(x => x > 10);
            //Console.WriteLine(res);

            //Q17
            //var empId = new List<int>() { 101, 202, 303, 404 };
            //var dept = new List<string>() { "CSE", "ECE", "AE", "IT" };
            //for (int i = 0; i < empId.Count; i++)
            //{
            //    Console.WriteLine($"{empId[i]} - {dept[i]}");
            //}
                                //OR

            //var department = new List<Department>()
            //{
            //    new Department
            //    {
            //        ID = 1,
            //        Name = "Dept 1"
            //    },
            //    new Department
            //    {
            //        ID = 2,
            //        Name = "Dept 2"
            //    }
            //};

            //var employees = new List<Employee>
            //{
            //    new Employee
            //    {
            //        Name = "A",
            //        DeptID = 1
            //    },
            //    new Employee
            //    {
            //        Name = "B",
            //        DeptID = 2
            //    },
            //    new Employee
            //    {
            //        Name = "C",
            //        DeptID= 2
            //    }

            //};

            //var empWithDep = employees.
            //    Join(
            //    department,
            //    e => e.DeptID,
            //    d => d.ID,
            //    (e, d) => new
            //    {
            //        EmployeeName = e.Name,
            //        DepartmentName = d.Name
            //    }
            //    );
            //foreach (var item in empWithDep)
            //{
            //    Console.WriteLine(item.EmployeeName + "-" + item.DepartmentName);
            //}

            //Q18
            //var data = new List<Products>()
            //{
            //    new Products
            //    {
            //        ID = 111,
            //        Price = 2000
            //    },
            //    new Products
            //    {
            //        ID = 222,
            //        Price = 3000
            //    },
            //    new Products
            //    {
            //        ID = 333,
            //        Price = 50
            //    }
            //};

            //var res = data.OrderBy(x => x.Price);

            //foreach (var item in res)
            //{
            //    Console.WriteLine($"ID: {item.ID}, Price: {item.Price}");
            //}

            //Q19
            //var data = new List<int> { 10, 20, 30, 40, 50, 60, 70, 80 };
            //var res = data.Skip(5).Take(3);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            //Q20
            //var names = new List<string>() { "A", "B", "C", "D" };
            //var id = new List<int>() { 1, 2, 3, 4, 5 };

            //var res = names.Zip





        }
    }
}

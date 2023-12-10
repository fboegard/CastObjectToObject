// See https://aka.ms/new-console-template for more information


using Fibonacci;


var random = RandomNumberGenerator.Instance;
var newnumber = random.Generate(1, 100);

Console.WriteLine(newnumber);

//------------------------
var cache = new HashSet<t1>();
    //var c2  = new SortedSet<t1>();
    var c3 = new List<t1>();

    for (int i = 0; i < 10000000; i++)
    {
        //c2.Add(new t1 { key = i, value = i+1});

        cache.Add(new t1 { key = i, value = i +1});
        c3.Add(new t1 { key = i, value = i +1});

    }

    

    Console.WriteLine("VALUE =  " + cache.LastOrDefault().value + " aND kEY " + cache.LastOrDefault().key);
    //Console.WriteLine("VALUE =  " + c2.LastOrDefault().value + " aND kEY " + c2.LastOrDefault().key);
    Console.WriteLine("VALUE =  " + c3.LastOrDefault().value + " aND kEY " + c3.LastOrDefault().key);

    Console.WriteLine("Hello, World!");
   

   // long fib = Fibonaci.Nth(91);
   //Console.WriteLine(fib);
   long fib5 = Fibonaci.Nth(7);
  Console.WriteLine(fib5);

Customer customer = new Customer();
customer.FirstName = "Test";
customer.LastName = "LastTest";
CustomerDTO customerDTO = customer;
Console.WriteLine(customerDTO.FullName);
Console.ReadLine();

public class Customer
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MiddleName { get; set; }

    //public static implicit operator CustomerDTO (Customer customer)
    //{
    //    return new CustomerDTO
    //    {
    //        Id = customer.Id,
    //        FullName = customer.FirstName + customer.MiddleName + customer.LastName
    //    };
    //}
}

public class CustomerDTO
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public DateTime Birthday { get; set; }

    public static implicit operator CustomerDTO(Customer customer)
    {
        return new CustomerDTO
        {
            Id = customer.Id,
            FullName = customer.FirstName + customer.MiddleName + customer.LastName
        };
    }
}
public class t1
{
    public int value { get; set; }
    public int key { get; set; }
}



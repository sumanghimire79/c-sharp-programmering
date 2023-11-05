using System.Xml.Linq;

namespace ValueVsReference_Day4
{

    class person
    {
        public int ID  { get; set; }
        public string name { get; set; }
    }



    class ClassCustomer
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public ClassCustomer(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }
        public void ClassCustomerInfo()
        {
            Console.WriteLine($"Info inside class: ID: {ID}\t Name: {Name}");
        }
    }

    struct StructCustomer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public StructCustomer(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }
        public void StructCustomerInfo()
        {
            Console.WriteLine($"Info inside STRUCT: ID: {ID}\t Name: {Name}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = x;
            Console.WriteLine($"\n x: {x} \t y: {y}");
            x = 7;
            Console.WriteLine($"\n x: {x} \t y: {y}");

            Console.WriteLine("----------------");
            person p1 = new person();
                person p2 = p1;
            p1.ID = 1;
            p1.name = "suman";
            Console.WriteLine($" p1.name: {p1.name} p2.name: {p2.name}");
            p2.name = "chanda";
            Console.WriteLine($" p1.name: {p1.name} p2.name: {p2.name}");
            
            
            person p3 = new person();

            
            
            Console.ReadKey();
        }
    }
}
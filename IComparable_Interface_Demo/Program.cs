namespace IComparable_Interface_Demo{

    class Program{

        public static void Main(){


            Employee [] emp= new Employee[4];
            
                emp[0]= new Employee(1,"Pratik",1000000); 
                emp[1]=new Employee(2 ,"Rutik",1200000);

                emp[2]=new Employee(3,"Ram",200000);
                emp[3]=new Employee(4 ,"Rajesh",300000);

            

           // Array.Sort(emp)

           foreach (Employee e in emp){
            Console.WriteLine(e);
           }


            Product [] p1= new Product[4];
            
                p1[0]= new Product(101,"phone",100); 
                p1[1]=new Product(202,"fan",1200);

                p1[2]=new Product(303,"tv",2000);
                p1[3]=new Product(404 ,"computer",300);

            

           // Array.Sort(emp)

           Console.WriteLine("List of product : ");
          
           foreach (Product p in p1){
            Console.WriteLine(p);
           }

           Console.WriteLine("\nAfter the sort : ");

           Array.Sort(p1); //automatically calls the ToCompare in product class 
           
           
           foreach (Product p in p1){
            Console.WriteLine(p);
           }

        }
    }
}
namespace IComparable_Interface_Demo{

    class Employee : IComparable{

        public int Id{get;set;}
        public string Name {get;set;}
        public decimal Salary {get;set;}

        public Employee(int id , string name, decimal sal){
            this.Id=id;
            this.Name=name;
            this.Salary=sal;
        }

        public override string ToString(){
            return $"{Id } {Name} Salary : {Salary}";
        }
        public int CompareTo(object ? obj){

            Employee e1 = obj as Employee;
            if(this.Salary < e1.Salary){
                return -1;
            }
            else if(this.Salary > e1.Salary){
                return 1 ;
            }

            else {

                     return 0;
            }
           
        }

        // public int CompareTo(object obj){
        //     Employee e1= obj as Employee;

        //     return string.Compare(Name,e1.Name);
        // }
    }
}
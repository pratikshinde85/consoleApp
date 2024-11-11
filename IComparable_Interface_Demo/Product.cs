namespace IComparable_Interface_Demo{

    class Product : IComparable{

        public int ProductId{get;set;}
        public string Name {get;set;}
        public int Quantity {get;set;}

        public Product(int ProductId , string name, int Quantity){
            this.ProductId=ProductId;
            this.Name=name;
            this.Quantity=Quantity;
        }

        public override string ToString(){
            return $"{ProductId } {Name} Quantity: {Quantity}";
        }
        public int CompareTo(object ? obj){

            Product e1 = obj as Product;
            if(this.Quantity < e1.Quantity){
                return -1;
            }
            else if(this.Quantity > e1.Quantity){
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
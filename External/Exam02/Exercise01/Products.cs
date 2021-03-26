namespace External.Exam02.Exercise01 {

    public class Products {

        public string name { get; set; }
        public int price { get; set; }
        public int stock { get; set; }

        public Products(string name, int price, int stock) {

            this.name = name;
            this.price = price;
            this.stock = stock;

        }
        
    }   
}
using System.Collections.Generic;

namespace External.Exam02.Exercise01 {

    public class ProductsDB {

        public Dictionary<int, Products> product_db = new Dictionary<int, Products>() {

            {1, new Products("Pringles", 50, 10)},
            {2, new Products("CocaCola", 20, 10)},
            {3, new Products("Mani", 10, 10)},
            {4, new Products("Oreo", 80, 10)},
            {5, new Products("Palomitas", 40, 10)},
            {6, new Products("Almendras", 100, 10)},
            {7, new Products("Pepsi", 45, 10)},
            {8, new Products("Galletas Saladas", 20, 10)},
            {9, new Products("Lays Campesinas", 40, 10)},
            {10, new Products("Doritos", 50, 10)}

        };

        public void UpdateStock(int id) {

            this.product_db[id].stock = product_db[id].stock - 1;  

        }

        public int CalculateBack(int id, int money) {

            return money - this.product_db[id].price;  

        }

    }
}
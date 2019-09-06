using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterApp
{
    public class Product
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public decimal Price { set; get; }
        public string Description { set; get; }
        public Product()
        {

        }
        public Product(string name, int id, decimal price, string description)
        {
            this.Name = name;
            this.Id = id;
            this.Price = price;
            this.Description = description;
        }
        public override string ToString()
        {
            return $"Name : {Name}, Price : {Price}, Id : {Id}, Description : {Description}";
        }
        public override bool Equals(object obj)
        {
            if (obj != null)
            {
                if (obj is Product)
                {
                    Product other = obj as Product;
                    if (this == other)
                        return true;
                    if (!this.Id.Equals(other.Id))
                        return false;
                    if(!this.Name.Equals(other.Name))
                        return false;
                    if (!this.Price.Equals(other.Price))
                        return false;
                    if (!this.Description.Equals(other.Price))
                        return false;
                    return true;
                }
                else
                    throw new ArgumentException($"argument expected is {this.GetType().Name} but received is {obj.GetType().Name}");

            }
            else
                throw new NullReferenceException($"Expected {this.GetType().Name} but null refernce occured");
        }
        public override int GetHashCode()
        {
            const int prime = 23;
            int hash = this.Id.GetHashCode() * prime;
            hash *= this.Name.GetHashCode();
            return hash;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProductMgmt
{
    public class ProductManagement
    {
        static ProductDbEntities db;

        public ProductManagement()
        {
            db = new ProductDbEntities();
        }

        public Product AddProduct(Product product )
        {
            
            db.Products.Add(product);
            return product;
        }

        public Product RetrieveProduct(int id)
        {
            if(IsExistProduct(id))
            {
                Product product = db.Products.SingleOrDefault(p=>p.Equals(id));
                return product;
            }
            else
            {
                Console.WriteLine("Not found");
                return null;
            }
        }
        public void DeleteProduct(int id)
        {
            if (IsExistProduct(id))
            {
                Product product = db.Products.SingleOrDefault(p => p.Id==id);
                db.Products.Remove(product);
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine("No Such Product exist");
            }
        }
        public Product UpdateProduct(int id)
        {
            Product product = null;
            if (IsExistProduct(id))
            {
                product = db.Products.SingleOrDefault(p => p.Id==id);
    
                db.SaveChanges();
                
            }
            else
            {
                Console.WriteLine("No Such Product exist");
                
            }
            return product; 
        }
        public bool IsExistProduct(int id)
        {
            var pro=db.Products.SingleOrDefault(p => p.Id == id);
            if (pro == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

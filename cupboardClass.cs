using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookSpaceOptimization
{
   public class cupboardClass
    {
        public int capacity;
        public List<int> books=new List<int>();
        public List<string> category= new List<string>();

        public int Capacity { get => capacity; set => capacity = value; }
        public List<string> Category { get => category; set => category = value; }
        public List<int> Books { get => books; set => books = value; }

        public cupboardClass()
        {
            capacity = 0;
        }
       public cupboardClass(int c)
        {
            Capacity = c;
        }
       public void addBook(string c, int b)
        {
            Capacity = Capacity - b;
            Category.Add(c);
            Books.Add(b);
        }
       public void printCupboard()
        {
          
        }
    }
}

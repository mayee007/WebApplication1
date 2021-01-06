using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DAL;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class NameRepository 
    {
        BookContext context;

        public NameRepository(BookContext context)
        {
            this.context = context; 
        }

        public List<Name> getAllNames()
        {
            return context.Names.ToList(); 
        }

        public Name insertName(Name name)
        {
            context.Add(name);
            context.SaveChanges();

            return name; 
        }

        public void deleteName(int id)
        {
            Name name = context.Find<Name>(id); 
            if (name != null)
            {
                context.Remove(name);
                context.SaveChanges();
            }
        }
    }
}

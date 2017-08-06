using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloggingBL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BloggingContext _context;

        public UnitOfWork(BloggingContext bloggingContext, IBlogRepository blogRepo)
        {
            _context = bloggingContext;
            BlogRepo = blogRepo;
        }

        //public IBlogRepository BlogRepo => new BlogRepo(_context);
        public IBlogRepository BlogRepo { get; set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

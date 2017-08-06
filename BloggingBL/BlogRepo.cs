using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloggingBL
{
    public class BlogRepo : Repository<Blog>, IBlogRepository
    {
        public BlogRepo(BloggingContext context) : base(context)
        {
        }

    }
}

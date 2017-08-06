using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloggingBL
{
    public interface IUnitOfWork : IDisposable
    {
        IBlogRepository BlogRepo { get; }
        int Complete();
    }
}

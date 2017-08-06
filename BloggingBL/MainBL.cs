using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloggingBL
{
    public class MainBL
    {
        IUnitOfWork _unitOfWork;

        public MainBL(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Run()
        {
            try
            {
                _unitOfWork.BlogRepo.Add(new Blog()
                {
                    Name = "Blog5"
                });

                _unitOfWork.Complete();

            }
            catch (Exception ex)
            {

                throw;
            }

        }
    }
}
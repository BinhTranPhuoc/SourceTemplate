using System;
using System.Collections.Generic;
using System.Text;

namespace ST.Business
{
    public interface IUnitOfWork
    {
        void SaveChanges();
    }
}

using ST.Entity;
using ST.Utility;
using ST.Utility.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ST.Business
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        public SourceTemplateContext _context { get; }

        public UnitOfWork(SourceTemplateContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async void Dispose()
        {
            await _context.DisposeAsync();
            GC.SuppressFinalize(this);
        }

        public void SaveChanges()
        {
            if (_context.SaveChanges() == 0)
            {
                throw new BusinessException((int)GeneralError.Failed, "UnexpectedError");
            }
        }
    }
}

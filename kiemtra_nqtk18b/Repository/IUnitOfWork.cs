using kiemtra_nqtk18b;
using kiemtra_nqtk18b.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiemtra_nqtk18b.Repository
{
    public interface IUnitOfWork<T> where T : Context
    {
        Context _dbContext { get; }
        void Save();
        void Transaction();
        void RollBack();
        void Commit();
    }
}

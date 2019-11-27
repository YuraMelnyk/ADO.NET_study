using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoLotDAL_4._0.Models;
using AutoLotDAL_4._0.EF;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace AutoLotDAL_4._0.Repos
{
    public class CreditRiskRepo : BaseRepo<CreditRisk>, IRepo<CreditRisk>
    {
        public CreditRiskRepo()
        {
            Table = Context.CreditRisks;
        }

        public int Delete(int id, byte[] timeStamp)
        {
            Context.Entry(new CreditRisk() { CustId = id, Timestamp = timeStamp }).State = EntityState.Deleted;
            return SaveChanges();
        }
        public Task<int> DeleteAsync(int id, byte[] timeStamp)
        {
            Context.Entry(new CreditRisk() { CustId = id, Timestamp = timeStamp }).State = EntityState.Deleted;
            return SaveChangesAsync();
        }
    }
}

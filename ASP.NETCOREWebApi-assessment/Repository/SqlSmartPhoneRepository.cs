using ASP.NETCOREWebAPI_assessment.DBcontext;
using ASP.NETCOREWebAPI_assessment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETCOREWebAPI_assessment.Repository
{
    public class SqlSmartPhoneRepository : ISmartPhoneRepository
    {
        SmartPhoneDbcontext _SmartPhoneDbcontext;
        public SqlSmartPhoneRepository(SmartPhoneDbcontext Dbcontext)
        {
            _SmartPhoneDbcontext = Dbcontext;
        }

        public void AddPhone(SmartPhone smartPhone)
        {
            _SmartPhoneDbcontext.smartPhones.Add(smartPhone);
            _SmartPhoneDbcontext.SaveChanges();
        }

        public List<SmartPhone> GetPhones()
        {
            return _SmartPhoneDbcontext.smartPhones.ToList();
        }

        public SmartPhone GetPhoneById(int id)
        {
            return _SmartPhoneDbcontext.smartPhones.FirstOrDefault(x => x.id == id);
        }

        public void UpdatePhone(SmartPhone smartPhone)
        {
            var phoneChanges = _SmartPhoneDbcontext.smartPhones.Attach(smartPhone);
            phoneChanges.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _SmartPhoneDbcontext.SaveChanges();


        }

        public void DeletePhone(int id)
        {
            SmartPhone smartPhone = GetPhoneById(id);
            _SmartPhoneDbcontext.smartPhones.Remove(smartPhone);
            _SmartPhoneDbcontext.SaveChanges();
        }
    }
}

using ASP.NETCOREWebAPI_assessment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETCOREWebAPI_assessment.Repository
{
    public interface ISmartPhoneRepository
    {
        List<SmartPhone> GetPhones();
        SmartPhone GetPhoneById(int id);
        void AddPhone(SmartPhone smartPhone);
        void UpdatePhone(SmartPhone smartPhone);
        void DeletePhone(int id);
    }
}

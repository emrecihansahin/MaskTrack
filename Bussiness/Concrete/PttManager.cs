using Bussiness.Abstract;
using Entities.Concretre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class PttManager : ISupplierService
    {
        IApplicantService _applicantService;
        public PttManager(IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }
        public void GiveMask(Person person)
        {
            if (_applicantService.CheckPerson != null)
            {
                Console.WriteLine("The mask has given to " + person.Name);
            }
            else
            {
                Console.WriteLine("The mask can not given to this person");
            }
        }
    }
}

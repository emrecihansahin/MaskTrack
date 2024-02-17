﻿using Entities.Concretre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface IApplicantService
    {
        void ApplyForMask(Person person);

        List<Person> GetAll();

        bool CheckPerson(Person person);
    }
}

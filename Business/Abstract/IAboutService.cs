﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAboutService
    {
        List<About> GetAll();
        void Add(About about);
        void Delete(About about);
        void Update(About about);
        About GetById(int id);
    }
}

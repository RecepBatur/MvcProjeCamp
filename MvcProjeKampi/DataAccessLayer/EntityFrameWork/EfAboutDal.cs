﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BusinessLayer.Abstract;

namespace DataAccessLayer.EntityFrameWork
{
    public class EfAboutDal: GenericRepository<About>, IAboutDal
    {

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRental.Repository
{
    public interface IUnitOfWork
    {
        int Commit();
    }
}

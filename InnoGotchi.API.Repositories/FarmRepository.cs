﻿using InnoGotchi.API.Contracts;
using InnoGotchi.API.Entities.Models;
using InnoGotchi.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoGotchi.API.Repositories
{
    public class FarmRepository : RepositoryBase<Farm>, IFarmRepository
    {
        public FarmRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }
    }
}
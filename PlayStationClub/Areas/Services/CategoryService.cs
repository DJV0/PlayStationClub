﻿using PlayStationClub.Areas.Services.Interfaces;
using PlayStationClub.Data;
using PlayStationClub.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayStationClub.Areas.Services
{
    public class CategoryService : GenericService<Category>, ICategoryService
    {
        public CategoryService(PlayStationClubDbContext context) : base(context)
        {

        }
    }
}

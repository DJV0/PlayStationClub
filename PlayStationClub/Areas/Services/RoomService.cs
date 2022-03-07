﻿using PlayStationClub.Areas.Services.Interfaces;
using PlayStationClub.Data;
using PlayStationClub.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayStationClub.Areas.Services
{
    public class RoomService : GenericService<Room>, IRoomService
    {
        public RoomService(PlayStationClubDbContext context) : base(context)
        {

        }
    }
}

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayStationClub.Data
{
    public class PlayStationClubDbContext : IdentityDbContext
    {
        public PlayStationClubDbContext(DbContextOptions<PlayStationClubDbContext> options)
            : base(options)
        {
        }
    }
}

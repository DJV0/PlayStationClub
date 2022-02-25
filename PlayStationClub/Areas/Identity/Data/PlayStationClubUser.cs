using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayStationClub.Areas.Identity.Data
{
    public class PlayStationClubUser : IdentityUser
    {
        [PersonalData]
        public string FullName { get; set; }
    }
}

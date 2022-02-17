using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlayStationClub.Data.Entity;

namespace PlayStationClub.Data.Configuration
{
    public class RoomConfigurator : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.Property(r => r.Name).IsRequired().HasMaxLength(20);
            builder.Property(r => r.Description).IsRequired();
            builder.Property(r => r.PlayersNumber).IsRequired().HasDefaultValue(1);
            builder.Property(r => r.Price).IsRequired();

            builder.HasMany(r => r.Images)
                .WithOne(i => i.Room)
                .HasForeignKey(i => i.RoomId)
                .OnDelete(DeleteBehavior.Cascade);
            //TODO: Add another 3 rooms, change seed data into Image configurator file.
            builder.HasData(
                new Room
                {
                    Id = 1,
                    Name = "fight lobby",
                    Description = "Серьезная игра требует серьезного подхода. UFC, Assassin’s или бессмертный Mortal Kombat – выбирай то, что хочешь, и играй! 50 дюймовый экран, милитари пуфаны, 4 игрока – ничего лишнего, только суть.",
                    PlayersNumber = 4,
                    Price = 90
                }
                );
        }
    }
}

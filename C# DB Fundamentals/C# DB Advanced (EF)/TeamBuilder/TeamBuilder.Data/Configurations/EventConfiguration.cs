﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamBuilder.Models;

namespace TeamBuilder.Data.Configurations
{
    class EventConfiguration : EntityTypeConfiguration<Event>
    {
        public EventConfiguration()
        {
            this.Property(u => u.Name)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(u => u.Description)
                .HasMaxLength(250);

            this.HasRequired(e => e.Creator)
                .WithMany(c => c.CreatedEvents);

            this.HasMany(e => e.ParticipatingTeams)
                .WithMany(t => t.ParticipatedEvents)
                .Map(cfg =>
                {
                    cfg.MapLeftKey("EventId");
                    cfg.MapRightKey("TeamId");
                    cfg.ToTable("EventTeams");
                });
        }
    }
}
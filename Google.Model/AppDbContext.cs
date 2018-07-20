using Google.Model.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace Google.Model
{
    public class AppDbContext : IdentityDbContext<Account, IdentityRole<Guid>, Guid>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CategoryTag> CategoryTags { get; set; }
        public virtual DbSet<Channel> Channels { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<ConfigurationValue> ConfigurationValues { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<Playlist> Playlists { get; set; }
        public virtual DbSet<PlaylistTag> PlaylistTags { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<Video> Videos { get; set; }
        public virtual DbSet<VideoPlaylist> VideoPlaylists { get; set; }
        public virtual DbSet<VideoTag> VideoTags { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
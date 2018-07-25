﻿using System;
using System.ComponentModel.DataAnnotations;
using Google.Common.Enums;
using Google.Service.Dtos.Account;

namespace Google.Service.Dtos.Playlist
{
    public class PlaylistDto: BaseDto
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public string Description { get; set; }
        public PlayListStatusType PlayListStatusType { get; set; }

        [Required]
        public Guid AccountId { get; set; }

        public AccountDto CreatedBy { get; set; }
    }
}
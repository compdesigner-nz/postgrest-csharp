﻿using System;
using Postgrest.Attributes;
using Postgrest.Models;

namespace PostgrestExample.Models
{
    [Table("users")]
    public class User : BaseModel
    {
        [PrimaryKey("username")]
        public string Username { get; set; }

        [Column("data")]
        public string Data { get; set; }

        [Column("catchphrase")]
        public string Catchphrase { get; set; }
    }
}

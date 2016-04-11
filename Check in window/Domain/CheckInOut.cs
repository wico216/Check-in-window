﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_in_window.Domain
{
    public class CheckInOut
    {
        public int Id { get; set; }
        public byte[] Photo { get; set; }
        public string Username { get; set; }
        public DateTime CheckInTime { get; set; }
        public bool ForceCheckOut { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavalBridge.Models
{
    public class ActionState
    {
        public bool Success { get; set; }
        public List<string> Errors { get; set; }
    }
}

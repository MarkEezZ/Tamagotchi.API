﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoGotchi.API.Entities.DataTransferObjects
{
    public class BodyPartDto
    {
        public string Name { get; set; }
        public string FileName { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardService.Application.DTOs.Board
{
    public class BoardCreateDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int OrganizationId { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnRoute.Infrastructure.DTOs
{
    public class GetCounterDeliveryDto
    {
        public Guid CellId { get; set; }
        public Guid OrderId { get; set; }
        public string CellUnlockCode { get; set; }
    }
}

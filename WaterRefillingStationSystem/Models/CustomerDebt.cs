﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterRefillingStationSystem.Models
{
    public class CustomerDebt : SalesDetails
    {
        public int DebtID { get; set; } //Primary Key
        public string Name { get; set; }
        public int Debt { get; set; }
    }
}

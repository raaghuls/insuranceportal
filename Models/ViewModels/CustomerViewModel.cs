﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InsuranceClientPortal.Models.ViewModels
{
    public class CustomerViewModel
    {

        public string Name { get; set; }
        [DataType(DataType.Date)]
        [Display(Name="Application Date")]
        public DateTime AppDate { get; set; }

        public string InsuranceType { get; set; }

        [DataType(DataType.Currency)]
        public double Amount { get; set; }
        [DataType(DataType.Currency)]
        public double Premium { get; set; }

        [DataType(DataType.Date)]
        public DateTime PolicyEndDate { get; set; }
    
        public IFormFile Image { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public string StreetOne { get; set; }
        public string StreetTwo { get; set; }

        public City City { get; set; }
        public int CityId { get; set; }

        public State State { get; set; }
        public int StateId { get; set; }

        public ZipCode ZipCode { get; set; }
        public int ZipCodeId { get; set; }
    }
}
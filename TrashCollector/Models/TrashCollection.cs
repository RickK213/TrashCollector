﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class TrashCollection
    {
        public int TrashCollectionId { get; set; }
        public string PickUpDay { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime VacationStartDate { get; set; }
        public DateTime VacationEndDate { get; set; }
        public Address Address { get; set; }
        public int AddressId { get; set; }

        public ICollection<Profile> UserProfiles { get; set; }

    }
}
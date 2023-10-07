﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Mobile_Score.Models
{
    public class Lectures
    {

            public string Id { get; set; }
            public string TrainingFacilityId { get; set; }
            public string Code { get; set; }
            public string Name { get; set; }
            public bool Gender { get; set; }
            public DateTime DateOfBirth { get; set; }
            public string Email { get; set; }
            public string ImageUrl { get; set; }
            public DateTime CreatedDate { get; set; }
            public int Status { get; set; }
            public string TrainingFacilityName { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MelonieMorrell
{
    public static class Samples
    {
        public static void Sample229()
        {
            var employee = new Employee()
            {
                FirstName = "Sample",
                LastName = "Student",
                Id = 1
            };
            employee.SayName();

        }
    }

}

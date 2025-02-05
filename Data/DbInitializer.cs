﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheMoonshineCafe.Models;

namespace TheMoonshineCafe.Data
{
    public class DbInitializer
    {
        public static void Initialize(MoonshineCafeContext context)
        {
            context.Database.EnsureCreated();

            if (context.Events.Any())
            {
                return;
            }

            var bands = new Band[]
            {
                new Band{bandName="Test1", website="testSite", bandInfo="They are a test"},
                new Band{bandName="Test2", website="testSite2", bandInfo="They are a test2"},
                new Band{bandName="Test3", website="testSite3", bandInfo="They are a test3"}
            };
            foreach (Band b in bands)
            {
                context.Bands.Add(b);
            }
            context.SaveChanges();

            var events = new Event[]
            {
                
            };
            foreach(Event e in events)
            {
                context.Events.Add(e);
            }
            context.SaveChanges();

            var admins = new Admin[]
            {
                new Admin{name="Derek", email="schunicd@gmail.com", phoneNumber="1234567890", accessLevel=1},
                new Admin{name="Harpreet", email="preet.ghuman911@gmail.com", phoneNumber="5551112318", accessLevel=1},
                new Admin{name="Mohammed", email="mohammed.a.r.musleh@gmail.com", phoneNumber="3321568974", accessLevel=1},
                new Admin{name="Admin", email="TheMoonshineTest@outlook.com", phoneNumber="1234567890", accessLevel=1}
            };
            foreach (Admin a in admins)
            {
                context.Admins.Add(a);
            }
            context.SaveChanges();

        }
    }
}

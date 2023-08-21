using SimpleTracker.Api.Models;
using System;
using System.Linq;

namespace SimpleTracker.Api.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SimpleTrackerContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
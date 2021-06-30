using Northwind.Application.Common.Interfaces;
using System;

namespace Northwind.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}

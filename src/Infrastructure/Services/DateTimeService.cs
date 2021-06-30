using CER.Application.Common.Interfaces;
using System;

namespace CER.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}

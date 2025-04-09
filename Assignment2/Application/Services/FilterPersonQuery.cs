using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class FilterPersonQuery
    {
        public string? Name { get; set; }
        public GenderType? Gender { get; set; }
        public string? BirthPlace { get; set; }
    }
}

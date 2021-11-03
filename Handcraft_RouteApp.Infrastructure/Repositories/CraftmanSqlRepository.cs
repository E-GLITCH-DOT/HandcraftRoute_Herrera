using System;
using System.Collections.Generic;
using System.Linq;
using Handcraft_RouteApp.Infrastructure.Data;
using Handcraft_RouteApp.Domain.Entities;

namespace Handcraft_RouteApp.Infrastructure.Repositories
{
    public class CraftmanSqlRepository
    {
        private readonly HandCraftRouteContext _context;
        
        public CraftmanSqlRepository()
        {
            _context = new HandCraftRouteContext();
        }

        public IEnumerable<Craftman> GetAll()
        {
            var artesain = _context.Craftmen.Select(ct => ct);
            return artesain;
        }

        public IEnumerable<Craftman> GetByName(string firstName)
        {
            var artesain = _context.Craftmen.Where(ct => ct.FirstName == firstName);

            return artesain;
        }

        public IEnumerable<Craftman> GetByLastName(string lastName)
        {
            var artesain = _context.Craftmen.Where(ct => ct.LastName == lastName);

            return artesain;
        }

        public IEnumerable<Craftman> GetByGender(char gender)
        {
            var artesain = _context.Craftmen.Where(ct => ct.Gender == gender);

            return artesain;
        }
    }
}
using ConcesionariaSystem.Data.Interfaces;
using ConcesionariaSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConcesionariaSystem.Data.Repositories
{
    public class AutoRepository : Repository<Autos>, IAutoRepository
    {
        private readonly ApplicationDbContext _db;
        public AutoRepository(ApplicationDbContext db) : base(db)
        {

        }
    }
}

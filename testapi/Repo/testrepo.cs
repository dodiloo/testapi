using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using testapi.Models;

namespace testapi.Repo
{
    public interface Itestrepo
    {
        IQueryable<TmpNames> Getdata();
        Task<TmpNames> Insert(TmpNames data);

    }
    public class testrepo : Itestrepo
    {

        private pusdatinContext _context;

        public testrepo(pusdatinContext context)
        {
            _context = context;
        }

        public IQueryable<TmpNames> Getdata()
        {
            var test = _context.TmpNames.AsQueryable();

            return test;

        }

        public async Task<TmpNames> Insert(TmpNames data)
        {
            await _context.TmpNames.AddAsync(data);
            await _context.SaveChangesAsync();

            return data;

        }
    }
}

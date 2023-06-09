﻿using Final_SophieTravelManagement.Domain.Entities;
using Final_SophieTravelManagement.Domain.Repositories;
using Final_SophieTravelManagement.Domain.ValueObjects;
using Final_SophieTravelManagement.Infrastructure.EF.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Final_SophieTravelManagement.Infrastructure.EF.Repositories
{
    public class TravelerCheckListRepository : ITravelerCheckListRepository
    {

        private readonly DbSet<TravelerCheckList> _travelerCheckList;
        private readonly WriteDbContext _writeDbContext;

        public TravelerCheckListRepository(WriteDbContext writeDbContext)
        {
            _travelerCheckList = writeDbContext.TravelerCheckList;
            _writeDbContext = writeDbContext;
        }

        public async Task AddAsync(TravelerCheckList travelerCheckList)
        {
            await _travelerCheckList.AddAsync(travelerCheckList);
            await _writeDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(TravelerCheckList travelerCheckList)
        {
            _travelerCheckList.Remove(travelerCheckList);
            await _writeDbContext.SaveChangesAsync();
        }

        public Task<TravelerCheckList> GetAsync(TravelerCheckListId id)
        => _travelerCheckList.Include("_items").SingleOrDefaultAsync(pl => pl.Id == id);

        public async Task UpdateAsync(TravelerCheckList travelerCheckList)
        {
            _travelerCheckList.Update(travelerCheckList);
            await _writeDbContext.SaveChangesAsync();
        }
    }
}

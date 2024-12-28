using AutoMapper;
using DAL.Context;
using DAL.Repositories.Abstraction;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;


namespace DAL.Repositories.Implementation
{
    public class StatusRepository : IStatusRepository
    {
        private readonly ToDoListContext context;

        private readonly IMapper mapper;


        public StatusRepository(ToDoListContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<List<Status>> GetAllStatusAsync()
        {
            var statuses = await context.Statuses.ToListAsync();

            return mapper.Map<List<Status>>(statuses);
        }
    }
}

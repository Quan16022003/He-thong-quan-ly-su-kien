﻿using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    /// <summary>
    /// Unit of Work Interface.
    /// </summary>
    public interface IUnitOfWork : IAsyncDisposable
    {
        #region Properties

        UserManager<ApplicationUser> UserManager { get; }
        ICategoryEventRepository CategoryEventRepository { get; }
        IEventRepository EventRepository { get; }
        ITicketRepository TicketRepository { get; }
        IOrderRepository OrderRepository { get; }
        IOrderItemRepository OrderItemRepository { get; }
        IOrderTicketRepository OrderTicketRepository { get; }
        IAttendeeRepository AttendeeRepository { get; }

        #endregion

        #region Methods

        Task CompleteAsync();

        #endregion
    }
}

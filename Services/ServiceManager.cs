﻿
using Domain.Entities;
using Domain.Repositories;
using MapsterMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Services.Abtractions;

namespace Services
{
    public sealed class ServiceManager : IServiceManager
    {
        //private readonly Lazy<IOwnerService> _lazyOwnerService;
        private readonly Lazy<IUserService> _lazyUserService;
        private readonly Lazy<IEventService> _lazyEventService;
        private readonly Lazy<ICategoryService> _lazyEventCategoryService;
        private readonly Lazy<ITicketService> _lazyTicketService;
        private readonly Lazy<IAttendeeService> _lazyAttendeeService;
        private readonly Lazy<IOrdersService> _lazyOrdersService;
        public ServiceManager(IUnitOfWork unitOfWork,
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ILoggerFactory loggerFactory,
            IFileService fileService,
            ISlugService slugService)
        {
            _lazyUserService = new Lazy<IUserService>(() => new UserService(unitOfWork));
            _lazyEventService = new Lazy<IEventService>(() => new EventService(unitOfWork, loggerFactory.CreateLogger<EventService>(), fileService, slugService));
            _lazyEventCategoryService = new Lazy<ICategoryService>(() => new CategoryService(unitOfWork, fileService, slugService, loggerFactory.CreateLogger<CategoryService>()));
            _lazyTicketService = new Lazy<ITicketService>(() => new TicketService(unitOfWork, loggerFactory.CreateLogger<EventService>()));
            _lazyAttendeeService = new Lazy<IAttendeeService>(() => new AttendeeService(unitOfWork, loggerFactory.CreateLogger<AttendeeService>()));

            _lazyOrdersService = new Lazy<IOrdersService>(() => new OrdersService(unitOfWork, new Mapper()));
            //_lazyOwnerService = new Lazy<IOwnerService>(() => new OwnerService(repositoryManager));
        }

        //public IOwnerService OwnerService => _lazyOwnerService.Value;
        public IUserService UserService => _lazyUserService.Value;
        public IEventService EventService => _lazyEventService.Value;
        public ICategoryService CategoryService => _lazyEventCategoryService.Value;

        public ITicketService TicketService => _lazyTicketService.Value;
        public IAttendeeService AttendeeService => _lazyAttendeeService.Value;
        public IOrdersService OrdersService => _lazyOrdersService.Value;
    }
}

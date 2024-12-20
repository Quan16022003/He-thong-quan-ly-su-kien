﻿using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Repositories;
using Constracts.DTO;
using Constracts.Home;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Domain.ValueObjects;

namespace Services.Abtractions
{
    public interface IEventService
    {
        Task<IEnumerable<EventDTO>> GetAllEventsAsync();
        Task<IEnumerable<EventDTO>> GetAllEventByOrganizerId(string id);
        Task<IEnumerable<HomeEventDTO>> GetAllEventsComingAsync();
        Task<IEnumerable<HomeEventDTO>> GetAllEventsBestSellingAsync();
        Task<IEnumerable<HomeEventDTO>> GetAllEventsOutstandingAsync();
        Task<IEnumerable<HomeEventDTO>> GetAllEventsSelectedAsync(string? query, int? categoryId, string? city, DateTime? startDate, DateTime? endDate);
        Task<EventDTO> GetEventBySlugAsync(string slug);
        Task<EventDTO> GetEventByIdAsync(int id);

        Task<EventDTO> AddEventAsync(EventDetailDTO eventDetailDTO);

        Task UpdateEventDetailAsync(EventDetailDTO eventDetailDTO);
        Task UpdateEventTiminglAsync(EventTimingDTO eventTimingDTO);
        Task UpdateEventMediaAsync(EventMediaDTO eventMediaDTO, IFormFile? thumbnailFile, IFormFile? coverFile);
        Task UpdateEventVenueAsync(EventVenueDTO eventVenueDTO);
        Task<Result<int>> PublishEvent(int id);
        Task DeleteEventAsync(int id);

    }
}

﻿using Constracts.DTO;
using Domain.Enum;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Abtractions;
using Web.Controllers;
using Web.Utils;
using Web.Utils.ViewsPathServices;

namespace Web.Areas.Dashboard.Controllers.ManageEvents
{
    [Authorize(Policy = "CategoryManagement")]
    [Area("Dashboard")]
    public class CategoryController : BaseController
    {
        private readonly IEventCategoryService _categoryEventService;
        private readonly ISlugService _slugService;

        public CategoryController(
            IPathProvideManager pathProvideManager,
            IServiceManager serviceManager,
            ISlugService slugService) : base(serviceManager)
        {
            ViewPath = pathProvideManager.Get<CategoryController>();
            _categoryEventService = serviceManager.EventCategoryService;
            _slugService = slugService;
        }

        private async Task<IEnumerable<EventCategoryDTO>> FetchCategories(string type = "", string query = "")
        {
            var events = await _categoryEventService.GetAllAsync();
            if (string.IsNullOrEmpty(query)) return events;

            if (type == "Equal")
            {
                return events.Where(e => e.Name!.Equals(query, StringComparison.CurrentCultureIgnoreCase));
            }
            else return events.Where(e => e.Name!.Contains(query, StringComparison.CurrentCultureIgnoreCase));
        }

        [HttpGet]
        public async Task<IActionResult> Index(
            [FromQuery(Name = "searchOption")] string searchType = "",
            [FromQuery(Name = "searchQuery")] string query = "")
        {
            LoadCurrentUser();
            var categories = await FetchCategories(searchType, query);
            return View($"{ViewPath}/Categories.cshtml", categories);
        }

        public IActionResult Add()
        {
            LoadCurrentUser();
            return View($"{ViewPath}/AddCategory.cshtml");
        }

        [HttpPost]
        public async Task<IActionResult> HandleAdd(EventCategoryDTO model)
        {
            if (model == null)
            {
                return BadRequest(
                    new
                    {
                        message = "Category is null"
                    }
                );
            }

            model.Slug = _slugService.GenerateSlug(model.Name!);
            model.ModifiedDate = model.CreatedDate;
            model.Status = true;

            var result = await _categoryEventService.CreateAsync(model);

            return Ok(
                new
                {
                    message = "Create Successfully",
                    redirectUrl = Url.Action(nameof(Index), "Category", new
                    {
                        area = "Dashboard"
                    })
                }
            );
        }

        [HttpDelete]
        public async Task<IActionResult> HandleDelete(int id)
        {
            var category = await _categoryEventService.GetByIdAsync(id);

            if (category.Status)
            {
                return BadRequest(
                    new {
                        message = "Category cannot be deleted cause status still activated"
                    }
                );
            }

            await _categoryEventService.DeleteAsync(id);
            return Ok(
                new
                {
                    message = "Delete category successfully"
                }
            );
        }
    }
}
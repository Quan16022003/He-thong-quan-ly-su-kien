﻿using Constracts.DTO;
using Microsoft.AspNetCore.Mvc;
using Services.Abtractions;
using Web.Areas.Dashboard.ViewModels;
using Web.Authorize;

namespace Web.Areas.Dashboard.Views.Shared.Components.SideMenu
{
    [Area("Dashboard")]
    public class SideMenuViewComponent : ViewComponent
    {
        private readonly IUserService _userService;
        public SideMenuViewComponent(IServiceManager serviceManager)
        {
            _userService = serviceManager.UserService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var authorized = await LoadCurrentUser();
            return View(authorized);
        }

        private async Task<AuthorizedViewModel> LoadCurrentUser()
        {
            if (User.Identity == null) return null!;

            var currentUser = await _userService.GetCurrentUserAsync(HttpContext.User);
            var permissions = new AccessPermission(currentUser);

            return new AuthorizedViewModel
            {
                CurrentUser = currentUser,
                Permissions = permissions
            };
        }
    }
}

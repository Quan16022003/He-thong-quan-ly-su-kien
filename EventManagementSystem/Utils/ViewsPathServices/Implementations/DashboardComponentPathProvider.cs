﻿using Web.Areas.Dashboard.Views.Shared.Components.EventForm.BasicInformation;
using Web.Areas.Dashboard.Views.Shared.Components.EventForm.Venue;

namespace Web.Utils.ViewsPathServices.Implementations
{
    public class DashboardComponentPathProvider : IPathProvider
    {
        private readonly string folder = "~/Areas/Dashboard/Views/Shared/Components";

        public string GetViewsPath(Type type)
        {
            string target = type.Name;
            return target switch
            {
                nameof(EventBasicInformation) => $"{folder}/EventForm/BasicInformation",
                nameof(EventVenueForm) => $"{folder}/EventForm/Venue",
                _ => throw new ArgumentException($"Does not found Component {target}")
            };
        }
    }
}

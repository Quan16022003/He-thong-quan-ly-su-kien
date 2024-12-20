﻿using Microsoft.AspNetCore.Mvc;

namespace Web.Utils.ViewsPathServices
{
    public interface IPathProvideManager
    {
        /// <summary>
        /// Get folder path which contain the view
        /// </summary>
        /// <typeparam name="T">Controller of the view</typeparam>
        /// <returns>Path to view folder</returns>
        public string Get<T>();
    }
}

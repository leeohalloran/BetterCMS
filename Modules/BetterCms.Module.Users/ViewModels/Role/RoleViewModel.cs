﻿using BetterCms.Module.Root.Mvc.Grids;

namespace BetterCms.Module.Users.ViewModels.Role
{
    public class RoleViewModel : IEditableGridItem
    {
        /// <summary>
        /// Gets or sets the role id.
        /// </summary>
        /// <value>
        /// The role id.
        /// </value>
        public System.Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the role version.
        /// </summary>
        /// <value>
        /// The role version.
        /// </value>
        public int Version { get; set; }

        /// <summary>
        /// Gets or sets the role name.
        /// </summary>
        /// <value>
        /// The role name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return string.Format("Id: {0}, Version: {1}, Name: {2}", Id, Version, Name);
        }
    }
}
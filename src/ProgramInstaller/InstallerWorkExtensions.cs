﻿using System.Linq;
using System.Collections.Generic;

namespace CUM.ProgramInstaller
{
    /// <summary>
    /// Static class containing extensions to work with the Installer class
    /// </summary>
    static class InstallerWorkExtensions
    {
        /// <summary>
        /// Gets the number of selected packages
        /// </summary>
        /// <param name="installer"></param>
        /// <returns>Packages selected count</returns>
        internal static int GetSelectedPackagesCount(this Installer installer)
        {
            int packageCount = 0;
            foreach (var listBox in installer.ProgramsCheckedListBoxCollection)
            {
                packageCount += listBox.CheckedItems.Count;
            }

            return packageCount;
        }

        /// <summary>
        /// Gets all entities of the type selected for operation ProgramInfo
        /// </summary>
        /// <param name="installer"></param>
        /// <returns>List of marked entities ProgramInfo</returns>
        internal static List<Models.ProgramInfo> GetSelectedPackagesListItems(this Installer installer)
        {
            List<Models.ProgramInfo> programs = new List<Models.ProgramInfo>();

            foreach (var listBox in installer.ProgramsCheckedListBoxCollection)
            {
                programs.AddRange(listBox.CheckedItems.Cast<Models.ProgramInfo>());
            }

            return programs;
        }
    }
}

﻿using System.Threading.Tasks;

namespace CUM.Chocolatey
{
    sealed class ChocoInstaller
    {
        internal ChocoBaseInstaller ChocoChild { get; private set; }

        public ChocoInstaller() => ChocoChild = new ChocoBaseInstaller();

        /// <summary>
        /// Installs Chocolatey if it is not installed
        /// </summary>
        /// <param name="auth"></param>
        internal async Task ChocoInstallAsync()
        {
            if (!ChocoChild.ChocoExists)
            {
                await Task.Run(() => ChocoChild.ChocoInstall());
            }
        }
        /// <summary>
        /// Installs the specified Chocolatey package
        /// </summary>
        /// <param name="packageLinkName"></param>
        internal async Task InstallPackageAsync(string packageLinkName)
        {
            if (ChocoChild.ChocoExists)
            {
                await Task.Run(() => ChocoChild.InstallPackage(packageLinkName));
            }
        }
        /// <summary>
        /// Updates the specified Chocolatey package
        /// </summary>
        /// <param name="packageLinkName"></param>
        internal async Task UpdatePackageAsync(string packageLinkName)
        {
            if (ChocoChild.ChocoExists)
            {
                await Task.Run(() => ChocoChild.UpdatePackage(packageLinkName));
            }
        }
        /// <summary>
        /// Deletes the specified Chocolatey package
        /// </summary>
        /// <param name="packageLinkName"></param>
        internal async Task DeletePackageAsync(string packageLinkName)
        {
            if (ChocoChild.ChocoExists)
            {
                await Task.Run(() => ChocoChild.DeletePackage(packageLinkName));
            }
        }
    }
}

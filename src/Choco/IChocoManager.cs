﻿using System;
using System.Threading.Tasks;

namespace CUM.Choco
{
    public interface IChocoManager : IDisposable
    {
        bool ChocoExists { get; }
        Task InstallChoco();
        Task InstallPackage(string packageRefName);
        Task UpgradePackage(string packageRefName);
        Task UninstallPackage(string packageRefName);
    }
}
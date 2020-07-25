﻿using System;
using System.ComponentModel.Composition;
using Microsoft.Uii.Common.Entities;
using Microsoft.Xrm.Tooling.PackageDeployment.CrmPackageExtentionBase;


namespace Package
{
    /// <summary>
    /// Import package starter frame.
    /// </summary>
    [Export(typeof(ImportExtension))]
    public class PackageTemplate : ImportExtension
    {
        /// <summary>
        /// Folder Name for the Package data.
        /// WARNING this value directly correlates to the folder name in the Solution Explorer where the ImportConfig.xml and sub content is located.
        /// Changing this name requires that you also change the correlating name in the Solution Explorer
        /// </summary>
        public override string GetImportPackageDataFolderName => "Sample";

        /// <summary>
        /// Description of the package, used in the package selection UI
        /// </summary>
        public override string GetImportPackageDescriptionText => "Sample Dynamics 365 Package";

        /// <summary>
        /// Long name of the Import Package.
        /// </summary>
        public override string GetLongNameOfImport => "A Sample Package to install D365 solutions, data and perform pre and post deployment operations";

        /// <summary>
        /// Called When the package is initialized.
        /// </summary>
        public override void InitializeCustomExtension()
        {
            // Do nothing.
        }

        /// <summary>
        /// Called Before Import Completes.
        /// </summary>
        /// <returns></returns>
        public override bool BeforeImportStage()
        {
            return true; // do nothing here.
        }

        /// <summary>
        /// Called for each UII record imported into the system
        /// This is UII Specific and is not generally used by Package Developers
        /// </summary>
        /// <param name="app">App Record</param>
        /// <returns></returns>
        public override ApplicationRecord BeforeApplicationRecordImport(ApplicationRecord app)
        {
            return app;  // do nothing here.
        }

        /// <summary>
        /// Called during a solution upgrade while both solutions are present in the target CRM instance.
        /// This function can be used to provide a means to do data transformation or upgrade while a solution update is occurring.
        /// </summary>
        /// <param name="solutionName">Name of the solution</param>
        /// <param name="oldVersion">version number of the old solution</param>
        /// <param name="newVersion">Version number of the new solution</param>
        /// <param name="oldSolutionId">Solution ID of the old solution</param>
        /// <param name="newSolutionId">Solution ID of the new solution</param>
        public override void RunSolutionUpgradeMigrationStep(string solutionName, string oldVersion, string newVersion, Guid oldSolutionId, Guid newSolutionId)
        {

            base.RunSolutionUpgradeMigrationStep(solutionName, oldVersion, newVersion, oldSolutionId, newSolutionId);
        }

        /// <summary>
        /// Called after Import completes.
        /// </summary>
        /// <returns></returns>
        public override bool AfterPrimaryImport()
        {
            return true; // Do nothing here/
        }

        /// <summary>
        /// Name of the Import Package to Use
        /// </summary>
        /// <param name="plural">if true, return plural version</param>
        /// <returns></returns>
        public override string GetNameOfImport(bool plural)
        {
            return "Sample";
        }
    }
}

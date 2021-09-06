// <copyright file="GestformViewModel.cs" company="Maxime Merigeaux">
// Copyright (c) Maxime Merigeaux. All rights reserved.
// </copyright>

namespace GestFormApp.ViewModels
{
    using GestFormApp.Models;
    using GestformLibrary;

    /// <summary>
    /// ViewModel of the gestform algorithm.
    /// </summary>
    internal class GestformViewModel
    {
        /// <summary>
        /// Gets or sets model of the gestform algorithm.
        /// </summary>
        public GestformModel MyGestFormModel { get; set; }

        /// <summary>
        /// Load a set of random <see langword="int"/> and their associated <see langword="string"/> values
        /// base on the gestform algorithm.
        /// </summary>
        /// <param name="p_count">The amount of random numbers you want to run in the gestform algorithm.</param>
        public void LoadGestformModel(int p_count)
        {
            Gestform myGestform = new Gestform(p_count);

            this.MyGestFormModel = new GestformModel
            {
                GestformResults = myGestform.GestformResults,
            };
        }
    }
}

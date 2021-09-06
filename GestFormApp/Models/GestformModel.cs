// <copyright file="GestformModel.cs" company="Maxime Merigeaux">
// Copyright (c) Maxime Merigeaux. All rights reserved.
// </copyright>

namespace GestFormApp.Models
{
    using System.Collections.Generic;
    using System.ComponentModel;

    /// <summary>
    /// Model of the gestform algorithm.
    /// </summary>
    internal class GestformModel : INotifyPropertyChanged
    {
        private Dictionary<int, string> gestformResults;

        /// <inheritdoc/>
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string property)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        /// <summary>
        /// Gets or sets the collection of random numbers and their associated values based on the gestform algorithm.
        /// </summary>
#pragma warning disable SA1201 // Elements should appear in the correct order
        public Dictionary<int, string> GestformResults
#pragma warning restore SA1201 // Elements should appear in the correct order
        {
            get => this.gestformResults;
            set
            {
                this.gestformResults = value;
                this.RaisePropertyChanged("GestformResults");
            }
        }
    }
}

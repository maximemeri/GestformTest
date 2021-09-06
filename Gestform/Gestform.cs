// <copyright file="Gestform.cs" company="Maxime Merigeaux">
// Copyright (c) Maxime Merigeaux. All rights reserved.
// </copyright>

namespace GestformLibrary
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Represent the impementation of the gestform algorithm.
    /// </summary>
    public class Gestform
    {
        private const int MinRange = -1000;
        private const int MaxRange = 1000;
        private const string ArgumentOutOfRangeExceptionMessage = "You can only provide positive integer as parameter.";
        private readonly Random randomizer;

        /// <summary>
        /// Initializes a new instance of the <see cref="Gestform"/> class.
        /// </summary>
        public Gestform()
        {
            this.randomizer = new Random();
            this.GenerateGestformResults(this.randomizer.Next(1, 50));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Gestform"/> class.
        /// </summary>
        /// <param name="p_size">The amount of int to cast with the gestform algorithm.</param>
        public Gestform(int p_size)
        {
            this.randomizer = new Random();
            this.GenerateGestformResults(p_size);
        }

        /// <summary>
        /// Gets the collection of random numbers and their associated values based on the gestform algorithm.
        /// </summary>
        public Dictionary<int, string> GestformResults { get; private set; }

        /// <summary>
        /// Generate the <see cref="GestformResults"/> collection of <see langword="int"/> keys and <see langword="string"/> values.
        /// </summary>
        /// <param name="p_size">the size of the lists.</param>
        public void GenerateGestformResults(int p_size)
        {
            if (p_size < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(p_size), ArgumentOutOfRangeExceptionMessage);
            }

            this.GestformResults = new Dictionary<int, string>();
            HashSet<int> candidates = new HashSet<int>();

            while (this.GestformResults.Count < p_size)
            {
                int number = this.randomizer.Next(MinRange, MaxRange);
                if (candidates.Add(number))
                {
                    this.GestformResults.Add(number, this.CastIntToGestformValue(number));
                }
            }
        }

        /// <summary>
        /// Cast an <see langword="int"/> into a <see langword="string"/>.
        /// </summary>
        /// <param name="p_number">the <see langword="int"/> to cast.</param>
        /// <returns>
        /// the <see langword="string"/> casted with the value : "Geste" if multiple of 3, "Forme" if multiple of 5,
        /// "Gestform" if both or the number if none.
        /// </returns>
        public string CastIntToGestformValue(int p_number)
        {
            if (this.IsMultiple3(p_number))
            {
                if (this.IsMultiple5(p_number))
                {
                    return "Gestform";
                }
                else
                {
                    return "Geste";
                }
            }
            else if (this.IsMultiple5(p_number))
            {
                return "Forme";
            }
            else
            {
                return p_number.ToString();
            }
        }

        /// <summary>
        /// Check if the integer in parameter is a multiple of 3.
        /// </summary>
        /// <param name="p_number">The integer to check.</param>
        /// <returns><see langword="true"/> if <paramref name="p_number"/> is a multiple of 3, otherwise <see langword="false"/>.</returns>
        public bool IsMultiple3(int p_number)
        {
            return p_number % 3 == 0;
        }

        /// <summary>
        /// Check if the integer in parameter is a multiple of 5.
        /// </summary>
        /// <param name="p_number">The integer to check.</param>
        /// <returns><see langword="true"/> if <paramref name="p_number"/> is a multiple of 5, otherwise <see langword="false"/>.</returns>
        public bool IsMultiple5(int p_number)
        {
            return p_number % 5 == 0;
        }
    }
}

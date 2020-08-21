﻿namespace E_library.Models
{
    /// <summary>
    /// Публикации с УДК
    /// </summary>
    public class EditionUdk : Edition
    {
        /// <summary>
        /// Индекс Универсальной десятичной классификации
        /// </summary>
        public string Udk { get; set; }
    }
}

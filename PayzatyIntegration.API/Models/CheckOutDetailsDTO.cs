﻿namespace PayzatyIntegration.API.Models
{
    public class CheckOutDetailsDTO
    {
        /// <summary>
        /// checkout details id
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// checkout details amount of money
        /// </summary>
        public int amount { get; set; }
        /// <summary>
        /// checkout details currency
        /// </summary>
        public string currency { get; set; }
        /// <summary>
        /// checkout details language
        /// </summary>
        public string language { get; set; }
        /// <summary>
        /// checkout details reference
        /// </summary>
        public string reference { get; set; }
        /// <summary>
        /// checkout customer information
        /// </summary>
        public Customer customer { get; set; }       
        /// <summary>
        /// checkout paid or not
        /// </summary>
        public bool paid { get; set; }
        /// <summary>
        /// checkout status
        /// </summary>
        public string status { get; set; }
    }
}
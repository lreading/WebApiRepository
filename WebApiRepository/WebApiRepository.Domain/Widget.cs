using System;

namespace WebApiRepository.Domain
{
    /// <summary>
    /// Describes the entirely made-up widget
    /// </summary>
    public class Widget : IEntity
    {
        /// <summary>
        /// The unique identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name of the widget
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The date the widget was manufactured
        /// </summary>
        public DateTime DateManufactured { get; set; }

        /// <summary>
        /// The serial number
        /// </summary>
        public string Serial { get; set; }
    }
}
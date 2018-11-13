﻿using System;

namespace ADHDmail.Config
{
    /// <summary>
    /// Represents a filter to apply to a message based on the part of the message to filter and the value to filter by.
    /// </summary>
    public class Filter
    {
        /// <summary>
        /// The recipient's account to which to apply a filter.
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// The main text content of the message to which to apply a filter.
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// The sender's email address to which to apply a filter.
        /// </summary>
        public string SendersEmail { get; set; }

        /// <summary>
        /// The name of the person who sent the message to which to apply a filter.
        /// </summary>
        public string SendersName { get; set; }

        /// <summary>
        /// A description of the topic of the message to which to apply a filter.
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// The date and time the message was received to which to apply a filter.
        /// </summary>
        public DateTime TimeReceived { get; set; }
    }
}

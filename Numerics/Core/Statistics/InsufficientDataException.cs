﻿using System;

namespace Meta.Numerics.Statistics {

    /// <summary>
    /// The exception that is thrown when an operation is attempted with less than the minimum required data.
    /// </summary>
    public partial class InsufficientDataException : InvalidOperationException {

        /// <summary>
        /// Initializes a new insufficient data exception.
        /// </summary>
        public InsufficientDataException () : base() { }

        /// <summary>
        /// Inititalizes a new insufficient data exception with the given exception message.
        /// </summary>
        /// <param name="message">The exception message.</param>
        public InsufficientDataException (String message) : base(message) { }

        /// <summary>
        /// Initializes a new insufficient data exception with the given exception message and inner exception.
        /// </summary>
        /// <param name="message">The exeption message.</param>
        /// <param name="innerException">The inner exception.</param>
        public InsufficientDataException (String message, Exception innerException) : base(message, innerException) { }

    }

}

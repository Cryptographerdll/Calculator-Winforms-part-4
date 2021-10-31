using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCalculatorWindows
{
    /// <summary>
    /// A type of Operation the calculator can perform .
    /// </summary>
    public enum OperationType
    { 
        /// <summary>
        /// Add Two values together .
        /// </summary>
        Add,
        /// <summary>
        /// Takes one value from another .
        /// </summary>
        Minus,
        /// <summary>
        /// Divides one number by another .
        /// </summary>
        Divide,
        /// <summary>
        /// Multiply two numbers Together .
        /// </summary>
        Multiply
    }
}

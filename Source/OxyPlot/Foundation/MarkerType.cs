// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MarkerType.cs" company="OxyPlot">
//   Copyright (c) 2014 OxyPlot contributors
// </copyright>
// <summary>
//   Defines the marker type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#nullable enable

namespace OxyPlot
{
    /// <summary>
    /// Defines the marker type.
    /// </summary>
    public enum MarkerType
    {
        /// <summary>
        /// Do not render markers.
        /// </summary>
        None = 0,

        /// <summary>
        /// Render markers as circles.
        /// </summary>
        Circle = 1,

        /// <summary>
        /// Render markers as squares.
        /// </summary>
        Square = 2,

        /// <summary>
        /// Render markers as diamonds.
        /// </summary>
        Diamond = 3,

        /// <summary>
        /// Render markers as triangles.
        /// </summary>
        Triangle = 4,

        /// <summary>
        /// Render markers as crosses (note: this marker type requires the stroke color to be set).
        /// </summary>
        /// <remarks>This marker type requires the stroke color to be set.</remarks>
        Cross = 5,

        /// <summary>
        /// Renders markers as plus signs (note: this marker type requires the stroke color to be set).
        /// </summary>
        /// <remarks>This marker type requires the stroke color to be set.</remarks>
        Plus = 6,

        /// <summary>
        /// Renders markers as stars (note: this marker type requires the stroke color to be set).
        /// </summary>
        /// <remarks>This marker type requires the stroke color to be set.</remarks>
        Star = 7,

        /// <summary>
        ///Render markers as vertical rectangle
        /// </summary>
        VerticalRectangle = 8,

        /// <summary>
        ///Render markers as horizontal rectangle
        /// </summary>
        HorizontalRectangle = 9,

        /// <summary>
        /// Render markers by a custom shape (defined by outline).
        /// </summary>
        Custom = 99,


    }
}

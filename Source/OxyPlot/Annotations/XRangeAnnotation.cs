using System;
using System.Collections.Generic;
using System.Text;

namespace OxyPlot.Annotations
{
    /// <summary>
    /// 
    /// </summary>
    public class XRangleAnnotation : ShapeAnnotation
    {

        /// <summary>
        /// The rectangle transformed to screen coordinates.
        /// </summary>
        private OxyRect screenRectangle;

        /// <summary>
        /// Initializes a new instance of the <see cref="XRangleAnnotation" /> class.
        /// </summary>
        public XRangleAnnotation()
        {

        }

        /// <summary>
        /// Gets or sets the x-coordinate of the center.
        /// </summary>
        public double Xi { get; set; }

        /// <summary>
        /// Gets or sets the y-coordinate of the center.
        /// </summary>
        public double Xj { get; set; }


        /// <inheritdoc/>
        public override void Render(IRenderContext rc)
        {

            this.screenRectangle = new OxyRect(this.Transform(this.Xi, this.YAxis.ActualMinimum), this.Transform(this.Xj, this.YAxis.ActualMaximum));

            rc.DrawRectangle(
                this.screenRectangle,
                this.GetSelectableFillColor(this.Fill),
                this.GetSelectableColor(this.Stroke),
                this.StrokeThickness,
                this.EdgeRenderingMode);
            base.Render(rc);

            this.TextPosition = new DataPoint((this.Xi + this.Xj) * 0.5, (this.YAxis.ActualMinimum + this.YAxis.ActualMaximum) * 0.5);
            var position = this.Transform(this.TextPosition);

            this.GetActualTextAlignment(out var ha, out var va);

            rc.DrawMathText(
                position,
                this.Text,
                this.GetSelectableFillColor(this.ActualTextColor),
                this.ActualFont,
                this.ActualFontSize,
                this.ActualFontWeight,
                this.TextRotation,
                ha,
                va);
        }

        /// <summary>
        /// When overridden in a derived class, tests if the plot element is hit by the specified point.
        /// </summary>
        /// <param name="args">The hit test arguments.</param>
        /// <returns>
        /// The result of the hit test.
        /// </returns>
        protected override HitTestResult HitTestOverride(HitTestArguments args)
        {
            if (this.screenRectangle.Contains(args.Point))
            {
                return new HitTestResult(this, args.Point);
            }

            return null;
        }

    }
}

/*************************************************************************************
 *
 * File Name:   SkiaExtensions_Customer
 * Description: 
 * 
 * Version：  V1.0
 * Creator：  Administrator 
 * CreatedTime：  2022/5/9 14:47:47
 * ======================================
 * History
 * Ver：V           ModifyTime：         Editor：
 * Detail：
 * ======================================
*************************************************************************************/

using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OxyPlot.SkiaSharp
{
    public partial class SkiaRenderContext
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="rectangle"></param>
        /// <param name="fill"></param>
        /// <param name="stroke"></param>
        /// <param name="thickness"></param>
        /// <param name="edgeRenderingMode"></param>
        public void DrawCustomerRectangle(OxyRect rectangle, SKPaint fill, OxyColor stroke, double thickness, EdgeRenderingMode edgeRenderingMode)
        {
            if (fill == null && !(stroke.IsVisible() || thickness <= 0))
            {
                return;
            }

            var actualRectangle = this.GetActualRect(rectangle, thickness, edgeRenderingMode);

            if (fill!=null)
            {
                this.SkCanvas.DrawRect(actualRectangle, fill);
            }

            if (stroke.IsVisible() && thickness > 0)
            {
                var paint = this.GetStrokePaint(stroke, thickness, edgeRenderingMode);
                this.SkCanvas.DrawRect(actualRectangle, paint);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPK.UserControls.GridviewSerial
{
    public class GridViewSerial : DataGridView
    {
        public GridViewSerial() { }
        protected override void OnRowPostPaint(DataGridViewRowPostPaintEventArgs e)
        {
            string strRowNumber = (e.RowIndex + 1).ToString();
            while (strRowNumber.Length < RowCount.ToString().Length)
            {
                strRowNumber = "0" + strRowNumber;
            }
            SizeF size = e.Graphics.MeasureString(strRowNumber, Font);
            if (RowHeadersWidth < (int)(size.Width + 20))
            {
                RowHeadersWidth = (int)(size.Width + 20);
            }
            Brush b = SystemBrushes.ControlText;
            e.Graphics.DrawString(strRowNumber, Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            base.OnRowPostPaint(e);
        }
    }
}

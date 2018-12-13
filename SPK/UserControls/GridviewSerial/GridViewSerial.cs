
using System.Drawing;
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



        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    if (Rows.Count == 0)
        //    {
        //        using (Graphics grfx = e.Graphics)
        //        {
        //            //create a white rectangle for the text to be readable
        //            //i ebuka ofoedu choose white. do your worst

        //            grfx.FillRectangle(Brushes.White, new Rectangle(new Point(), new Size(Width, 25)));

        //            // write ttext on the graphics
        //            grfx.DrawString("No data returned", new Font("Arial", 12), Brushes.Black, new Point(3, 3));
        //        }
        //    }
        //}
    }
}

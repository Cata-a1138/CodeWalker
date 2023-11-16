using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CodeWalker.Utils {
    internal class ListViewColor {

        public static Color ListForeColor;
        public static Color ListBackColor;

        //List view header formatters
        public static void ColorListViewHeader(ref ListView list) {
            list.OwnerDraw = true;
            list.DrawColumnHeader +=
                new DrawListViewColumnHeaderEventHandler
                (
                    (sender, e) => HeaderDraw(sender, e)
                );
            list.DrawItem += new DrawListViewItemEventHandler(BodyDraw);
        }

        private static void HeaderDraw(object sender, DrawListViewColumnHeaderEventArgs e) {
            //Fills one solid background for each cell.
            using (SolidBrush backBrush = new SolidBrush(ListBackColor)) {
                e.Graphics.FillRectangle(backBrush, e.Bounds);
            }
            //Draw the borders for the header around each cell.
            Color borderColor = Color.White;
            if (ListBackColor.R > 128) {
                borderColor = Color.FromArgb(ListBackColor.R - 20, ListBackColor.G - 20, ListBackColor.B - 20);
            } else {
                borderColor = Color.FromArgb(ListBackColor.R + 20, ListBackColor.G + 20, ListBackColor.B + 20);
            }
            using (Pen backBrush = new Pen(borderColor)) {
                Rectangle rect = e.Bounds;
                rect.Width += 1;
                rect.Height += 1;
                rect.X -= 1;
                rect.Y -= 1;
                e.Graphics.DrawRectangle(backBrush, rect);
            }
            using (SolidBrush foreBrush = new SolidBrush(ListForeColor)) {
                //Since e.Header.TextAlign returns 'HorizontalAlignment' with values of (Right, Center, Left).  
                //DrawString uses 'StringAlignment' with values of (Near, Center, Far). 
                //We must translate these and setup a vertical alignment that doesn't exist in DrawListViewColumnHeaderEventArgs.
                StringFormat stringFormat = GetStringFormat(e.Header.TextAlign);

                //Do some padding, since these draws right up next to the border for Left/Near.  Will need to change this if you use Right/Far
                Rectangle rect = e.Bounds; rect.X += 4;
                if (e.Header.TextAlign == HorizontalAlignment.Right) {
                    rect.X -= 8;
                }
                e.Graphics.DrawString(e.Header.Text, e.Font, foreBrush, rect, stringFormat);
            }
        }

        private static StringFormat GetStringFormat(HorizontalAlignment ha) {
            StringAlignment align;

            switch (ha) {
                case HorizontalAlignment.Right:
                    align = StringAlignment.Far;
                    break;
                case HorizontalAlignment.Center:
                    align = StringAlignment.Center;
                    break;
                default:
                    align = StringAlignment.Near;
                    break;
            }

            return new StringFormat() {
                Alignment = align,
                LineAlignment = StringAlignment.Center
            };
        }

        private static void BodyDraw(object sender, DrawListViewItemEventArgs e) {
            e.DrawDefault = true;
        }
    }
}

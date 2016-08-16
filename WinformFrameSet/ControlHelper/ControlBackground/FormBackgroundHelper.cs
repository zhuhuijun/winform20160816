using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ControlHelper
{
    public class FormBackgroundHelper
    {
        #region 私有属性
        /// <summary>
        /// 背景图片位图
        /// </summary>
        private Bitmap bitmap = null;
        private Control control = null;
        #endregion

        #region 构造方法
        public FormBackgroundHelper(Control control, Bitmap bitmap)
        {
            this.control = control;
            this.bitmap = bitmap;
        }
        #endregion

        #region 私有方法
        /// <summary>
        /// 设置背景颜色及透明度
        /// </summary>
        /// <param name="transparencyColor">颜色</param>
        private void Setbitmap(Color transparencyColor)
        {
            bitmap = new Bitmap(control.BackgroundImage);
            control.Width = bitmap.Width;
            control.Height = bitmap.Height;
            control.Region = BitmapToRegion(transparencyColor);
        }
        /// <summary>
        /// 背景位图转换成区域
        /// </summary>
        /// <param name="bitmap">位图</param>
        /// <param name="transparencyColor">颜色</param>
        /// <returns>对应区域</returns>
        private Region BitmapToRegion(Color transparencyColor)
        {
            if (bitmap == null)
                throw new ArgumentNullException("Bitmap", "Bitmap cannot be null!");
            int height = bitmap.Height;
            int width = bitmap.Width;
            //线条
            GraphicsPath path = new GraphicsPath();
            //循环每个像素点位，
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    if (bitmap.GetPixel(i, j) == transparencyColor)
                        continue;
                    int x0 = i;
                    while ((i < width) && (bitmap.GetPixel(i, j) != transparencyColor))
                        i++;
                    path.AddRectangle(new Rectangle(x0, j, i - x0, 1));
                }
            }
            Region region = new Region(path);
            path.Dispose();
            return region;
        }
        /// <summary> 
        /// 返回指定图片中的非透明区域； 
        /// </summary> 
        /// <param name="bitmap">位图</param> 
        /// <param name="alpha">alpha 小于等于该值的为透明</param> 
        /// <returns></returns> 
        private GraphicsPath GetNoneTransparentRegion(byte alpha)
        {
            int height = bitmap.Height;
            int width = bitmap.Width;

            int xStart, xEnd;
            GraphicsPath grpPath = new GraphicsPath();
            for (int y = 0; y < height; y++)
            {
                //逐行扫描； 
                for (int x = 0; x < width; x++)
                {
                    //略过连续透明的部分； 
                    while (x < width && bitmap.GetPixel(x, y).A <= alpha)
                    {
                        x++;
                    }
                    //不透明部分； 
                    xStart = x;
                    while (x < width && bitmap.GetPixel(x, y).A > alpha)
                    {
                        x++;
                    }
                    xEnd = x;
                    if (bitmap.GetPixel(x - 1, y).A > alpha)
                    {
                        grpPath.AddRectangle(new Rectangle(xStart, y, xEnd - xStart, 1));
                    }
                }
            }
            return grpPath;

        }
        /// <summary>
        /// 将位图对应颜色设置为透明
        /// </summary>
        /// <param name="bitmap"></param>
        /// <returns></returns>
        private GraphicsPath CalculateControlGraphicsPath()
        {
            //创建 GraphicsPath
            GraphicsPath graphicsPath = new GraphicsPath();
            //使用左上角的一点的颜色作为我们透明色
            Color colorTransparent = bitmap.GetPixel(0, 0);
            //第一个找到点的X
            int colOpaquePixel = 0;
            // 偏历所有行（Y方向）
            for (int row = 0; row < bitmap.Height; row++)
            {
                //重设
                colOpaquePixel = 0;
                //偏历所有列（X方向）
                for (int col = 0; col < bitmap.Width; col++)
                {
                    //如果是不需要透明处理的点则标记，然后继续偏历
                    if (bitmap.GetPixel(col, row) != colorTransparent)
                    {
                        //记录当前
                        colOpaquePixel = col;
                        //建立新变量来记录当前点
                        int colNext = col;
                        ///从找到的不透明点开始，继续寻找不透明点,一直到找到或则达到图片宽度 
                        for (colNext = colOpaquePixel; colNext < bitmap.Width; colNext++)
                            if (bitmap.GetPixel(colNext, row) == colorTransparent)
                                break;
                        //将不透明点加到graphics path
                        graphicsPath.AddRectangle(new Rectangle(colOpaquePixel, row, colNext - colOpaquePixel, 1));
                        col = colNext;
                    }
                }
            }
            return graphicsPath;
        }
        #endregion

        #region 公用方法
        /// <summary>
        /// 构建控件处理后的背景图片
        /// </summary>
        /// <param name="control"></param>
        /// <param name="bitmap"></param>
        public void CreateControlRegion()
        {
            //判断是否存在控件和位图
            if (control == null || bitmap == null)
                return;
            //设置控件大小为位图大小
            control.Width = bitmap.Width;
            control.Height = bitmap.Height;
            //当控件是form时
            if (control is Form)
            {
                //强制转换为FORM
                Form form = (Form)control;
                //当FORM的边界FormBorderStyle不为NONE时，应将FORM的大小设置成比位图大小稍大一点
                form.Width = control.Width;
                form.Height = control.Height;
                //没有边界
                form.FormBorderStyle = FormBorderStyle.None;
                //将位图设置成窗体背景图片
                form.BackgroundImage = bitmap;
                //计算位图中不透明部分的边界
                GraphicsPath graphicsPath = CalculateControlGraphicsPath();
                //应用新的区域
                form.Region = new Region(graphicsPath);
            }
            //当控件是button时
            else if (control is System.Windows.Forms.Button)
            {
                //强制转换为 button
                Button button = (Button)control;
                //不显示button text
                button.Text = "";
                //改变 cursor的style
                button.Cursor = Cursors.Hand;
                //设置button的背景图片
                button.BackgroundImage = bitmap;
                //计算位图中不透明部分的边界
                GraphicsPath graphicsPath = CalculateControlGraphicsPath();
                //应用新的区域
                button.Region = new Region(graphicsPath);
            }
        }
        #endregion
    }
}

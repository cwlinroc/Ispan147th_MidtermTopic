using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UClass.View.Login;

namespace prjMidtermTopic.Model
{
	public class Beautify
	{
		static public void SetFormRoundRectRgn(Form form, int rgnRadius)
		{
			int hRgn = 0;
			hRgn = Win32.CreateRoundRectRgn(0, 0, form.Width + 1, form.Height + 1, rgnRadius, rgnRadius);
			Win32.SetWindowRgn(form.Handle, hRgn, true);
			Win32.DeleteObject(hRgn);
		}
	}

	public enum ControlState { Hover, Normal, Pressed }
	public class RoundButton : Button
	{

		private int radius;//半径 
		public int Radius
		{
			set
			{
				radius = value;
				this.Invalidate();
			}
			get
			{
				return radius;
			}
		}
		public ControlState ControlState { get; set; }
		protected override void OnMouseEnter(EventArgs e)//滑鼠進入時
		{
			base.OnMouseEnter(e);
			ControlState = ControlState.Hover;//正常
		}
		protected override void OnMouseLeave(EventArgs e)//滑鼠離開
		{
			base.OnMouseLeave(e);
			ControlState = ControlState.Normal;//正常
		}
		protected override void OnMouseDown(MouseEventArgs e)//滑鼠按下
		{
			base.OnMouseDown(e);
			if (e.Button == MouseButtons.Left && e.Clicks == 1)//滑鼠左鍵x1
			{
				ControlState = ControlState.Pressed;//按下的狀態
			}
		}
		protected override void OnMouseUp(MouseEventArgs e)//滑鼠彈起
		{
			base.OnMouseUp(e);
			if (e.Button == MouseButtons.Left && e.Clicks == 1)
			{
				if (ClientRectangle.Contains(e.Location))//控件區域包含滑鼠的位置
				{
					ControlState = ControlState.Hover;
				}
				else
				{
					ControlState = ControlState.Normal;
				}
			}
		}
		public RoundButton()
		{
			Radius = 15;
			this.FlatStyle = FlatStyle.Flat;
			this.FlatAppearance.BorderSize = 0;
			this.ControlState = ControlState.Normal;
			this.SetStyle(
			 ControlStyles.UserPaint |  //控件自行繪製，而不使用操作系統的繪製
			 ControlStyles.AllPaintingInWmPaint | //忽略擦出的消息，減少閃爍。
			 ControlStyles.OptimizedDoubleBuffer |//在緩衝區上繪製，不直接繪製到屏幕上，減少閃爍。
			 ControlStyles.ResizeRedraw | //控件大小發生變化時，重繪。             
			 ControlStyles.SupportsTransparentBackColor, true);//支持透明背景顏色
		}

		//重写OnPaint
		protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
		{
			base.OnPaint(e);
			base.OnPaintBackground(e);
			e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
			e.Graphics.CompositingQuality = CompositingQuality.HighQuality;

			e.Graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;

			Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
			var path = GetRoundedRectPath(rect, radius);

			this.Region = new Region(path);

			Color baseColor = this.BackColor;

			using (SolidBrush b = new SolidBrush(baseColor))
			{
				e.Graphics.FillPath(b, path);
				Font fo = new Font("微軟正黑體", 18F);//指定預設字體與大小
				Brush brush = new SolidBrush(Color.White);
				StringFormat gs = new StringFormat();
				gs.Alignment = StringAlignment.Center; //居中
				gs.LineAlignment = StringAlignment.Center;//垂直居中
				e.Graphics.DrawString(this.Text, fo, brush, rect, gs);
			}
		}
		private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
		{
			int diameter = radius;
			Rectangle arcRect = new Rectangle(rect.Location, new Size(diameter, diameter));
			GraphicsPath path = new GraphicsPath();
			path.AddArc(arcRect, 180, 90);
			arcRect.X = rect.Right - diameter;
			path.AddArc(arcRect, 270, 90);
			arcRect.Y = rect.Bottom - diameter;
			path.AddArc(arcRect, 0, 90);
			arcRect.X = rect.Left;
			path.AddArc(arcRect, 90, 90);
			path.CloseFigure();
			return path;
		}

		protected override void OnSizeChanged(EventArgs e)
		{
			base.OnSizeChanged(e);
		}
	}
}

using System;
using System.Linq;
using System.Collections.Generic;

namespace Xamarin.Forms
{
	public class WrapLayout : Layout<View>
	{
		double _w = 100;
		double _h = 100;

		protected override void LayoutChildren(double x, double y, double width, double height)
		{
			var regions = ComputeLayout(width, height);

			foreach (var region in regions)
			{
				LayoutChildIntoBoundingRegion(region.View, new Rectangle(x + X * _w, y + Y * _h, _w, _h)); 
			}
		}

		//protected override SizeRequest OnMeasure(double widthConstraint, double heightConstraint)
		//{
		//	double lastX;
		//	double lastY;
		//	var layout = ComputeLayout(widthConstraint, heightConstraint, out lastX, out lastY);

		//	return new SizeRequest(new Size(lastX, lastY));
		//}

		List<Region> ComputeLayout(double width, double height)
		{
			var list = new List<Region>();

			int x = 0;
			int y = 0;

			foreach (var child in Children)
			{
				list.Add(new Region { 
					View = child,
					X = x,
					Y = y
				});

				x += 1;

				if (x * _w > width)
				{
					y += 1;
				}
			}

			return list;
		}

		public class Region
		{
			public View View { get; set; }
			public double X { get; set; }
			public double Y { get; set; }
		}
	}
}
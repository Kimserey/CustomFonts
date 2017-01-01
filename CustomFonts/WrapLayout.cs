using System;
using System.Linq;
using System.Collections.Generic;

namespace Xamarin.Forms
{
	public class WrapLayout : Layout<View>
	{
		protected override void LayoutChildren(double x, double y, double width, double height)
		{
			var regions = ComputeLayout(width, height);

			foreach (var region in regions.Item1)
			{
				LayoutChildIntoBoundingRegion(
					region.View,
					new Rectangle(
						region.X * region.SizeRequest.Request.Width, 
						region.Y * region.SizeRequest.Request.Height, 
						region.SizeRequest.Request.Width, 
						region.SizeRequest.Request.Height));
			}
		}

		protected override SizeRequest OnMeasure(double widthConstraint, double heightConstraint)
		{
			var regions = ComputeLayout(widthConstraint, heightConstraint);
			var w = regions.Item2;
			var h = regions.Item3;
			return new SizeRequest(new Size(w, h));
		}

		Tuple<List<Region>, double, double> ComputeLayout(double widthConstraint, double heightConstraint)
		{
			var children = Children.FirstOrDefault();

			if (children == null)
				return new Tuple<List<Region>, double, double>(new List<Region>(), 0, 0);

			var size = children.Measure(double.PositiveInfinity, double.PositiveInfinity);

			var list = new List<Region>();

			int x = 0;
			int y = 0;
			double rowWidth = 0;
			double rowHeight = 0;
			double width = 0;
			double height = size.Request.Height;

			foreach (var child in Children)
			{
				if (size.Request.Width + rowWidth > widthConstraint)
				{
					if (width < rowWidth)
						width = rowWidth;

					x = 0;
					y += 1;
				    rowWidth = 0;
					height += rowHeight;
					rowHeight = size.Request.Height;
				}

				var region = new Region
				{
					View = child,
					X = x,
					Y = y,
					SizeRequest = size
				};

				list.Add(region);

				x += 1;
				rowWidth += size.Request.Width;
				width += size.Request.Width;

				if (rowHeight < size.Request.Height)
					rowHeight = size.Request.Height;
			}

			return new Tuple<List<Region>, double, double>(list, width, height);
		}

		public class Region
		{
			public View View { get; set; }
			public double X { get; set; }
			public double Y { get; set; }
			public SizeRequest SizeRequest { get; set; }
		}
	}
}
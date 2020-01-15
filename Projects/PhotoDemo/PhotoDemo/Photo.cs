using System.IO;
using System;

class PhotoDemo
{
	static void Main()
	{
		//create object with given width and height
		Photo photo1 = new Photo(8, 10);
		Console.WriteLine(photo1.ToString());
		Photo photo2 = new Photo(10, 12);
		Console.WriteLine(photo2.ToString());
		Photo photo3 = new Photo(12, 14);
		Console.WriteLine(photo3.ToString());
		MattedPhoto mattedPhoto1 = new MattedPhoto(8, 10, "Green");
		Console.WriteLine(mattedPhoto1.ToString());
		MattedPhoto mattedPhoto2 = new MattedPhoto(10, 12, "Red");
		Console.WriteLine(mattedPhoto2.ToString());
		MattedPhoto mattedPhoto3 = new MattedPhoto(12, 14, "Blue");
		Console.WriteLine(mattedPhoto3.ToString());
		FramedPhoto framedPhoto1 = new FramedPhoto(8, 10, "platinum", "modern");
		Console.WriteLine(framedPhoto1.ToString());
		FramedPhoto framedPhoto2 = new FramedPhoto(10, 12, "gold", "modern");
		Console.WriteLine(framedPhoto2.ToString());
		FramedPhoto framedPhoto3 = new FramedPhoto(12, 14, "silver", "modern");
		Console.WriteLine(framedPhoto3.ToString());
	}
}

public class Photo
{
	public int width;
	public int height;
	protected double price;
	public Photo(int w, int h)
	{
		this.width = w;
		this.height = h;
		if (width == 8 && height == 10)
		{
			this.price = 3.99;
		}
		else if (width == 10 && height == 12)
		{
            price = 5.99;
		}
		else
		{
			this.price = 9.99;
		}
	}
	public int GetWidth()
	{
		return width;
	}

	public int GetHeight()
	{
		return height;
	}

	public double GetPrice()
	{
		return price;
	}

	public string ToString()
	{
		return "Width:" + GetWidth() + ",Height:" + GetHeight() + ",Price:" + GetPrice();
	}
}

public class MattedPhoto : Photo
{
	public string color;
	public MattedPhoto(int w, int h, string c) : base(w, h)
	{
		width = w;
		height = h;
		color = c;
		if (width == 8 && height == 10)
		{
			price = 3.99 + 10;
		}
		else if (width == 10 && height == 12)
		{
			price = 5.99 + 10;
		}
		else
		{
			price = 9.99 + 10;
		}
	}
	public void SetColor(string color)
	{
		color = color;
	}
	public string GetColor()
	{
		return color;
	}
	public string ToString()
	{
		return "Width:" + GetWidth() + ",Height:" + GetHeight() + ",Price:" + GetPrice() + ",Color:" + GetColor();
	}

}

public class FramedPhoto : Photo
{
	public string material;
	public string style;
	public FramedPhoto(int w, int h, string m, string s) : base(w, h)
	{
		width = w;
		height = h;
		material = m;
		style = s;
		if (width == 8 && height == 10)
		{
			price = 3.99 + 25;
		}
		else if (width == 10 && height == 12)
		{
			price = 5.99 + 25;
		}
		else
		{
			price = 9.99 + 25;
		}
	}
	public string GetMaterial()
	{
		return material;
	}
	public string GetStyle()
	{
		return style;
	}
	public string ToString()
	{
		return "Width:" + GetWidth() + ",Height:" + GetHeight() + ",Price:" + GetPrice() + ",Material:" + GetMaterial() + ",Style:" + GetStyle();
	}

}
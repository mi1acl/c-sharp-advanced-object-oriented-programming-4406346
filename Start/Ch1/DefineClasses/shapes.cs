// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Defining and instantiating classes

// TODO: Define a class using the "class" keyword

// TODO: The constructor accepts parameters used to create the object


// TODO: For convenience, we can have a constructor that takes one value
// for squares that have the same side size


// TODO: Classes can define methods that return values


// TODO: member variables hold data
// Define a class using the "class" keyword
public class Rectangle
{
    // The constructor accepts parameters used to create the object
    public Rectangle(int w, int h)
    {
        Width = w;
        Height = h;
    }
    // For convenience, we can have a constructor that takes one value
    // for squares that have the same side size
    public Rectangle(int side)
    {
        Width = side;
        Height = side;
    }

    // Classes can define methods that return values
    public int Area()
    {
        return Width * Height;
    }

    // member variables hold data
    int width;
    int height;
    public int Width
    {
        get
        {
            return width;
        }
        set
        {
            if (value < 0)
            {
                throw new System.ArgumentException("Width cannot be negative");
            }
            else
            {
                width = value;
            }
        }
    }
    public int Height
    {
        get { return height; }
        set
        {
            if (value < 0)
            {
                throw new System.ArgumentException("Height cannot be negative");
            }
            else
            {
                height = value;
            }
        }

    }
    public int Perimeter()
    {
        return 2 * (Width + Height);
    }
    public int BorderSize { get; set; } = 1;
}

// Define a Square class that inherits from Rectangle
public class Square : Rectangle
{
    // The Square class inherits the Rectangle constructor
    public Square(int side) : base(side)
    {
    }
    // The Square class inherits the Rectangle Area() method
}
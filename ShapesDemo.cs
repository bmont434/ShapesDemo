/* 
this program calculates the area for different shapes
using an abstract class in which rectangle square and 
triangle inheret from
*/

using static System.Console;
class ShapesDemo
{
   static void Main()
   {
       Rectangle req = new Rectangle(5, 10);
       WriteLine("Rectangle {0}", req.Area);
       Square sqr = new Square(5);
       WriteLine("Square {0}", sqr.Area);
       Triangle tri = new Triangle(10, 5);
       WriteLine("Triangle {0}", tri.Area);
       
   }
}

abstract class GeometricFigure
{
    protected int height;
    protected int width;
    protected int area;
    
    public GeometricFigure(int height, int width)
    {
        
    }
    
     public GeometricFigure(int height)
    {
        
    }
    
    public int Height 
    {
        get 
        {
            return height;
        }
        set 
        {
            Height = height;
        }
    }
    
    public int Width 
    {
        get 
        {
            return width;
        }
        set 
        {
            Width = width;
            
        }
    }
    
     public int Area
    {
        get 
        {
            return area;
        }
        set 
        {
            Area = area;
            
        }
    }
    
   public abstract int ComputeArea();
}   

class Rectangle : GeometricFigure
{
    public override int ComputeArea()
    {
    this.area = this.height * this.width;
    return area;
    }
    
    public Rectangle(int height, int width) : base (height, width)
    {
         this.height = height;
         this.width = width;
         ComputeArea();  
    }
    
    public Rectangle(int height) : base (height)
    {
         this.height = height; 
    }
}

class Square : Rectangle
{
    public override int ComputeArea()
    {
    this.area = (this.height * this.height);
    return area;
    }
    
    public Square(int height) : base (height)
    {
         this.height = height;
         ComputeArea();   
    }
    
     public Square(int height, int width) : base (height, width)
    {
         this.height = height;
         this.width = width;
         ComputeArea();   
    }   
}

class Triangle : Square
{
    public override int ComputeArea()
    {
    this.area = (this.height * this.width) / 2;
    return area;
    }
    
    public Triangle(int height) : base (height)
    {
         this.height = height;
         ComputeArea();   
    }
    
     public Triangle(int height, int width) : base (height, width)
    {
         this.height = height;
         this.width = width;
         ComputeArea();   
    }   
}



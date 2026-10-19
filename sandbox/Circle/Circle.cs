class Circle
{
    
    private double _radius;


    public Circle()
    {
        _radius = 0.0;
    }


    public Circle(double radius)
    {
        SetRadius(radius);
    }

    public double GetArea()
    {
        return _radius * _radius * 3.14159;
    }


private void SetRadius(double radius)
    {
        if (radius < 0)
        {
            _radius =1.0;
            Console.WriteLine("error, must have radius > 0");

        }
        else
        {
            _radius = radius;
        }
    }

public double GetRadius()
    {
        return _radius;
    }

}
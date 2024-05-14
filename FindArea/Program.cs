using FindArea.Library.Algo;

var triangle = new Triangle(3.12, 5.35, 6);
var t_area =triangle.GetArea();
Console.WriteLine("Triangle");
Console.WriteLine(t_area);

var circle = new Circle(3);
var c_area = circle.GetArea();
Console.WriteLine("Circle");
Console.WriteLine(c_area);

var rectangle = new Rectangle(3.12, 5.35);
var r_areea = rectangle.GetArea();
Console.WriteLine("Rectangle");
Console.WriteLine(r_areea);
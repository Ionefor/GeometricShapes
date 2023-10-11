namespace GeometricShapes
{
    /* Задание:
    Напишите на C# или Python библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу
   и треугольника по трем сторонам. Дополнительно к работоспособности оценим:
   1) Юнит-тесты
   2) Легкость добавления других фигур
   3) Вычисление площади фигуры без знания типа фигуры в compile-time
   4) Проверку на то, является ли треугольник прямоугольным */

    public class Shape
    {
        private double[] _parametrs;
        private string _name;
        public string Name 
        {
            get => _name;
            protected set => _name = value;
        }
        internal Shape()
        {
            
        }
        public Shape(double radius)
        {
            _name = "Circle";
            _parametrs = new double[1];
            _parametrs[0] = radius;
        }
        public Shape(double firstSide, double secondSide, double thirdSide)
        {
            _name = "Triangle";
            _parametrs = new double[3];
            _parametrs[0] = firstSide;
            _parametrs[1] = secondSide;
            _parametrs[2] = thirdSide;
        }
       
        //  Не совсем понятно, что имели ввиду под "Вычисление площади фигуры без знания типа фигуры в compile - time"
        //  но я думаю речь про это =>        
        public virtual double Square()
        {
            switch (_name)
            {
                case "Circle" : return new Circle(_parametrs).Square();
                case "Triangle" : return new Triangle(_parametrs).Square();
                default :  throw new Exception("There is no specific instance of the figure");
            }
        }
    }  
}
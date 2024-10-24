using SOLID.OCP.Models;

namespace SOLID.OCP.Service
{
    public class ShapesService
    {
        public Circle calcuteArea(Circle circle)
        {
            Circle circleResult = new Circle(30.4f, 50.44f);
            return circleResult;
        } 
    }
}

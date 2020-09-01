namespace Lumina.Models.Model
{
    public class Shape
    {
        public string ShapeName { get; private set; }

        public Shape(Model model, int shapeIndex)
        {
            var currentShape = model.File.Shapes[ shapeIndex ];
            ShapeName = model.StringOffsetToStringMap[ (int) currentShape.StringOffset ];
            
            
        }
    }
}
namespace Lumina.Models.Model
{
    public class Shape
    {
        public string ShapeName { get; private set; }

        public Shape(Model model, int shapeIndex)
        {
            var currentShape = model.File.Shapes[ shapeIndex ];
            ShapeName = model.StringOffsetToStringMap[ (int) currentShape.StringOffset ];
            
            // TODO: shape index modifier things
            // someone else do this pls
        }
    }
}
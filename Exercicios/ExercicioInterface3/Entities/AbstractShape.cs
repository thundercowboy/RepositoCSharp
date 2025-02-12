using Main.Model.Enums;

namespace Main.Model.Entities {
    abstract class AbstractShape : IShape {

        public Color Color { get; set; }

        public abstract double Area();
    }
}
namespace Ex2.Entities
{
    public abstract class GeometricFigure
    {
        public int Side { get; set; }
        public char[,] Draw { get; set; }

        public virtual void setDraw(){}
        public virtual void printDraw(){}

    }
}
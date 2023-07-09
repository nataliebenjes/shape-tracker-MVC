namespace ShapeTracker.Models
{
    public class Triangle
    {
        private int _side1;

        // this is the getter and setter
        public int Side1
        {
            get { return _side1; }
            set { _side1 = value; }
        }
        public int Side2 { get; }
        // Code for Triangle business logic will go here.
        public Triangle(int length1, int length2)
        {
            _side1 = length1;
            Side2 = length2;
        }
    }
}
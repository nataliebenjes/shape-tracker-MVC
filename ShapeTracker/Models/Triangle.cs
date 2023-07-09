namespace ShapeTracker.Models
{
    public class Triangle
    {
        private int _side1;

        // this is the getter and setter
        public int Side1
        {
            get { return _side1; }
        }
        // Code for Triangle business logic will go here.
        public Triangle(int length1)
        {
            _side1 = length1;
        }
    }
}
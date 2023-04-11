namespace Skizziere.Model.Notes
{
    public interface IRectangle
    {
        public void Move(int dx, int dy);

        public bool CheckIntersection(int x, int y);

        public bool CheckIntersection(IRectangle rectangle);

        public void Resize(int dLeft, int dTop, int dRight, int dBottom);
    }
}

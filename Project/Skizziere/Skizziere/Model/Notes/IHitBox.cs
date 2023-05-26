namespace Skizziere.Model.Notes
{
    public interface IHitBox
    {
        public void Move(int dx, int dy);

        public bool CheckIntersection(int x, int y);

        public bool CheckIntersection(IHitBox hitBox);

        public void Resize(int dLeft, int dTop, int dRight, int dBottom);
    }
}

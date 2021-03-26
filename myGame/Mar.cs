namespace myGame
{
    public enum Arrow
    {
        Left,
        Top,
        Right,
        Bottom
    }

    class Mar
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool Active { get; set; }
        public Arrow Arrowkey { get; set; }
    }
}

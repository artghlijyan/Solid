namespace LSP
{
    class Rectangle
    {
        public int Side_A { get; set; }
        public int Side_B { get; set; }

        public int Area()
        {
            return Side_A * Side_B;
        }
    }

    class Square : Rectangle
    {
        
    }
}

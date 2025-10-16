
namespace Tyuiu.MamatkulovFO.Sprint2.Task6.V10.Test
{
    internal class InlineDataAttribute : Attribute
    {
        private int v1;
        private int v2;
        private int v3;

        public InlineDataAttribute(int v1, int v2, int v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public InlineDataAttribute(int v1, int v2, int v3, int v4, int v5, int v6) : this(v1, v2, v3)
        {
            V4 = v4;
            V5 = v5;
            V6 = v6;
        }

        public int V4 { get; }
        public int V5 { get; }
        public int V6 { get; }
    }
}
using System;

namespace AreaRetangulo
{
    class Retangulo
    {
        private float height;
        private float width;
        private float result;
        
        public Retangulo(float heightR, float widthR)
        {
            height = heightR;
            width = widthR;
        }
        public float Height { get { return height; } }
        public float Width { get { return width; } }
        public float Result { get { return Height * Width; } }
    }
}
namespace Shared.Unity
{
    public struct Vector2
    {
        public float X { get; set; }
        public float Y { get; set; }

        public static Vector2 Zero => new Vector2(0, 0);

        public Vector2(float x, float y)
        {
            X = x;
            Y = y;
        }

        public bool IsZero => X == 0 && Y == 0;

        public bool Equals(Vector2 otherVector)
        {
            return X == otherVector.X && Y == otherVector.Y;
        }

        public static bool operator ==(Vector2 v1, Vector2 v2)
        {
            if (v1.X == v2.X && v1.Y == v2.Y)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Vector2 v1, Vector2 v2)
        {
            return !(v1 == v2);
        }

        public static Vector2 operator +(Vector2 v1, Vector2 v2)
        {
            return Add(v1, v2);
        }

        public static Vector2 operator -(Vector2 v1, Vector2 v2)
        {
            return Subtract(v1, v2);
        }

        public static Vector2 Add(Vector2 v1, Vector2 v2)
        {
            return new Vector2(v1.X + v2.X, v1.Y + v2.Y);
        }

        public static Vector2 Subtract(Vector2 v1, Vector2 v2)
        {
            return new Vector2(v1.X - v2.X, v1.Y - v2.Y);
        }
        public override string ToString()
        {
            return $"{{X={X}, Y={Y}}}";
        }
    }
}
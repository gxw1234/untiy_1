namespace Shared.Unity
{
    public struct Vector3
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }

        public static Vector3 Zero => new Vector3(0, 0, 0);

        public Vector3(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Vector3(float x, float y)
        {
            X = x;
            Y = y;
            Z = 0F;
        }

        public bool IsZero => X == 0 && Y == 0 && Z == 0;

        public bool Equals(Vector3 otherVector)
        {
            return X == otherVector.X && Y == otherVector.Y && Z == otherVector.Z;
        }

        public static bool operator ==(Vector3 v1, Vector3 v2)
        {
            if (v1.X == v2.X && v1.Y == v2.Y && v1.Z == v2.Z)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Vector3 v1, Vector3 v2)
        {
            return !(v1 == v2);
        }

        public static Vector3 operator +(Vector3 v1, Vector3 v2)
        {
            return Add(v1, v2);
        }

        public static Vector3 operator -(Vector3 v1, Vector3 v2)
        {
            return Subtract(v1, v2);
        }

        public static Vector3 Add(Vector3 v1, Vector3 v2)
        {
            return new Vector3(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }

        public static Vector3 Subtract(Vector3 v1, Vector3 v2)
        {
            return new Vector3(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
        }
        public override string ToString()
        {
            return $"{{X={X}, Y={Y}, Z={Z}}}";
        }
    }
}
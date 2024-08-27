namespace Aurora;

public partial struct Vector2
{
    #region Fields

    public float X;
    public float Y;

    #endregion

    #region Properties

    public readonly float Length => Math.Sqrt(LengthSquared);

    public readonly float LengthSquared => (X * X) + (Y * Y);

    #endregion

    #region Constructors

    public Vector2(float value)
    {
        X = value;
        Y = value;
    }

    public Vector2(float x, float y)
    {
        X = x;
        Y = y;
    }

    #endregion
}
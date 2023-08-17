using GraphicsEngine.DataTypes;

namespace GraphicsEngine.SceneObjects;

public class BaseTriangle
{
    public Vector3[] Vertices;

    public BaseTriangle(Vector3 position1, Vector3 position2, Vector3 position3)
    {
        Vertices = new[]
        {
            position1,
            position2,
            position3
        };
    }
}
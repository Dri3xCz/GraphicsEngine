using GraphicsEngine.DataTypes;

namespace GraphicsEngine.SceneObjects;

public class ProjectedTriangle
{
    public Vector2[] Vertices;

    public ProjectedTriangle(Vector2 position1, Vector2 position2, Vector2 position3)
    {
        Vertices = new[]
        {
            position1,
            position2,
            position3
        };
    }}
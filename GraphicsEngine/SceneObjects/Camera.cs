using GraphicsEngine.DataTypes;

namespace GraphicsEngine.SceneObjects;

public class Camera
{
    public Vector3 Position;
    public Vector3 UAxis;
    public Vector3 VAxis;

    public Camera(Vector3 position, Vector3 uAxis, Vector3 vAxis)
    {
        Position = position;
        UAxis = uAxis;
        VAxis = vAxis;
    }

    public Vector2 PointToPlane(Vector3 point)
    {
        var op = new Vector3(point.X - this.Position.X, point.Y - this.Position.Y, point.Z - this.Position.Z);
        float proj_u = op.X * this.UAxis.X + op.Y * this.UAxis.Y + op.Z * this.UAxis.Z;
        float proj_v = op.X * this.VAxis.X + op.Y * this.VAxis.Y + op.Z * this.VAxis.Z;

        return new Vector2(proj_u, proj_v);
    }
}
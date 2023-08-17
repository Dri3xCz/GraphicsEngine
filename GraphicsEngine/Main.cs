using GraphicsEngine.DataTypes;
using GraphicsEngine.SceneObjects;

namespace GraphicsEngine;
public partial class Main : Form
{
    private Camera camera;
    public Main()
    {
        this.Paint += Main_Paint;
        this.KeyDown += Main_KeyDown;
        camera = new Camera(
            new Vector3(-150, 0, 0),
            new Vector3(1, 0, 0),
            new Vector3(0, 1, 0)
        );
        InitializeComponent();
    }

    private void Main_KeyDown(object? sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.A) camera.Position.X -= 50;
        if (e.KeyCode == Keys.D) camera.Position.X += 50;
        if (e.KeyCode == Keys.J) camera.UAxis.Z += 1;
        if (e.KeyCode == Keys.K) camera.UAxis.Z -= 1;
        
        this.Invalidate();
    }

    private void Main_Paint(object? sender, PaintEventArgs pe)
    {
        var g = pe.Graphics;
        var triangleInSpace = new BaseTriangle(new Vector3(10, 10, 70), new Vector3(40, 80, 60), new Vector3(60, 70, 90));
        var triangle = new ProjectedTriangle(camera.PointToPlane(triangleInSpace.Vertices[0]), camera.PointToPlane(triangleInSpace.Vertices[1]), camera.PointToPlane(triangleInSpace.Vertices[2]));
        
        g.DrawLine(Pens.Black, triangle.Vertices[0].X, triangle.Vertices[0].Y, triangle.Vertices[1].X, triangle.Vertices[1].Y);
        g.DrawLine(Pens.Black, triangle.Vertices[0].X, triangle.Vertices[0].Y, triangle.Vertices[2].X, triangle.Vertices[2].Y);
        g.DrawLine(Pens.Black, triangle.Vertices[1].X, triangle.Vertices[1].Y, triangle.Vertices[2].X, triangle.Vertices[2].Y);
        
        var triangleInSpace1 = new BaseTriangle(new Vector3(10, 10, 70), new Vector3(40, 80, 60), new Vector3(120, 80, 80));
        var triangle1 = new ProjectedTriangle(camera.PointToPlane(triangleInSpace1.Vertices[0]), camera.PointToPlane(triangleInSpace1.Vertices[1]), camera.PointToPlane(triangleInSpace1.Vertices[2]));
        
        g.DrawLine(Pens.Black, triangle1.Vertices[0].X, triangle1.Vertices[0].Y, triangle1.Vertices[1].X, triangle1.Vertices[1].Y);
        g.DrawLine(Pens.Black, triangle1.Vertices[0].X, triangle1.Vertices[0].Y, triangle1.Vertices[2].X, triangle1.Vertices[2].Y);
        g.DrawLine(Pens.Black, triangle1.Vertices[1].X, triangle1.Vertices[1].Y, triangle1.Vertices[2].X, triangle1.Vertices[2].Y);
        
        var triangleInSpace2 = new BaseTriangle(new Vector3(10, 10, 70), new Vector3(60, 70, 90), new Vector3(120, 80, 80));
        var triangle2 = new ProjectedTriangle(camera.PointToPlane(triangleInSpace2.Vertices[0]), camera.PointToPlane(triangleInSpace2.Vertices[1]), camera.PointToPlane(triangleInSpace2.Vertices[2]));
        
        g.DrawLine(Pens.Black, triangle2.Vertices[0].X, triangle2.Vertices[0].Y, triangle2.Vertices[1].X, triangle2.Vertices[1].Y);
        g.DrawLine(Pens.Black, triangle2.Vertices[0].X, triangle2.Vertices[0].Y, triangle2.Vertices[2].X, triangle2.Vertices[2].Y);
        g.DrawLine(Pens.Black, triangle2.Vertices[1].X, triangle2.Vertices[1].Y, triangle2.Vertices[2].X, triangle2.Vertices[2].Y);
    }
}
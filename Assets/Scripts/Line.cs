using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
	public LineRenderer lineRenderer;
	public EdgeCollider2D edgeCol;
    public LineType type;
    public float length = 15f;

	List<Vector2> points;
    public Vector2 start { get { return points[0]; } }
    public Vector2 end { get { return points[points.Count - 1]; } }

	public void CreateLine ()
	{
		
	}

	void SetPoint (Vector2 point)
	{
		points.Add(point);

		lineRenderer.positionCount = points.Count;
		lineRenderer.SetPosition(points.Count - 1, point);

		if (points.Count > 1)
			edgeCol.points = points.ToArray();
	}

}

public enum LineType
{
    Straight,
    HillDown,
    LineDown,
}
using UnityEngine;

namespace Asteroids.Logic
{
    public class Teleport
    {
        private readonly ScreenEdges _edges;

        public Teleport(ScreenEdges edges)
        {
            _edges = edges;
        }

        public void ToUpperTeleportation(Transform transform)
        {
            if (transform.position.y < _edges.Bottom)
                transform.position = new Vector2(transform.position.x, _edges.Top);
        }

        public void ToBottomTeleportation(Transform transform)
        {
            if (transform.position.y > _edges.Top)
                transform.position = new Vector2(transform.position.x, _edges.Bottom);
        }

        public void ToLeftTeleportation(Transform transform)
        {
            if (transform.position.x > _edges.Right)
                transform.position = new Vector2(_edges.Left, transform.position.y);
        }

        public void ToRightTeleportation(Transform transform)
        {
            if (transform.position.x < _edges.Left)
                transform.position = new Vector2(_edges.Right, transform.position.y);
        }
    }

    public class ScreenDiagonal
    {
        public float Height { get; private set; }
        public float Width { get; private set; }

        public float GetHeight(Camera main)
        {
            return Height = main.orthographicSize * 2;
        }

        public float GetWidth(Camera main)
        {
            return Width = main.orthographicSize * 2 * main.aspect;
        }
    }

    public class ScreenEdges
    {
        public float Top { get; private set; }
        public float Bottom { get; private set; }
        public float Right { get; private set; }
        public float Left { get; private set; }

        private readonly ScreenDiagonal _diagonal;

        public ScreenEdges(ScreenDiagonal diagonal)
        {
            _diagonal = diagonal;
        }

        public float GetTop()
        {
            return Top = _diagonal.Height / 2;
        }

        public float GetBottom()
        {
            return Bottom = Top * -1;
        }

        public float GetRight()
        {
            return Right = _diagonal.Width / 2;
        }

        public float GetLeft()
        {
            return Left = Right * -1;
        }
    }
}
using UnityEngine;
using Asteroids.Logic;

public class Teleportation : MonoBehaviour
{
    private Camera _mainCamera;
    private Transform _selfTrasform;

    private Teleport _telepot;
    private ScreenDiagonal _diagonal;
    private ScreenEdges _edges;

    private void Awake()
    {
        _diagonal = new ScreenDiagonal();
        _edges = new ScreenEdges(_diagonal);
        _telepot = new Teleport(_edges);
    }

    private void Start()
    {
        _mainCamera = Camera.main;
        _selfTrasform = GetComponent<Transform>();

        GetDiagonalScreen();
        GetEdgesScreen();
    }

    private void Update()
    {
        TryTeleportation();
    }   

    private void GetDiagonalScreen()
    {
        _diagonal.GetHeight(_mainCamera);
        _diagonal.GetWidth(_mainCamera);
    }

    private void GetEdgesScreen()
    {
        _edges.GetTop();
        _edges.GetBottom();
        _edges.GetRight();
        _edges.GetLeft();
    }

    private void TryTeleportation()
    {
        _telepot.ToUpperTeleportation(_selfTrasform);
        _telepot.ToBottomTeleportation(_selfTrasform);
        _telepot.ToRightTeleportation(_selfTrasform);
        _telepot.ToLeftTeleportation(_selfTrasform);
    }
}
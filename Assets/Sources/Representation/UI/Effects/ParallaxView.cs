using UnityEngine;
using UnityEngine.UI;
using Asteroids.Logic;

[RequireComponent(typeof(RawImage))]
public class ParallaxView : MonoBehaviour
{
    [SerializeField] private float _speedMoveImage;

    private RawImage _image;

    private Parallax _parallax;

    private void Awake()
    {
        _image = GetComponent<RawImage>();
        _parallax = new Parallax(_image);
    }

    private void Start()
    {
        _parallax.SetUVPositionX();
    }

    private void Update()
    {
        _parallax.ImageMovement(_speedMoveImage, Time.deltaTime);
        _parallax.ResetUVX();
        _parallax.SetImageUVRect();
    }
}

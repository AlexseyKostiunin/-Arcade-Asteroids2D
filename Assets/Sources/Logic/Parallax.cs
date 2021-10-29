using UnityEngine;
using UnityEngine.UI;

namespace Asteroids.Logic
{
    public class Parallax
    {
        private readonly RawImage _image;
        private float _imageUVPositionX;

        private const int _maxUVX = 1;
        private const int _minUVX = 0;

        public Parallax(RawImage image)
        {
            _image = image;
        }

        public void ImageMovement(float speedMoveImage, float deltaTime)
        {
            _imageUVPositionX += speedMoveImage * deltaTime;
        }

        public void SetImageUVRect()
        {
            _image.uvRect = new Rect(_imageUVPositionX, 0, _image.uvRect.width, _image.uvRect.height);
        }

        public void ResetUVX()
        {
            if (_imageUVPositionX > _maxUVX)
                _imageUVPositionX = _minUVX;
        }

        public void SetUVPositionX()
        {
            _imageUVPositionX = _image.uvRect.x;
        }
    }
}
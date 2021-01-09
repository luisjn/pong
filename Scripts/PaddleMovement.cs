using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    private Camera _cameraMain;
    private Vector3 position;

    private void Start()
    {
        _cameraMain = Camera.main;
        position = transform.position;
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        var mousePositionOnY = _cameraMain.ScreenToWorldPoint(Input.mousePosition).y;
        position = new Vector3(position.x, Mathf.Clamp(mousePositionOnY, -3.8f, 3.8f), position.z);
        transform.position = position;
    }
}

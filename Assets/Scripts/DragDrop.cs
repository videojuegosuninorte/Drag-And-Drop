using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour
{
    private Camera _camara;
    private Vector3 _dragOffset;
    private Vector2 _originalPosition;
    [SerializeField] private float speed = 10;
    private void Awake()
    {
        _camara = Camera.main;
    }

    private void OnMouseDrag()
    {
        transform.position = Vector3.MoveTowards(transform.position, GetMousePos() + _dragOffset, speed * Time.deltaTime);
    }

    private void OnMouseDown()
    {
        _originalPosition = transform.position;
        _dragOffset = transform.position - GetMousePos();

    }

    private void OnMouseUp()
    {
        Cell h = DragManager.Instance.GetNearObject(this.transform.position);
        if (h == null)
        {
            transform.position = _originalPosition;
        } else
        {
            transform.position = h.Position;
        }
    }

    Vector3 GetMousePos()
    {
        var mousePos = _camara.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;

        return mousePos;
    }

}

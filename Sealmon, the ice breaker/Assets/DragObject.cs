using UnityEngine;

public class DragObject : MonoBehaviour
{

    public Vector3 screenPoint;
    Vector3 offset;
    Vector3 scanPos;
    Transform trans;

    public float maxX;
    public float maxY;

    void Start()
    {
        trans = this.transform;

        scanPos = trans.position;

    }

    void Update(){}

    void OnMouseDown()
    {
        screenPoint = Camera.main.WorldToScreenPoint(scanPos);
        offset = scanPos - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, 
                                                                      Input.mousePosition.y, 
                                                                      screenPoint.z));
    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        trans.position = curPosition;
        float posX = Mathf.Clamp(trans.position.x, - maxX, maxX);
        float posY = Mathf.Clamp(trans.position.y, - maxY, maxY);
        trans.position = new Vector3(posX, posY, curPosition.z);
    }

    void OnMouseUp()
    {
        trans.position = scanPos;
    }
}
    
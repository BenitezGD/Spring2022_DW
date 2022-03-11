using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Drag : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    Vector2 lastMousePosition;
    public RectTransform correctSlot;
    public RectTransform wrongSlot1;
    public RectTransform wrongSlot2;
    public RectTransform wrongSlot3;

    public bool correct = false;

    public Vector3 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        lastMousePosition = eventData.position;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 currentMousePosition = eventData.position;
        Vector2 diff = currentMousePosition - lastMousePosition;
        RectTransform rect = GetComponent<RectTransform>();

        Vector3 newPosition = rect.position + new Vector3(diff.x, diff.y, transform.position.z);
        Vector3 oldPos = rect.position;
        rect.position = newPosition;
        if (!IsRectTransformInsideSreen(rect))
        {
            rect.position = oldPos;
        }
        lastMousePosition = currentMousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("End Drag");

        if(transform.position.x > correctSlot.position.x - 100 && transform.position.x < correctSlot.position.x + 100 && transform.position.y > correctSlot.position.y - 100 && transform.position.y < correctSlot.position.y + 100)
        {
            transform.position = correctSlot.position;
            correct = true;
        }

        else if (transform.position.x > wrongSlot1.position.x - 100 && transform.position.x < wrongSlot1.position.x + 100 && transform.position.y > wrongSlot1.position.y - 100 && transform.position.y < wrongSlot1.position.y + 100)
        {
            transform.position = wrongSlot1.position;
            correct = false;
        }

        else if (transform.position.x > wrongSlot2.position.x - 100 && transform.position.x < wrongSlot2.position.x + 100 && transform.position.y > wrongSlot2.position.y - 100 && transform.position.y < wrongSlot2.position.y + 100)
        {
            transform.position = wrongSlot2.position;
            correct = false;
        }

        else if (transform.position.x > wrongSlot3.position.x - 100 && transform.position.x < wrongSlot3.position.x + 100 && transform.position.y > wrongSlot3.position.y - 100 && transform.position.y < wrongSlot3.position.y + 100)
        {
            transform.position = wrongSlot3.position;
            correct = false;
        }

        else
        {
            transform.position = startPosition;
            correct = false;
        }

        //Implement your funtionlity here
    }

    private bool IsRectTransformInsideSreen(RectTransform rectTransform)
    {
        bool isInside = false;
        Vector3[] corners = new Vector3[4];
        rectTransform.GetWorldCorners(corners);
        int visibleCorners = 0;
        Rect rect = new Rect(0, 0, Screen.width, Screen.height);
        foreach (Vector3 corner in corners)
        {
            if (rect.Contains(corner))
            {
                visibleCorners++;
            }
        }
        if (visibleCorners == 4)
        {
            isInside = true;
        }
        return isInside;
    }
}

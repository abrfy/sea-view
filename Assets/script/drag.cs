using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class drag : MonoBehaviour
{
    private float posX, posY;
    private bool dragging = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (dragging == true)
        {
            Vector2 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            this.gameObject.transform.localPosition = new Vector2(mousePos.x - posX, mousePos.y - posY);
        }
    }
    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            posX = mousePos.x-this.transform.localPosition.x;
            posY = mousePos.y-this.transform.localPosition.y;
            dragging = true;
        }
    }
    private void OnMouseUp()
    {
        dragging = false; 
    }
    
}

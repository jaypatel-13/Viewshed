using UnityEngine;

public class Location : MonoBehaviour
{
    private Camera cam;

    void Start()
    {
        cam = Camera.main;
    }

   void OnGUI()
    {
        Vector3 point = new Vector3();
        Event   currentEvent = Event.current;
        Vector2 mousePos = new Vector2();

        // Get the mouse position from Event.
        // Note that the y position from Event is inverted.
        mousePos.x = currentEvent.mousePosition.x;
        mousePos.y = cam.pixelHeight - currentEvent.mousePosition.y;

        point = cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, cam.nearClipPlane));
         Vector4 mousePos1=new Vector4();
         mousePos1.x = Input.mousePosition.x;
         mousePos1.y=cam.pixelHeight-currentEvent.mousePosition.y;

        GUILayout.BeginArea(new Rect(20, 20, 250, 120));
        GUILayout.Label("Screen pixels: " + cam.pixelWidth + ":" + cam.pixelHeight);
        GUILayout.Label("Mouse position: " + mousePos);
        GUILayout.Label("World position: " + point.ToString("F3"));
        GUILayout.Label("Mouse Down position: " + mousePos1);
        GUILayout.EndArea();
    }
    /*void OnMouseDown()
    {
         Vector4 mousePos=new Vector4();
         Event currentEvent=Event.current;
         mousePos.x = Input.mousePosition.x;
         mousePos.y=cam.pixelHeight-currentEvent.mousePosition.y;
         GUILayout.BeginArea(new Rect(20,20,250,120));
         GUILayout.Label("Mouse Down position: " + mousePos);
         GUILayout.EndArea();
   // some more action you want on initial mouse click?
    }*/
 
    /*void OnMouseDrag()
    {
     //your action if the mouse moves while pressed (dunno if this Drag function also works if you don't move anything actually)
      
    }*/
 
    /*void OnMouseUp()
    {
      // you could also check the condition here again when we release the mouse button again
    if(mousePosX != Input.mousePosition.x)
    {
      // we defenitely moved the mouse, some action here.
    }*/
}
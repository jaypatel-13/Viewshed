using UnityEngine;

public class CameraController : MonoBehaviour
{

    public float panSpeed = 30f;
    public float panBorderThickness = 10f;
    public Vector2 panLimit;
    public float minY = 20f;
    public float maxY = 120f;
    public float rotX = 35,rotY = 0;
    public Quaternion localRotation;
    public float rotationSpeed = 30.0f;
    public float scrollSpeed = 20f;
    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey("w")) 
        {
            pos.z += panSpeed * Time.deltaTime;
            
        }
        if (Input.GetKey("s")) 
        {
            pos.z -= panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            pos.x += panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("a") )
        {
            pos.x -= panSpeed * Time.deltaTime;
        }

        float scroll = Input.GetAxis("Mouse ScrollWheel");
        pos.y -= scroll * scrollSpeed * 100f * Time.deltaTime;

        pos.x = Mathf.Clamp(pos.x, -panLimit.x, panLimit.x);
        pos.y = Mathf.Clamp(pos.y, minY, maxY);
        
        pos.z = Mathf.Clamp(pos.z, -panLimit.y, panLimit.y);
        transform.position = pos;

        if(Input.GetKey(KeyCode.UpArrow))
        {
        rotX -= Time.deltaTime * rotationSpeed;
        localRotation = Quaternion.Euler(rotX, rotY, 0.0f);
        transform.rotation = localRotation;
        

        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
        rotX += Time.deltaTime * rotationSpeed;
        localRotation = Quaternion.Euler(rotX, rotY, 0.0f);
        transform.rotation = localRotation;
    
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
        rotY -= Time.deltaTime * rotationSpeed;
        localRotation = Quaternion.Euler(rotX, rotY, 0.0f);
        transform.rotation = localRotation;
    
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
        rotY += Time.deltaTime * rotationSpeed;
        localRotation = Quaternion.Euler(rotX, rotY, 0.0f);
        transform.rotation = localRotation;
        
        }

    }
    
   
}

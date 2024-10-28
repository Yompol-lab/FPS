using UnityEngine;

public class GunController : MonoBehaviour
{
    public Transform playerCamera; 
    public Vector3 offset; 

    public void Start()
    {

        offset = new Vector3(0.25f, -0.11f, 0.43f);
    }

    void Update()
    {
       
        transform.position = playerCamera.position + playerCamera.TransformDirection(offset);
        transform.rotation = playerCamera.rotation;
    }
}

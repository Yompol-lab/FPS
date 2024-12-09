using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; 
    public float mouseSensitivity = 2f; 
    public float jumpHeight = 2f; 

    private Camera playerCamera;
    private CharacterController characterController;
    private float verticalRotation = 0f; 
    private Vector3 velocity; 
    private bool isGrounded; 

    void Start()
    {
        playerCamera = GetComponentInChildren<Camera>();
        characterController = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked; 
    }

    void Update()
    {
       
        isGrounded = characterController.isGrounded;

        float moveHorizontal = Input.GetAxis("Horizontal") * moveSpeed;
        float moveVertical = Input.GetAxis("Vertical") * moveSpeed;

        Vector3 move = transform.right * moveHorizontal + transform.forward * moveVertical;

       
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = 0; 
        }

        
        if (isGrounded && Input.GetButtonDown("Jump")) 
        {
            velocity.y += Mathf.Sqrt(jumpHeight * -2f * Physics.gravity.y); 
        }

        velocity.y += Physics.gravity.y * Time.deltaTime;
        characterController.Move((move + velocity) * Time.deltaTime);

        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        verticalRotation -= mouseY;
        verticalRotation = Mathf.Clamp(verticalRotation, -90f, 90f); 

        playerCamera.transform.localRotation = Quaternion.Euler(verticalRotation, 0, 0);
        transform.Rotate(Vector3.up * mouseX);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("EnemyBullet")) 
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            Destroy(gameObject);
            SceneManager.LoadScene("Moriste");

        }
    }

}

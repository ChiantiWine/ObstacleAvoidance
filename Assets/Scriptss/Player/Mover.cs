using UnityEngine;
using UnityEngine.InputSystem;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    Vector2 movement;

    void Update()
    {
        // MovePlayer();
        MoveTranslation();
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(xValue, yValue, zValue );  
    }

    void MoveTranslation()
    {
        Vector3 move = new Vector3(movement.x, 0f, movement.y) * moveSpeed * Time.deltaTime;
        transform.Translate(move);
    }

    // CallbackContext
    public void OnMove(InputAction.CallbackContext callbackContext)
    {
        movement = callbackContext.ReadValue<Vector2>();
    }    
}

   

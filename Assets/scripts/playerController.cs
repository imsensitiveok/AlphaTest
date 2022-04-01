using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//script references youtube video by Sebastian Lague - Character Creation (E07: Unity character controller) 
//https://www.youtube.com/watch?v=ZwD1UHNCzOc 

public class playerController : MonoBehaviour
{

    public float walkSpeed = 5;

    Animator chameleonAnimator;

    public float turnSmoothTime = 0.2f;
    float turnSmoothVelocity;

    public float speedSmoothTime = 0.1f;
    float speedSmoothVelocity; 
    float currentSpeed;

    public Transform camera;
    public Camera mainCamera; 
    public Camera backCamera; 

     
    // Start is called before the first frame update
    void Start()
    {
        chameleonAnimator = GetComponent<Animator>();
        mainCamera.enabled = true;
        backCamera.enabled = false; 
    }

    // Update is called once per frame
    void Update()
    {
        //get the input vector controls from player (x direction, y direction) - can use arrow or ASWD 
        Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        if (Input.GetKey("s") == true)
        {
            mainCamera.enabled = false;
            backCamera.enabled = true; 
        }
        else
        {
            mainCamera.enabled = true;
            backCamera.enabled = false; 
        }

        //convert input vector into a direction 
        Vector2 inputDirection = input.normalized;

        //only calculate the direction if the input direction is not 0, 0 (default direction) 
        if (inputDirection != Vector2.zero)
        {
            //calculate the rotation of the character according to the input keys (uses trig) 
            float targetRotation = Mathf.Atan2(inputDirection.x, inputDirection.y) * Mathf.Rad2Deg + camera.eulerAngles.y;
            //transform the character according to the targetRotation, uses SmoothDampAngle to ease transition between rotations 
            transform.eulerAngles = Vector3.up * Mathf.SmoothDampAngle(transform.eulerAngles.y, targetRotation, ref turnSmoothVelocity, turnSmoothTime);
        }

        //set the speed of the player's movements 
        float targetSpeed = walkSpeed * inputDirection.magnitude;
        //set the current speed to transition between idle movement and walking speed using SmoothDamp
        currentSpeed = Mathf.SmoothDamp(currentSpeed, targetSpeed, ref speedSmoothVelocity, speedSmoothTime);

        //move the character in the direction that the character is facing, moving it in world space 
        transform.Translate(transform.forward * currentSpeed * Time.deltaTime, Space.World);

        //use the animator controller to play the character animation when walking 
        float animationSpeedPercent = 1f * inputDirection.magnitude;
        chameleonAnimator.SetFloat("speedPercent", animationSpeedPercent);//, speedSmoothTime, Time.deltaTime); 

        /*
        float targetRotation = 0;  
        //get the input vector controls from player (x direction, y direction) - can use arrow or ASWD 
        Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        //convert input vector into a direction 
        Vector2 inputDirection = input.normalized;

        //only calculate the direction if the input direction is not 0, 0 (default direction) 
        if (inputDirection != Vector2.zero)
        {
            //calculate the rotation of the character according to the input keys (uses trig), add in the rotation of the camera so that 
            //when the character turns, the new "forward direction" is the direction the character is currently facing 
            targetRotation = Mathf.Atan2(inputDirection.x, inputDirection.y) * Mathf.Rad2Deg;// + camera.eulerAngles.y;
            //transform the character according to the targetRotation, uses SmoothDampAngle to ease transition between rotations 
            transform.eulerAngles = Vector3.up * Mathf.SmoothDampAngle(transform.eulerAngles.y, targetRotation, ref turnSmoothVelocity, turnSmoothTime);
        }

        //set the speed of the player's movements 
        float targetSpeed = walkSpeed * inputDirection.magnitude;
        //set the current speed to transition between idle movement and walking speed using SmoothDamp
        currentSpeed = Mathf.SmoothDamp(currentSpeed, targetSpeed, ref speedSmoothVelocity, speedSmoothTime);

        //set a vector that stores the data on where to move the character, multiply by vector3.forward to change from rotation to direction
        Vector3 moveDirection = Quaternion.Euler(0f, targetRotation, 0f) * Vector3.forward; 

        //move the character in the direction that the character is facing, moving it in world space 
        transform.Translate(moveDirection * currentSpeed * Time.deltaTime, Space.Self);

        //use the animator controller to play the character animation when walking 
        float animationSpeedPercent = 1f * inputDirection.magnitude;
        chameleonAnimator.SetFloat("speedPercent", animationSpeedPercent);//, speedSmoothTime, Time.deltaTime); 

        */


    }
}

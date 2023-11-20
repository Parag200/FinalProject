using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMove : MonoBehaviour
{
    //endlevel1 is locked start of level
    private bool endlevel1 = false;
   
    //achievement manager 
    private AchieveManager achievementManager;


    private float speed = 7.0f;
    private float JumpForce = 7.0f;
    private Rigidbody rb;

    public ParticleSystem colparticleSystem;

    public GameObject coin;

    private Animator animator;

    private bool isJumping;
    private bool isGrounded;
    private bool isRunning;
    private bool isIdle;
    public bool end = false;
    public bool endcuslose = false;

   //on awake
    void Awake()
    {
        //finding the direct gameobject that has the achievemanager
        achievementManager = FindObjectOfType<AchieveManager>();
        
    }

    // Start is called before the first frame update
    void Start()
    {
       
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        animator.SetBool("IsIdle", true);
        isIdle = true;
        
    }

    // Update is called once per frame
    void Update()
    {
      

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(verticalInput * speed, rb.velocity.y, horizontalInput * -speed);

        if (horizontalInput != 0.0f || verticalInput != 0.0f)
        {
            animator.SetBool("IsRunning", true);
            isRunning = true;
            //Debug.Log("Running");

            animator.SetBool("IsIdle", false);
            isIdle = false;

            animator.SetBool("IsGrounded", true);
            isGrounded = true;

            animator.SetBool("IsJumping", false);
            isRunning = false;

            //AudioManager.Instance.playFX("Footsteps", 0.4f);
           
        }

      

        if (horizontalInput == 0.0f && verticalInput == 0.0f)
        {
            //Debug.Log("Standing Idle");
            animator.SetBool("IsIdle", true);
            isIdle = true;

            animator.SetBool("IsRunning", false);
            isRunning = false;

            animator.SetBool("IsGrounded", true);
            isGrounded = true;

            animator.SetBool("IsJumping", false);
            isRunning = false;

        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("IsJumping", true);
            isRunning = true;

            rb.velocity = new Vector3(rb.velocity.x, JumpForce, rb.velocity.z);
            colparticleSystem.Play();

            AudioManager.Instance.playFX("Jump", 1f);

        }

       

        if (Input.GetKeyDown(KeyCode.Y))
        {

            this.GetComponent<Blur>().enabled = true;
        }

        //if endlevel1 is true the achievement will show
        if (endlevel1 == true)
        {

            achievementManager.UnlockAchievement("The End");
        }

        //incase there is error, notify us that achievemanagment is not working
        if (achievementManager == null)
        {
            Debug.LogError("AchievementManager reference is null!");
            return;
        }

    }
    

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name == ("DeathTrigger"))
        {
            SceneManager.LoadScene("Dead");
            endcuslose = true;
        }

        else if (other.gameObject.name == ("WinTrigger"))
        {
            SceneManager.LoadScene("Coins");
            end = true;
        }

        //once player enters this trigger, the end of level achievement unlocked is now true 
        else if (other.gameObject.name == ("EndTrigger"))
        {
            
            endlevel1 = true;
        }

      
    }
}


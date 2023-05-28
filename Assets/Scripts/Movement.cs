using UnityEngine;


public class Movement : MonoBehaviour
{
    public static Movement inst;
    public Animator anim;
    [SerializeField] private Rigidbody rb;
    public float speed = 5f;
    private Vector3 inputVector;
    float inputAmount;
    public bool isGrounded = false;
    float x;
    float y;
    float walkfactor;
    public bool canwalk=true;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        if(inst==null)
        {
            inst = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
      
    {
        if (canwalk == true)
        {
            x = Input.GetAxis("Horizontal");
            y = Input.GetAxis("Vertical");
            walkfactor = Mathf.Abs(x) + Mathf.Abs(y);
            anim.SetFloat("walkfactor", walkfactor);
            inputVector = new Vector3(Input.GetAxis("Horizontal") * speed, rb.velocity.y, Input.GetAxis("Vertical") * speed);
            transform.LookAt(transform.position + new Vector3(inputVector.x, 0, inputVector.z));

            float inputMagnitude = Mathf.Abs(Input.GetAxis("Horizontal")) + Mathf.Abs(Input.GetAxis("Vertical"));
            inputAmount = Mathf.Clamp01(inputMagnitude);
        }
        
    }

    private void FixedUpdate()
    {
        
        
            rb.velocity = inputVector;
        
    }
   
    
}
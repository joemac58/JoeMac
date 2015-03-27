using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour
{
    public float xSpeed = 0.0f;         // x speed
    public float tilt = 0.0f;           // tilt speed
    public float xMin, xMax;            // x movement range
	
    private float xInput = 0.0f;        // x input
    private float xMove = 0.0f;         // x movement (input * speed)

	//public bool isGrounded = true;
	public GameObject target;		

	void Start(){
		GetComponent<AudioSource>().Stop ();
	}

    // Update is called once per frame
    void Update()
    {
        // use our input's horizontal controls (keys a & d || left & right)
        xInput = Input.GetAxis("Horizontal");
        xMove = xInput * xSpeed;

    }
	

    // FixedUpdate is a physics update and used when working with rigibodys
    void FixedUpdate()
    {
        
		// apply input's x movement to rigidbody velocity to move player
        GetComponent<Rigidbody>().velocity = new Vector3(xMove, 0.0f, 0.0f);

		// multiply our x velocity by our public tilt variable
        // we also reverse the value by multiplying against a negative
        // apply this value to our z rotation to create a tilting effect
        float playerTilt = GetComponent<Rigidbody>().velocity.x * tilt;
        GetComponent<Rigidbody>().rotation = Quaternion.Euler(0.0f, 0.0f, playerTilt);


        // clamp player position to be inside game bounds
        GetComponent<Rigidbody>().position = new Vector3(Mathf.Clamp(GetComponent<Rigidbody>().position.x, xMin, xMax),GetComponent<Rigidbody>().position.y,0.0f);
		/*
		if (Input.GetButtonDown ("Jump")) 
			{
				Debug.Log("you clicked jump");
				isGrounded = false;
			}
		/*
		if(isGrounded == false)
			{
				rigidbody.AddForce(new Vector3(0, 100 * rigidbody.mass, 0), ForceMode.Impulse);
				isGrounded = true;
			}
		*/		
			
    }



    // when an object enters player trigger collider
    void OnTriggerEnter(Collider collisions){
		target = GameObject.Find ("SpillMeter");
		target.SendMessage ("isHit");
		GetComponent<AudioSource>().Play ();
		//target = GameObject.Find ("ChaserSlider");
		//target.SendMessage ("isNotSlowDown");
		target = GameObject.Find ("CupMeterSlider");
		target.SendMessage ("isNotRangeA");

    }
}
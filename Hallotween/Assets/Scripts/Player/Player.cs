using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public GameObject move_object, turn_object;
    public int health;
    public float move_speed, turn_speed;
    public Rigidbody player_rigidbody;

	// Use this for initialization
	void Start () {
        player_rigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void LateUpdate () {
        Handle_User_Input();
	}

    void Handle_User_Input()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 forward, sideways, move;
        forward = this.transform.forward * vertical * (move_speed * Time.deltaTime);
        sideways = this.transform.right * horizontal * (move_speed * Time.deltaTime);
        move = forward + sideways;
        player_rigidbody.velocity = move;
    }
}

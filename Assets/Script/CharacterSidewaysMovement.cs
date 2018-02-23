using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSidewaysMovement : MonoBehaviour {

    private Vector3 moveDirection = Vector3.zero;

    public float gravity = 20f;

    private CharacterController controller;

    private Animator anim;

    private bool isChangingLane = false;
    private Vector3 locationAfterChangingLane;

    private Vector3 sidewaysMovementDistance = Vector3.right * 2f;


    public float JumpSpeed = 8.0f;

    public float Speed = 6.0f;

    //character Object
    public Transform CharacterGO;

    //IInputDetector inputDectector = null;


	// Use this for initialization
	void Start () {
        moveDirection = transform.forward;
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= Speed;

        UIManager.Instance.ResetScore();
        UIManager.Instance.SetStatus(Constants.StatusTapToStart);

        GameManager.Instance.GameState = Constants.GameState.Start;

        anim = CharacterGO.GetComponent();
        inputDectector = GetComponent();
        controller = GetComponent();
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    private void CheckHeight()
}

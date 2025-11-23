using UnityEngine;
using Photon.Pun; 

public class PlayerMovement : MonoBehaviourPun
{
    public float speed = 5f;
    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (photonView != null && !photonView.IsMine) return;

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(h, 0, v);
        if (move.magnitude > 1f) move = move.normalized;
        controller.SimpleMove(move * speed);
    }
}

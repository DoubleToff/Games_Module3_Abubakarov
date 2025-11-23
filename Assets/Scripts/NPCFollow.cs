using UnityEngine;

public class NPCFollow : MonoBehaviour
{
    private Transform player;
    public float speed = 3f;

    void Update()
    {
        if (player == null)
        {
            GameObject p = GameObject.FindWithTag("Player");
            if (p != null) player = p.transform;
            return; 
        }

        transform.position = Vector3.MoveTowards(
            transform.position,
            player.position,
            speed * Time.deltaTime
        );
    }
}

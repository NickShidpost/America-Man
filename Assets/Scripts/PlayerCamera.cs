using AC;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public bool FollowPlayer = false;

    Transform Player;
    Vector3 Velocity = Vector3.zero;

    void Start()
    {
        IEnumerator Delay()
        {
            yield return null;
            Player = FindObjectOfType<Player>().transform;
        }

        StartCoroutine(Delay());
    }

    void Update()
    {
        if (FollowPlayer)
        {
            Vector3 TargetPosition = Player.transform.position;
            TargetPosition.z = -10;
            TargetPosition.y = 0;

            transform.position = Vector3.SmoothDamp(transform.position, TargetPosition, ref Velocity, 0.25f);
        }        
    }

    public void SetCameraFollow(bool Value)
    {
        FollowPlayer = Value;
    }

    public void movePlayer()
    {

    }
}

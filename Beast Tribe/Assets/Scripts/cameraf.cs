using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraf : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform target;
    [SerializeField]
    private Vector3 offsetPosition;
    void Awake()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }
    void LateUpdate()
    {
        FollowPlayer();
    }

void FollowPlayer() {
        transform.position = target.TransformPoint(offsetPosition);
        transform.rotation = target.rotation;
            }
}

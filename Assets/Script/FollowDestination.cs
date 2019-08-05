using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowDestination : MonoBehaviour
{
    GameObject[] destinations;
    Transform destination;

    public float speed = 5.0f;
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        destinations = GameObject.FindGameObjectsWithTag("waypoint");
        player = GameObject.FindGameObjectWithTag("Player");
        destination = destinations[Random.Range(0, destinations.Length)].transform;
    }

    // Update is called once per frame
    void Update()
    {
        //translacion
        float space = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, destination.position, space);

        //rotacion
        Vector3 targetDirection = destination.position - transform.position;
        Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, space, 0);

        Debug.DrawRay(transform.position, newDirection, Color.red);
        transform.rotation = Quaternion.LookRotation(newDirection);

        //cambio de target
        if (targetDirection.magnitude < 0.1f)
        {
            float rnd = Random.Range(0.0f, 1.0f);
            if (rnd < 0.9f)
            {
                destination = destinations[Random.Range(0, destinations.Length)].transform;
            }
            else
            {
                destination = player.transform;
            }
        }
    }
}

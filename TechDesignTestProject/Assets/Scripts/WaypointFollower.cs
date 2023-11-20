using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    [SerializeField] private GameObject[] waypoints;        // Array of waypoints
    private int currentWaypointIndex = 0;
    private bool isMoving = false;
    [SerializeField] private float speed = 2f;

    void Update()
    {
        if (isMoving)
        {
            if (Vector2.Distance(waypoints[currentWaypointIndex].transform.position, transform.position) < 1f)      //Check if near waypoint
            {
                currentWaypointIndex++;
                if (currentWaypointIndex >= waypoints.Length)       //Reset index if at the end
                {
                    currentWaypointIndex = 0;
                }
            }

            transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, Time.deltaTime * speed);        //Move object toward waypoint
        }
    }

    void OnMouseDown() //Update moving on mouse click
    {
        isMoving ^= true;
    }
}

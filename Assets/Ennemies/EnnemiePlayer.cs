using UnityEngine;

public class EnnemiePlayer : MonoBehaviour
{
    public float speed = 13f;
    private Transform target;
    private int wayIndex = 0;
    public GameObject player;

    void Start()
    {
        target = Waypoints.points[0];
        player = GameObject.Find("Player");
    }

    private void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        transform.LookAt(player.transform.position);

        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            GetNextWaypoint();
        }
    }

    private void GetNextWaypoint()
    {
        if (wayIndex >= Waypoints.points.Length - 1)
        {
            EndPath();
            return;
        }

        wayIndex++;
        target = Waypoints.points[wayIndex];
    }

    private void EndPath()
    {
        Destroy(gameObject);
    }
}

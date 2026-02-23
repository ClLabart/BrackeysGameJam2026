using UnityEngine;

public class Timers : MonoBehaviour
{
    private float timer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(timer);
        timer = PlayerStats.timeToReturn;
        Debug.Log(timer);
    }

    // Update is called once per frame
    void Update()
    {
        timer -= PlayerStats.dysphoria;

        Debug.Log(timer);

        if (timer < 0)
        {
            Debug.Log("stop pls");
        }
    }
}

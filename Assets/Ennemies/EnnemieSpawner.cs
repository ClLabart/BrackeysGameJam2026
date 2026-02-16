using UnityEngine;
using UnityEngine.InputSystem;

public class EnnemieSpawner : MonoBehaviour
{
    [Header("Input Actions")]
    public InputActionReference spawnAction;

    [SerializeField]
    private Transform ennemiePrefab;

    [SerializeField]
    private Transform spawnPoint;

    private void OnEnable()
    {
        spawnAction.action.Enable();
    }

    private void OnDisable()
    {
        spawnAction.action.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnAction.action.WasPressedThisFrame())
        {
            Instantiate(ennemiePrefab, spawnPoint.position, spawnPoint.rotation);
        }
    }
}

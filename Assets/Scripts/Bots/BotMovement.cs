using UnityEngine;
using UnityEngine.AI;

public class BotMovement : MonoBehaviour {
    private GameObject player;
    private NavMeshAgent agent;
    private Camera mainCamera;
    private void Awake() {
        player = GameObject.FindGameObjectWithTag("Player");
        mainCamera = Camera.main;
        agent = GetComponent<NavMeshAgent>();
    }
    void Update() {
        RaycastHit hit;
        if (Physics.Raycast(mainCamera.ScreenPointToRay(player.transform.position), out hit, 100)) {
            agent.destination = hit.point;
        }
    }
}

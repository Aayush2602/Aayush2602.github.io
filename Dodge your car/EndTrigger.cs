
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public Gamemanager gameManager;
    private void OnTriggerEnter(Collider other)
    {
        gameManager.completeLevel();
    }
}

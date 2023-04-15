
using UnityEngine;

public class EndTriggered : MonoBehaviour
{

    public GameManager gameManager;
    private void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }
}

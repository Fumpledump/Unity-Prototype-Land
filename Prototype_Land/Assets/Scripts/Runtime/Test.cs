using UnityEngine;

public class Test : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] private string deubugMessage;

    [Header("Components")]
    [SerializeField] private Logger logger;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        if(logger == null) logger = Logger.Instance;
        
        logger.Log(deubugMessage, this);
    }
}

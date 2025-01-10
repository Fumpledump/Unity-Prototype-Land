using UnityEngine;

public class Logger : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] private bool _showLogs = true;
    [SerializeField] private string _prefix;
    [SerializeField] private Color _prefixColor;
    [Tooltip("Set this script as the instance.")]
    [SerializeField] private  bool setInstance; // Used for Ungrouped Logging so that any script that needs to quickly log something can still be managed
    
    [Header("Components")]
    private static Logger instance;

    public static Logger Instance
    {
        get { return instance; }
    }

    private void Awake()
    {
        if (setInstance) instance = this;
    }

    // Creates a Debug Log that can now be managed through the editor
    public void Log(object message, Object sender)
    {
        if (!_showLogs) return;

        // Convert the Color to a hexadecimal string
        string hexColor = ColorUtility.ToHtmlStringRGB(_prefixColor);

        Debug.Log($"<color=#{hexColor}>{_prefix}</color>: {message}", sender);
    }
}

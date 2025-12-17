using UnityEngine;
using UnityEngine.InputSystem;

public class AnimationManager : MonoBehaviour
{
    // Singleton (simple pattern)
    public static AnimationManager Instance;

    [Header("Door Animator Reference")]
    public Animator doorAnimator;

    private void Awake()
    {
        // Check Animator reference
        if (doorAnimator == null)
        {
            Debug.LogError("DoorAnimator: no Animator found.");
        }

        // Enforce singleton
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;

        // If you want this manager to persist across scenes uncomment:
        // DontDestroyOnLoad(gameObject);
    }

    [ContextMenu("OpenDoor")]
    public void OpenDoor()
    {
        if (doorAnimator != null)
            doorAnimator.SetBool("isOpen", true);
    }

    [ContextMenu("CloseDoor")]
    public void CloseDoor()
    {
        if (doorAnimator != null)
            doorAnimator.SetBool("isOpen", false);
    }

    // Alternative Approach
    public void ToggleDoor()
    {
        if (doorAnimator != null)
        {
            bool current = doorAnimator.GetBool("isOpen");
            doorAnimator.SetBool("isOpen", !current);
        }
    }
}

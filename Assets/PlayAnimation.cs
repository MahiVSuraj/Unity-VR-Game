using UnityEngine;

public class PlayAnimation : MonoBehaviour
{
    private Renderer objectRenderer;
    private Animator animator;

    void Start()
    {
        // Get the Renderer and Animator components
        objectRenderer = GetComponent<Renderer>();
        animator = GetComponent<Animator>();

        // Initially hide the object
        objectRenderer.enabled = false;
    }

    void Update()
    {
        // Check if any key is pressed
        if (Input.anyKeyDown)
        {
            // Make the object visible
            objectRenderer.enabled = true;

            // Play the animation
            animator.SetTrigger("Play");
        }
    }
}

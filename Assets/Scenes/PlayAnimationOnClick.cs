using UnityEngine;

public class PlayAnimationOnClick : MonoBehaviour
{
    public Animator animator; // Drag the Animator component of your character here in the Inspector
    public GameObject character; // Drag the GameObject of your character here in the Inspector

    void Start()
    {
        // Disable the animator initially
        animator.enabled = false;

        // Disable the character GameObject initially
        character.SetActive(false);
    }

    public void PlayAnimation()
    {
        // Enable the animator when the button is clicked
        animator.enabled = true;

        // Enable the character GameObject when the button is clicked
        character.SetActive(true);
    }
}
using UnityEngine;

public class Diamond : Shape
{
    // Additional properties specific to Diamond
    public float sparkleIntensity;

    // Start is called before the first frame update
    void Start()
    {
        // Initialize the diamond-specific properties
        sparkleIntensity = 1.0f; // Default sparkle intensity for diamonds
        color = Color.cyan; // Default color for diamonds
    }

    // Update is called once per frame
    void Update()
    {
        // Update logic specific to Diamond, if necessary
        // For example, you could make the diamond "sparkle" periodically
        Sparkle();
    }

    // Override the Interact method for Diamond-specific behavior
    public override void Interact()
    {
        // Specific interaction behavior for Diamond
        Debug.Log("Interacting with a Diamond. It sparkles brightly!");
        IncreaseSparkle();
    }

    // Method specific to Diamond to increase its sparkle
    private void IncreaseSparkle()
    {
        sparkleIntensity += 0.5f;
        if (sparkleIntensity > 5.0f)
        {
            sparkleIntensity = 5.0f; // Limit the maximum sparkle intensity
        }

        // Assuming some visual representation of sparkle intensity,
        // you can modify a material property or similar here.
    }

    // Method to make the diamond sparkle
    private void Sparkle()
    {
        // This method can be used to create a visual sparkle effect.
        // For example, adjusting the material's shininess or using a particle system.
    }

    // Public getter and setter for the sparkleIntensity
    public float SparkleIntensity
    {
        get { return sparkleIntensity; }
        set
        {
            if (value >= 0)
            {
                sparkleIntensity = value;
            }
            else
            {
                Debug.LogError("Sparkle intensity must be non-negative.");
            }
        }
    }
}

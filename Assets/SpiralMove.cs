using UnityEngine;

public class SpiralMovement : MonoBehaviour
{
    [Header("Параметри спіралі")]
    public float angularSpeed = 2f;
    public float radiusGrowth = 0.5f; 
    private float timePassed = 0f;

    void Update()
    {
        float oldX = (radiusGrowth * timePassed) * Mathf.Cos(angularSpeed * timePassed);
        float oldZ = (radiusGrowth * timePassed) * Mathf.Sin(angularSpeed * timePassed);

        timePassed += Time.deltaTime;

        float newX = (radiusGrowth * timePassed) * Mathf.Cos(angularSpeed * timePassed);
        float newZ = (radiusGrowth * timePassed) * Mathf.Sin(angularSpeed * timePassed);

        Vector3 deltaMovement = new Vector3(newX - oldX, 0, newZ - oldZ);

        transform.Translate(deltaMovement, Space.World);
    }
}
using UnityEngine;

public class generatorScript : MonoBehaviour
{
    
    public GameObject obstacle;

    public float MinSpeed;
    public float MaxSpeed;
    public float CurrentSpeed;
    public float SpeedMulti;

    void Awake()  {
        CurrentSpeed = MinSpeed;
        generateObstacle(); 

        
    }
    
    public void generateObstacle() {

        GameObject obstacleIns = Instantiate(obstacle, transform.position,transform.rotation);

        obstacleIns.GetComponent<ObstacleScript>().GeneratorScript = this;

        
            }
    // Update is called once per frame
    void Update()
    {
        if(CurrentSpeed < MaxSpeed) {
                CurrentSpeed += SpeedMulti;
        }
    }
}

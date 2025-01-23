using UnityEngine;

public class Charactor : MonoBehaviour
{
    
    public void TakeDamange(int Damange){
        Debug.Log($"{gameObject.name} is taking {Damange}");
    }
}

using System.Collections.Generic;
using UnityEngine;

public class MeleeAttack : MonoBehaviour
{
    public List<Charactor> enemies = new List<Charactor>();
    private PlayerInput _input;

    private void OnEnable(){
        _input = Inputmanger.Instance.Input;
        _input.Player.Attack.performed += _ => Attack();
    }
    private void OnDisable(){
        _input.Player.Attack.performed -= _ => Attack();
    }
    private void Attack(){
        foreach (Charactor charactor in enemies){
            charactor.TakeDamange(10);
        }
    }

    private void OnTriggerEnter(Collider other){
        if (other.TryGetComponent<Charactor>(out Charactor thatGuy)){
            enemies.Add(thatGuy);
        }
    }
    private void OnTriggerExit(Collider other){
        if (other.TryGetComponent<Charactor>(out Charactor thatGuy)){
            if (enemies.Contains(thatGuy)){
                enemies.Remove(thatGuy);
            }
        }
    }
}

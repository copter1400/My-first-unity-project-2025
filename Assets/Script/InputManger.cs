using UnityEngine;
[DefaultExecutionOrder(-1)]
public class Inputmanger : MonoBehaviour
{
    #region Simeple Singleton
    public static Inputmanger Instance;

    void Awake(){
        if (Instance != null){
            Destroy(gameObject);
        }else{
            Instance = this;
        }

        //------------------------
        Input = new PlayerInput();
    }
    #endregion

    private void OnEnable(){
        Input.Enable();
    }
    private void OnDisable(){
        Input.Disable();
    }

    public PlayerInput Input;
}

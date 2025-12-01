using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour{
	public static Vector2 Movement;
	
	private PlayerInput _playerInput;
	private InputAction _moveAction;
	
   
    void Start()
    {
    	_playerInput = GetComponent<PlayerInput>();
    	
    	_moveAction = _playerInput.actions["Move"];
        
    }

    // Update is called once per frame
    void Update()
    {
    	Movement = _moveAction.ReadValue<Vector2>();  
    }
}

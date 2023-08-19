
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer spriteRenderer;

    [SerializeField]
    private InputActionReference actionReference;

    [SerializeField]
    private InputAction test;

    private Color started = Color.yellow;
    private Color performed = Color.green;
    private Color canceled = Color.red;

    private void OnEnable()
    {
        actionReference.action.Enable();
    }
    private void OnDisable()
    {
        actionReference.action.Disable();
    }

    private void Start()
    {
        actionReference.action.started += context =>
        {
            spriteRenderer.color = started;

        };

        actionReference.action.performed += context => { spriteRenderer.color = performed; };
        actionReference.action.canceled += context => { spriteRenderer.color = canceled; };
    }


    //private void Awake()
    //{
    //    //Dynamically create an input action
    //    //InputAction action = new InputAction(binding: "<Gamepad>/LeftStick");
    //    // addtitional binding can be added using 'AddBinding'.
    //    //action.AddBinding("<Mouse>/LeftButton").WithInteractions("tap(duraiton = 0.8)");
    //    //action.Enable(); // en son bunu yapman þart

    //    //other way to dynamically make an input action

    //    //var action2 = new InputAction(name: "MyBinding", binding: "<Mouse/leftButton"); // burada kendi bindingimi yaptým
    //    //action2.Enable();
    //    //action2.performed += _ => { Debug.Log("Clicking"); }; // burada da performed olduðunda consola yazdýrdým.
    //}
    //private PlayerInput playerInput;

    //private InputAction JumpAction;

    //private void Awake()
    //{
    //    playerInput = GetComponent<PlayerInput>();
    //    JumpAction = playerInput.actions["Jump"];
    //    JumpAction.ReadValue<float>();
    //}




    //private PlayerControls playerControls;

    //private void Awake()
    //{
    //    playerControls = new PlayerControls();
    //}

    //private void OnEnable()
    //{
    //    playerControls.Enable();
    //}
    //private void OnDisable()
    //{
    //    playerControls.Disable();

    //    playerControls.Land.Explosion.started -= Explosion; // this tells the ýnput system that we are not listening anymore, so they do not need to send us any info.

    //}

    //private void Start()
    //{ // bu yöntemler subscribe to the events
    //    playerControls.Land.Explosion.started += Explosion;
    //    playerControls.Land.Explosion.performed += Explosion; // performed means An Interaction with the Action has been completed.
    //    playerControls.Land.Explosion.canceled += Explosion;


    //}
    //public void Explosion(InputAction.CallbackContext context)
    //{
    //    Debug.Log("Explosion");
    //    //context.ReadValue<float>(); // read value directly
    //    //context.ReadValueAsButton();

    //}

    //private void Update()
    //{
    //    Vector2 move = playerControls.Land.Move.ReadValue<Vector2>();

    //    Debug.Log(move);

    //    //playerControls.Land.Jump.ReadValue<float>(); // button olduðu için float yaptýk

    //    //if(playerControls.Land.Jump.ReadValue<float>() ==1)

    //    if (playerControls.Land.Jump.triggered)
    //        Debug.Log("Jump");
    //}
}

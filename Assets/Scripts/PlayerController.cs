using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour
{

	[SerializeField]
	private float speed = 5f;
	[SerializeField]
	private float lookSensitivity = 3f;
	private PlayerMotor motor;

	[SerializeField]
	private float thrusterForse = 1000f;

	void Start()
	{
		motor = GetComponent<PlayerMotor>();
	}

	void Update()
	{
		//Calculate movement velocity as a 3D vector
		float _xMov = Input.GetAxisRaw("Horizontal");
		float _zMov = Input.GetAxisRaw("Vertical");

		Vector3 _movHorizontal = transform.right * _xMov;
		Vector3 _movVertical = transform.forward * _zMov;

		// Final movement vector
		Vector3 _velocity = (_movHorizontal + _movVertical).normalized * speed;

		//Apply movement
		motor.Move(_velocity);

		//Calculate rotation as 3D vector (turning around)
		float _yRot = Input.GetAxisRaw("Mouse X");

		Vector3 _rotation = new Vector3(0f, _yRot, 0f) * lookSensitivity;

		//Apply rotation
		motor.Rotate(_rotation);

		//Calculate camera rotation as 3D vector (turning around)
		float _xRot = Input.GetAxisRaw("Mouse Y");

		float _cameraRotationX = _xRot * lookSensitivity;

		//Apply camera rotation
		motor.RotateCamera(_cameraRotationX);


		Vector3 _thrusterforce = Vector3.zero;
		if (Input.GetButton("Jump"))
		{
			_thrusterforce = Vector3.up * thrusterForse;
		}
		else if (Input.GetKey("z"))
		{
			_thrusterforce = Vector3.down * thrusterForse;
		}

		//Apply truster force
		motor.ApplyThruster(_thrusterforce);



	}
}

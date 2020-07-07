// mParticlePainter v1.0 - mgear - http://unitycoder.com/blog/

#pragma strict

public var particleObject:GameObject;
public var  maxParticles:int = 500;
public var hitLocalOffset:float = 0.0;

private var _ParticleSystem:ParticleSystem;
private var particles : ParticleSystem.Particle[];
private var counter:int;
private var radius:float=1;

function Start () 
{
	// create particle array
	particles = new ParticleSystem.Particle[maxParticles];
	
	// get particle system
	_ParticleSystem = particleObject.GetComponent(ParticleSystem);
	
	// emit some particles
	_ParticleSystem.Emit(maxParticles);
	_ParticleSystem.Simulate(0.1); // needs this to emit now
	
	// get those particles
	var count:int = _ParticleSystem.GetParticles(particles);

}

function Update () 
{
	// paint
	if (Input.GetMouseButton (0))
	{
		var ray = Camera.main.ScreenPointToRay (Input.mousePosition); 
		var hit : RaycastHit;
		if (Physics.Raycast (ray, hit, 100)) 
		{
			particles[counter].position = particleObject.transform.InverseTransformPoint (hit.point+(hit.normal*hitLocalOffset));
			particles[counter].rotation  = Random.Range(0,360);
			_ParticleSystem.SetParticles(particles, maxParticles);
			counter++;
			if (counter>=maxParticles) counter=0;
		}
	}
	
	// rotation
	if (Input.GetKey ("a"))
	{
		transform.parent.Rotate(Vector3(0,30,0) * Time.deltaTime);
	}
	if (Input.GetKey ("d"))
	{
		transform.parent.Rotate(Vector3(0,-30,0) * Time.deltaTime);
	}
	
	// zoom in/out by scaling the parent
	if (Input.GetAxis("Mouse ScrollWheel")!=0)
	{
		radius -=Input.GetAxis("Mouse ScrollWheel")*0.8;
		transform.parent.localScale=Vector3(radius,radius,radius);
	}
	
}
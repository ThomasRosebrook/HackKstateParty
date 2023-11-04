extends Area2D
@export var speed = 400 #speed player will move in pixels
var screen_size

# Called when the node enters the scene tree for the first time.
func _ready():
	pass # Replace with function body.


# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta):
	var speed = Vector2.ZERO
	if Input.is_action_pressed("move_right"):
		speed.x += 1
	if Input.is_action_pressed("move_left"):
		speed.x -= 1
	if Input.is_action_pressed("move_up"):
		speed.y += 1
	if Input.is_action_pressed("move_down"):
		speed.y -= 1
	if speed.length() > 0:
		speed = speed.normalized() * speed
		$AnimatedSprite2D.play()
	else:
		$AnimatedSprite2D.stop()
	position += speed * delta
	position = position.clamp(Vector2.ZERO, screen_size)
	

	pass

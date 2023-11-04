extends Area2D
@export var speed = 400 #speed player will move in pixels
var screen_size
signal hit
# Called when the node enters the scene tree for the first time.
func _ready():
	screen_size = get_viewport_rect().size
	hide()
	pass # Replace with function body.


# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta):
	var velocity = Vector2.ZERO
	if Input.is_action_pressed("move_right"):
		velocity.x += 1
	if Input.is_action_pressed("move_left"):
		velocity.x -= 1
	if Input.is_action_pressed("move_up"):
		velocity.y -= 1
	if Input.is_action_pressed("move_down"):
		velocity.y += 1
	if velocity.length() > 0:
		velocity = velocity.normalized() * speed
		$AnimatedSprite2D.play()
	else:
		$AnimatedSprite2D.stop()
	position += velocity * delta
	position = position.clamp(Vector2.ZERO, screen_size)
	if velocity.x > 0:
		$AnimatedSprite2D.animation = "left"
	elif velocity.x < 0:
		$AnimatedSprite2D.animation = "right"
	elif velocity.y < 0:
		$AnimatedSprite2D.animation = "down"	
	elif velocity.y > 0:
		$AnimatedSprite2D.animation = "up"
	else:
		$AnimatedSprite2D.animation = "still"
	pass

func start(pos):
	position = pos
	show()
	$CollisionShape2D.disabled = false

func _on_body_entered(body):
	pass # Replace with function body.


func _on_hit():
	hide() # Player disappears after being hit.
	hit.emit()
	# Must be deferred as we can't change physics properties on a physics callback.
	$CollisionShape2D.set_deferred("disabled", true)
	pass # Replace with function body.
extends Node
@export var mob_scene: PackedScene
var score = 0
signal start_game
# Called when the node enters the scene tree for the first time.
func _ready():
	pass # Replace with function body.

# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta):
	if Input.is_action_pressed("Escape"):
		get_tree().change_scene_to_file("res://Menu.tscn")
	pass


func game_over():
	$GameOverTimer.start()
	while true:
		if $Timer.is_stopped():
			break
	$UI.show_game_over()
	$ScoreTimer.stop()
	$MobTimer.stop()
	$UI/Start.show()
	$UI/Menu5.show()
	get_tree().change_scene_to_file("res://HackyGame2/game_1.tscn")
	pass # Replace with function body.
func new_game():
	get_tree().call_group("mobs", "queue_free")
	$UI.update_score(score)
	$UI.show_message("Get Ready")
	score = 0
	$Player.start($StartPosition.position)
	$StartTimer.start()

func _on_mob_timer_timeout():
	# Create a new instance of the Mob scene.
	var mob = mob_scene.instantiate()

	# Choose a random location on Path2D.
	var mob_spawn_location = get_node("MobPath/MobSpawnLocation")
	mob_spawn_location.progress_ratio = randf()

	# Set the mob's direction perpendicular to the path direction.
	var direction = mob_spawn_location.rotation + PI / 2

	# Set the mob's position to a random location.
	mob.position = mob_spawn_location.position

	# Add some randomness to the direction.
	direction += randf_range(-PI / 4, PI / 4)
	mob.rotation = direction

	# Choose the velocity for the mob.
	var velocity = Vector2(randf_range(200.0, 300.0), 0.0)
	mob.linear_velocity = velocity.rotated(direction)

	# Spawn the mob by adding it to the Main scene.
	add_child(mob)
	pass # Replace with function body.


func _on_score_timer_timeout():
	score += 1
	$UI.update_score(score)
	pass # Replace with function body.


func _on_start_timer_timeout():
	$MobTimer.start()
	$ScoreTimer.start()
	pass # Replace with function body.


func _on_start_pressed():
	$UI/Start.hide()
	$UI/Menu5.hide()
	$UI/JoeBiden.play()
	$UI/MenuForGame.stop()
	start_game.emit()
	pass # Replace with function body.


func _on_menu_pressed():
	get_tree().change_scene_to_file("res://Menu.tscn")
	pass # Replace with function body.


func _on_message_timer_timeout():
	$UI/Message.hide()
	pass # Replace with function body.

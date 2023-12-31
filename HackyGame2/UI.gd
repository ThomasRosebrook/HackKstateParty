extends CanvasLayer


# Called when the node enters the scene tree for the first time.
func _ready():
	pass # Replace with function body.

signal start_game
# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta):
	pass
func show_message(text):
	$Message.text = text
	$Message.show()
	$MessageTimer.start()
func show_game_over():
	show_message("Game Over")
	# Wait until the MessageTimer has counted down.
	await $MessageTimer.timeout
	$Message.text = "Avoid the\n X!"
	$Message.show()
	# Make a one-shot timer and wait for it to finish.
	await get_tree().create_timer(1.0).timeout
	$StartButton.show()
func update_score(score):
	$ScoreLabel.text = str(score)

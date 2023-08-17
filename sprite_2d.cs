using Godot;

public partial class sprite_2d : Sprite2D
{
	public override void _Ready()
	{
	}

	public override void _Process(double delta)
	{
		float AMOUNT = 5;
		if (Input.IsKeyPressed(Key.W))
		{
            this.Position += new Vector2(0, -AMOUNT);
		}

        if (Input.IsKeyPressed(Key.S))
        {
            this.Position += new Vector2(0, AMOUNT);

        }


        if (Input.IsKeyPressed(Key.A))
        {
            this.Position += new Vector2(-AMOUNT, 0);
    
        }


        if (Input.IsKeyPressed(Key.D))
        {
            this.Position += new Vector2(AMOUNT, 0);
    
        }
    }
}

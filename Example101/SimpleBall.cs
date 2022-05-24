using System.Numerics; // Vector2
using Raylib_cs; // Color

/*
In this class, we have the properties:

- Vector2  Position
- float    Rotation
- Vector2  Scale

- Vector2 TextureSize
- Vector2 Pivot
- Color Color

Methods:

- AddChild(Node child)
- RemoveChild(Node child, bool keepAlive = false)
*/

namespace Movement
{
	class SimpleBall : SpriteNode
	{
		// your private fields here

		// Ball movement speed X
		private float speedX = 600f;

		// Ball movement speed Y
		private float speedY = 400f; 



		// constructor + call base constructor
		public SimpleBall() : base("resources/bigball.png")
		{
			Position = new Vector2(Settings.ScreenSize.X / 2, Settings.ScreenSize.Y / 4);
			Color = Color.YELLOW;
		}

		// Update is called every frame
		public override void Update(float deltaTime)
		{
			Move(deltaTime);
			BounceEdges();
		}

		// your own private methods
		private void Move(float deltaTime)
		{
			// TODO implement
			Position.X += speedX * deltaTime;
			Position.Y += speedY * deltaTime;
		}

		private void BounceEdges()
		{
			float scr_width = Settings.ScreenSize.X;
			float scr_height = Settings.ScreenSize.Y;
			float spr_width = TextureSize.X;
			float spr_height = TextureSize.Y;

			// TODO implement...
			//Ball position X
			if (Position.X + spr_width / 2 > scr_width)
			{
				speedX = speedX * -1;
			}
			if (Position.X - spr_width / 2 < 0)
			{
				speedX = speedX * -1;
			}

			//Ball position Y
			if (Position.Y + spr_height / 2 > scr_height)
			{
				speedY = speedY * -1;
			}
			if (Position.Y - spr_height / 2 < 0)
			{
				speedY = speedY * -1;
			}
		}

	}
}

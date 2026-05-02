using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TetrisConsole
{
	abstract class AFigure
	{
		const int pCount = 4;
		public APoint[] Points = new APoint[pCount];

		public void Draw()
		{

			foreach (APoint p in Points)
			{

				p.Draw();
			}
		}

		public void Clear()
		{
			foreach (APoint p in Points)
			{
				p.Clear();
			}
		}

		public EMoveResult TryMove(EDirection dir)
		{
			//APoint[] newpoints = ClonePoints();
			Clear();
			
			Move(dir);
			EMoveResult movres = VerifyPosition();
			if (movres != EMoveResult.Success)
			{
				Move(Reverse(dir));
			}
			Draw();

			return movres;
		}

		private EDirection Reverse(EDirection dir)
		{
			switch (dir)
			{
				case EDirection.Left:
					return EDirection.Right;
				case EDirection.Right:
					return EDirection.Left;
				case EDirection.Up:
					return EDirection.Down;
				case EDirection.Down:
					return EDirection.Up;
				default:
					return EDirection.Down;
			}
		}

		private EMoveResult VerifyPosition()
		{
			foreach (APoint p in Points)
			{
				if (p.Y >= AsField.Height)
				{
					return EMoveResult.BorderBottom;
				}
				if (p.X < 0 || p.Y < 0 || p.X >= AsField.Width)
				{
					return EMoveResult.BorderSide;
				}
				if (AsField.CheckStrike(p))
				{
					return EMoveResult.Heap;
				}
			}

			return EMoveResult.Success;
		}

		public void Move(EDirection dir)
		{
			foreach (APoint p in Points)
			{
				p.Move(dir);
			}
		}

		public EMoveResult TryRotate()
		{
			Clear();
			//APoint[] newpoints = ClonePoints();
			Rotate();
			EMoveResult rotres = VerifyPosition();
			if (rotres != EMoveResult.Success)
			{
				Rotate();
			}
			Draw();
			return rotres;
		}


		public abstract void Rotate();


		public bool IsOnTop()
		{
			if (Points[0].Y == 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

	}
}

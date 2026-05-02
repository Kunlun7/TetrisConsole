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
			APoint[] newpoints = ClonePoints();
			Move(newpoints, dir);
			EMoveResult movres = VerifyPosition(newpoints);
			if (movres == EMoveResult.Success)
			{
				Clear();
				Points = newpoints;
				Draw();
			}

			return movres;
		}

		private EMoveResult VerifyPosition(APoint[] plist)
		{
			foreach (APoint p in plist)
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

		public void Move(APoint[] plist, EDirection dir)
		{
			foreach (APoint p in plist)
			{
				p.Move(dir);
			}
		}

		public EMoveResult TryRotate()
		{
			APoint[] newpoints = ClonePoints();
			Rotate(newpoints);
			EMoveResult rotres = VerifyPosition(newpoints);
			if (rotres == EMoveResult.Success)
			{
				Clear();
				Points = newpoints;
				Draw();
			}

			return rotres;
		}

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

		public abstract void Rotate(APoint[] plist);

		private APoint[] ClonePoints()
		{
			APoint[] np = new APoint[pCount];
			for (int i = 0; i < pCount; i++)
			{
				np[i] = new APoint(Points[i]);
			}

			return np;
		}


	}
}

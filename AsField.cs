using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisConsole
{
	static class AsField
	{
		private static int _winWidth = 40;
		private static int _winHeight = 30;

		public static int Width
		{ 
			get
			{
				return _winWidth;
			}

			set
			{
				_winWidth = value;
				Console.SetWindowSize(AsField._winWidth, AsField._winHeight);
				Console.SetBufferSize(AsField._winWidth, AsField._winHeight);
			}
		}

		public static int Height
		{
			get
			{
				return _winHeight;
			}

			set
			{
				_winHeight = value;
				Console.SetWindowSize(AsField._winWidth, AsField._winHeight);
				Console.SetBufferSize(AsField._winWidth, AsField._winHeight);
			}
		}

		private static bool[][] _heap;

		static AsField()
		{ 
			// все значени массива по умолчанию - false
			_heap = new bool [Height][];
			for (int i = 0; i < Height; i++)
			{
				_heap[i] = new bool[Width];
			}
		}

		public static void TryDeleteLines()
		{

			for (int j = 0; j < Height; j++)
			{
				int counter = 0;
				for (int i = 0; i < Width; i++)
				{
					if (_heap[j][i])
					{
						counter++;
					}
				}

				if (counter == Width)
				{
					DeleteLine(j);
					Redraw();
				}
			}
		}

		public static void DeleteLine(int line)
		{
			for (int j = line; j >= 0; j++)
			{
				for (int i = 0; i < Width; i++)
				{
					if (j != 0)
					{
						_heap[j][i] = _heap[j - 1][i];
					}
					else
					{
						_heap[j][i] = false;
					}
				}
			}
		}


		private static void Redraw()
		{
			for (int j = 0; j < Height; j++)
			{
				for (int i = 0; i < Width; i++)
				{
					if (_heap[j][i])
					{
						AsDrawer.DrawPoint(i, j);
					}
					else
					{
						AsDrawer.ClearPoint(i, j);
					}
				}
			}
		}


		public static void AddFigure(AFigure fig)
		{
			foreach (APoint p in fig.Points)
			{
				_heap[p.Y][p.X] = true;
			}
		}


		public static bool CheckStrike(APoint p)
		{
			return _heap[p.Y][p.X];
		}


	}
}

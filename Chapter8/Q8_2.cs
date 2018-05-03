using System;
using System.Collections.Generic;

namespace CrackingTheCode6th.Chapter8 {
    public class Q8_2 : Quiz {
        public override void Test () {
            int[, ] matrix = new int[5, 6];
            for (int y = 0; y < matrix.GetLength (0); y++) {
                for (int x = 0; x < matrix.GetLength (1); x++) {
                    matrix[y, x] = 0;
                }
            }
            matrix[1, 1] = 1;
            matrix[2, 4] = 1;
            matrix[3, 1] = 1;
            matrix[3, 2] = 1;
            matrix[3, 3] = 1;

            List<Point> path = new List<Point> ();
            Findway (new Point (0, 0), matrix, path);
            foreach(var point in path){
                System.Console.WriteLine("("+point.y+","+point.x+")");
            }
            /*
            0 0 0 0 0 0
            0 x 0 0 0 0
            0 0 0 0 x 0
            0 x x x 0 0
            0 0 0 0 0 0

            */
        }

        private bool Findway (Point point, int[, ] matrix, List<Point> path) {
            if (point.x == matrix.GetLength (1) - 1 && point.y == matrix.GetLength (0) - 1) {
                return true;
            } else if (matrix[point.y, point.x] == 1) {
                return false;
            } else {
                bool right=true;
                bool down=true;
                if (point.x < matrix.GetLength (1) - 1) {
                    right = Findway (new Point (point.y, point.x + 1), matrix, path);
                    if (right) {
                        path.Add (new Point (point.y, point.x + 1));
                    }
                }
                if (point.y < matrix.GetLength (0) - 1) {
                    down = Findway (new Point (point.y + 1, point.x), matrix, path);
                    if (down) {
                        path.Add (new Point (point.y+1, point.x));
                    }
                }
                return right || down;
            }
        }

        class Point {
            public int x { get; set; }
            public int y { get; set; }
            public Point (int y, int x) {
                this.x = x;
                this.y = y;
            }
        }
    }
}
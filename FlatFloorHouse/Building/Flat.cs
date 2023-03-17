using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatFloorHouse
{
    internal class Flat
    {
        private int NumberOfRooms;
        private int SquareOfFlat;
        public Flat()
        {
            NumberOfRooms = 2;
            SquareOfFlat = 50;
        }
        public Flat(int S)
        {
            NumberOfRooms = 2;
            SquareOfFlat = S;
        }
        public Flat(int N, int S)
        {
            NumberOfRooms = N;
            SquareOfFlat = S;
        }
        public int GetNumberOfRooms() { return NumberOfRooms; }
        public void SetNumberOfRooms(int n) { NumberOfRooms = n; }
        public int GetSquareOfFlat() { return SquareOfFlat; }
        public void SetSquareOfFlat(int s) { SquareOfFlat = s; }
    }
}

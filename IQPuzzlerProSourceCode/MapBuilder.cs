using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQPuzzleProVer2
{
    public class MapBuilder
    {

        List<PuzzlePiece> puzzleList;
        List<PuzzlePiece> inventoryPuzzlePieces;
        public List<PuzzlePiece> hintPuzzleList;

        int levelNumber;
        public Map levelMap;
        int score;
        List<Hint> hints;
        GraphicsPath gp;


        public MapBuilder(int levelNumber)
        {
            this.levelNumber = levelNumber;
            score = 0;
            gp = new GraphicsPath();


            if (levelNumber == 1)
            {

                hints = null;
                puzzleList = new List<PuzzlePiece>();
                hintPuzzleList = new List<PuzzlePiece>(); 

                inventoryPuzzlePieces = new List<PuzzlePiece>();
                PuzzlePiece piece11;
                piece11 = new PuzzlePiece(11, 11, false);
                

                PuzzlePiece piece7;
                piece7 = new PuzzlePiece(7, 7, false);
                

                PuzzlePiece piece3;
                piece3 = new PuzzlePiece(3, 3, false);
               

                PuzzlePiece piece9;
                piece9 = new PuzzlePiece(9, 9, false);
                

                PuzzlePiece piece4;
                piece4 = new PuzzlePiece(4, 4, false);
                

                PuzzlePiece piece1;
                piece1 = new PuzzlePiece(1, 1, false);
               

                PuzzlePiece piece8;
                piece8 = new PuzzlePiece(8, 8, false);
                

                PuzzlePiece piece2;
                piece2 = new PuzzlePiece(2, 2, false);
               

                PuzzlePiece piece12;
                piece12 = new PuzzlePiece(12, 12, false);
               

                foreach (PuzzlePiece item in puzzleList)
                {
                    item.setIsInInventory(false);
                }

                levelMap = new Map(hints, puzzleList);

                for (int i = 0; i < 11; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        levelMap.mapArray[j, i] = -1;
                    }
                }

                piece11.rotateRight();
                piece11.flip();
                piece11.setLocX(0);
                piece11.setLocY(0);
                puzzleList.Add(piece11);


                piece7.flip();
                piece7.rotateRight();
                piece7.rotateRight();
                piece7.setLocX(60);
                piece7.setLocY(-120);
                puzzleList.Add(piece7);

                piece8.rotateRight();
                piece8.setLocX(180);
                piece8.setLocY(0);
                puzzleList.Add(piece8);


                piece3.setLocX(360);
                piece3.setLocY(0);
                puzzleList.Add(piece3);

              
                piece4.rotateRight();
                piece4.setLocX(0);
                piece4.setLocY(60);
                puzzleList.Add(piece4);


                piece9.flip();
                piece9.setLocX(-60);
                piece9.setLocY(120);
                puzzleList.Add(piece9);

                piece2.rotateRight();
                piece2.flip();
                piece2.setLocX(240);
                piece2.setLocY(120);
                puzzleList.Add(piece2);

                piece1.rotateRight();
                piece1.flip();
                piece1.setLocX(180);
                piece1.setLocY(180);
                puzzleList.Add(piece1);

                piece12.flip();
                piece12.setLocX(300);
                piece12.setLocY(180);
                puzzleList.Add(piece12);
                levelMap.mapArray[0, 0] = 11;
                 levelMap.mapArray[0, 1] = 7;
                 levelMap.mapArray[0, 2] = 7;
                 levelMap.mapArray[0, 3] = 7;
                 levelMap.mapArray[0, 4] = 7;
                 levelMap.mapArray[0, 5] = 8;
                 levelMap.mapArray[0, 6] = 3;
                 levelMap.mapArray[0, 7] = 3;
                 levelMap.mapArray[0, 8] = 3;
                 levelMap.mapArray[1, 0] = 11;
                 levelMap.mapArray[1, 1] = 11;
                 levelMap.mapArray[1, 2] = 4;
                 levelMap.mapArray[1, 3] = 7;
                 levelMap.mapArray[1, 4] = 8;
                 levelMap.mapArray[1, 5] = 8;
                 levelMap.mapArray[1, 6] = 3;
                 levelMap.mapArray[2, 0] = 9;
                 levelMap.mapArray[2, 1] = 11;
                 levelMap.mapArray[2, 2] = 4;
                 levelMap.mapArray[2, 3] = 4;
                 levelMap.mapArray[2, 4] = 2;
                 levelMap.mapArray[2, 5] = 8;
                 levelMap.mapArray[2, 6] = 8;
                 levelMap.mapArray[3, 0] = 9;
                 levelMap.mapArray[3, 1] = 11;
                 levelMap.mapArray[3, 2] = 4;
                 levelMap.mapArray[3, 3] = 1;
                 levelMap.mapArray[3, 4] = 2;
                 levelMap.mapArray[3, 5] = 2;
                 levelMap.mapArray[3, 6] = 12;
                 levelMap.mapArray[3, 7] = 12;
                 levelMap.mapArray[4, 0] = 9;
                 levelMap.mapArray[4, 1] = 9;
                 levelMap.mapArray[4, 2] = 9;
                 levelMap.mapArray[4, 3] = 1;
                 levelMap.mapArray[4, 4] = 1;
                 levelMap.mapArray[4, 5] = 2;
                 levelMap.mapArray[4, 6] = 12;
                 levelMap.mapArray[4, 7] = 12;
                 levelMap.mapArray[4, 8] = 12;
                 
                PuzzlePiece piece5 = new PuzzlePiece(5,5,true);
                 inventoryPuzzlePieces.Add(piece5);
                 PuzzlePiece piece6 = new PuzzlePiece(6, 6, true);
                 inventoryPuzzlePieces.Add(piece6);
                 PuzzlePiece piece10 = new PuzzlePiece(10, 10, true);
                 inventoryPuzzlePieces.Add(piece10);
                



             }
            else if (levelNumber == 13)
            {
                inventoryPuzzlePieces = new List<PuzzlePiece>();
                bool[,] array = new bool[4, 4];
                /* for (int i = 0; i < 4; i++)
                 {
                     for (int j = 0; j < 4; j++)
                     {
                         array[i, j] = false;
                     }

                 }
                 for (int i = 0; i < 3; i++)
                 {
                     array[0, i] = true;
                     array[i, 2] = true;
                 }
                 */
                array[0, 0] = true;
                array[0, 1] = true;
                array[1, 1] = true;
                array[1, 2] = true;
                array[2, 2] = true;
                hints = new List<Hint>();
                hintPuzzleList = new List<PuzzlePiece>();

                Hint hint = new Hint(10, 1, array, 8 * 60, 2 * 60);
                hints.Add(hint);
                hint.oldX = 600;
                hint.oldY = 500;
                puzzleList = new List<PuzzlePiece>();
                /*  PuzzlePiece piece6;
                  piece6 = new PuzzlePiece(6, 6, false);
                  puzzleList.Add(piece6);*/

                PuzzlePiece piece2;
                piece2 = new PuzzlePiece(2, 2, false);
                piece2.flip();
                piece2.setLocX(0);
                piece2.setLocY(0);
                puzzleList.Add(piece2);

                PuzzlePiece piece4;
                piece4 = new PuzzlePiece(4, 4, false);
                piece4.rotate180();
                piece4.setLocX(180);
                piece4.setLocY(-120);
                puzzleList.Add(piece4);

                PuzzlePiece piece11;
                piece11 = new PuzzlePiece(11, 11, false);
                piece11.flip();
                piece11.setLocX(0);
                piece11.setLocY(120);
                puzzleList.Add(piece11);

                PuzzlePiece piece8;
                piece8 = new PuzzlePiece(8, 8, false);
                piece8.rotateLeft();
                piece8.setLocX(180);
                piece8.setLocY(0);
                puzzleList.Add(piece8);

                PuzzlePiece piece5;
                piece5 = new PuzzlePiece(5, 5, false);
                piece5.setLocX(0);
                piece5.setLocY(180);
                puzzleList.Add(piece5);



                PuzzlePiece piece1;
                piece1 = new PuzzlePiece(1, 1, false);
                piece1.rotateRight();
                piece1.setLocX(120);
                piece1.setLocY(180);
                puzzleList.Add(piece1);

                PuzzlePiece piece6;
                piece6 = new PuzzlePiece(6, 6, false);
                piece6.rotateLeft();
                piece6.setLocX(0);
                piece6.setLocY(-60);
                puzzleList.Add(piece6);

                PuzzlePiece piece12;
                piece12 = new PuzzlePiece(12, 12, false);
                piece12.rotate180();
                piece12.flip();
                piece12.setLocX(420);
                piece12.setLocY(-120);
                puzzleList.Add(piece12);


                foreach (PuzzlePiece item in puzzleList)
                {
                    item.setIsInInventory(false);
                }

                levelMap = new Map(hints, puzzleList);
                levelMap.mapArray[0, 0] = 6;
                levelMap.mapArray[0, 1] = 6;
                levelMap.mapArray[0, 2] = 2;
                levelMap.mapArray[0, 3] = 2;
                levelMap.mapArray[0, 4] = 4;
                levelMap.mapArray[0, 5] = 4;
                levelMap.mapArray[0, 6] = 4;
                levelMap.mapArray[0, 7] = 12;
                levelMap.mapArray[0, 8] = 12;
                levelMap.mapArray[0, 9] = 12;
                levelMap.mapArray[1, 0] = 6;
                levelMap.mapArray[1, 1] = 2;
                levelMap.mapArray[1, 2] = 2;
                levelMap.mapArray[1, 3] = 8;
                levelMap.mapArray[1, 4] = 8;
                levelMap.mapArray[1, 5] = 4;
                levelMap.mapArray[1, 8] = 12;
                levelMap.mapArray[1, 9] = 12;
                levelMap.mapArray[2, 0] = 6;
                levelMap.mapArray[2, 1] = 6;
                levelMap.mapArray[2, 2] = 11;
                levelMap.mapArray[2, 3] = 11;
                levelMap.mapArray[2, 4] = 8;
                levelMap.mapArray[2, 5] = 8;
                levelMap.mapArray[3, 0] = 11;
                levelMap.mapArray[3, 1] = 11;
                levelMap.mapArray[3, 2] = 11;
                levelMap.mapArray[3, 3] = 5;
                levelMap.mapArray[3, 4] = 8;
                levelMap.mapArray[3, 5] = 1;
                levelMap.mapArray[4, 0] = 5;
                levelMap.mapArray[4, 1] = 5;
                levelMap.mapArray[4, 2] = 5;
                levelMap.mapArray[4, 3] = 5;
                levelMap.mapArray[4, 4] = 1;
                levelMap.mapArray[4, 5] = 1;


                PuzzlePiece piece3 = new PuzzlePiece(3, 3, true);
                inventoryPuzzlePieces.Add(piece3);
                PuzzlePiece piece7 = new PuzzlePiece(7, 7, true);
                inventoryPuzzlePieces.Add(piece7);
                PuzzlePiece piece9 = new PuzzlePiece(9, 9, true);

                inventoryPuzzlePieces.Add(piece9);

                PuzzlePiece piece10 = new PuzzlePiece(10, 10, true);
                inventoryPuzzlePieces.Add(piece10);
                piece10.rotateRight();
                piece10.flip();

                hintPuzzleList.Add(piece10);
            }
            else if (levelNumber == 14)
            {
                hints = null;
                puzzleList = new List<PuzzlePiece>();
                hintPuzzleList = new List<PuzzlePiece>();

                inventoryPuzzlePieces = new List<PuzzlePiece>();
                PuzzlePiece piece12;
                piece12 = new PuzzlePiece(12, 12, false);


                PuzzlePiece piece6;
                piece6 = new PuzzlePiece(6, 6, false);


                PuzzlePiece piece10;
                piece10 = new PuzzlePiece(10, 10, false);


                PuzzlePiece piece9;
                piece9 = new PuzzlePiece(9, 9, false);


                PuzzlePiece piece4;
                piece4 = new PuzzlePiece(4, 4, false);


                PuzzlePiece piece1;
                piece1 = new PuzzlePiece(1, 1, false);


                PuzzlePiece piece8;
                piece8 = new PuzzlePiece(8, 8, false);


                PuzzlePiece piece2;
                piece2 = new PuzzlePiece(2, 2, false);



                foreach (PuzzlePiece item in puzzleList)
                {
                    item.setIsInInventory(false);
                }

                levelMap = new Map(hints, puzzleList);

                for (int i = 0; i < 11; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        levelMap.mapArray[j, i] = -1;
                    }
                }

                piece12.flip();
                piece12.rotateRight();
                piece12.setLocX(-120);
                piece12.setLocY(-60);
                puzzleList.Add(piece12);


                piece6.rotateRight();
                piece6.setLocX(60);
                piece6.setLocY(0);
                puzzleList.Add(piece6);

                piece8.rotateRight();
                piece8.setLocX(240);
                piece8.setLocY(120);
                puzzleList.Add(piece8);

                piece10.rotateRight();
                piece10.rotateRight();
                piece10.setLocX(0);
                piece10.setLocY(60);
                puzzleList.Add(piece10);


                piece4.rotateRight();
                piece4.setLocX(0);
                piece4.setLocY(0);
                puzzleList.Add(piece4);


                piece9.rotateLeft();
                piece9.rotateLeft();
                piece9.setLocX(240);
                piece9.setLocY(-60);
                puzzleList.Add(piece9);

                piece2.setLocX(180);
                piece2.setLocY(180);
                puzzleList.Add(piece2);

                piece1.rotateRight();
                piece1.rotateRight();
                piece1.setLocX(-120);
                piece1.setLocY(60);
                puzzleList.Add(piece1);

                levelMap.mapArray[0, 0] = 12;
                levelMap.mapArray[0, 1] = 12;
                levelMap.mapArray[0, 2] = 4;
                levelMap.mapArray[0, 3] = 6;
                levelMap.mapArray[0, 4] = 6;
                levelMap.mapArray[0, 5] = 9;
                levelMap.mapArray[0, 6] = 9;
                levelMap.mapArray[0, 7] = 9;
                levelMap.mapArray[1, 0] = 12;
                levelMap.mapArray[1, 1] = 12;
                levelMap.mapArray[1, 2] = 4;
                levelMap.mapArray[1, 3] = 4;
                levelMap.mapArray[1, 4] = 6;
                levelMap.mapArray[1, 5] = 9;
                levelMap.mapArray[2, 0] = 12;
                levelMap.mapArray[2, 1] = 10;
                levelMap.mapArray[2, 2] = 4;
                levelMap.mapArray[2, 3] = 6;
                levelMap.mapArray[2, 4] = 6;
                levelMap.mapArray[2, 5] = 9;
                levelMap.mapArray[2, 6] = 8;
                levelMap.mapArray[3, 0] = 1;
                levelMap.mapArray[3, 1] = 10;
                levelMap.mapArray[3, 2] = 10;
                levelMap.mapArray[3, 3] = 2;
                levelMap.mapArray[3, 4] = 2;
                levelMap.mapArray[3, 5] = 8;
                levelMap.mapArray[3, 6] = 8;
                levelMap.mapArray[4, 0] = 1;
                levelMap.mapArray[4, 1] = 1;
                levelMap.mapArray[4, 2] = 10;
                levelMap.mapArray[4, 3] = 10;
                levelMap.mapArray[4, 4] = 2;
                levelMap.mapArray[4, 5] = 2;
                levelMap.mapArray[4, 6] = 8;
                levelMap.mapArray[4, 7] = 8;
                PuzzlePiece piece5 = new PuzzlePiece(5, 5, true);
                inventoryPuzzlePieces.Add(piece5);
                PuzzlePiece piece3 = new PuzzlePiece(3, 3, true);
                inventoryPuzzlePieces.Add(piece3);
                PuzzlePiece piece7 = new PuzzlePiece(7, 7, true);
                inventoryPuzzlePieces.Add(piece7);
                PuzzlePiece piece11 = new PuzzlePiece(11, 11, true);
                inventoryPuzzlePieces.Add(piece11);


            }


            else if (levelNumber == 15)
            {
                hints = null;
                puzzleList = new List<PuzzlePiece>();
                hintPuzzleList = new List<PuzzlePiece>();

                inventoryPuzzlePieces = new List<PuzzlePiece>();
                PuzzlePiece piece11;
                piece11 = new PuzzlePiece(11, 11, false);


                PuzzlePiece piece6;
                piece6 = new PuzzlePiece(6, 6, false);


                PuzzlePiece piece7;
                piece7 = new PuzzlePiece(7, 7, false);


                PuzzlePiece piece9;
                piece9 = new PuzzlePiece(9, 9, false);


                PuzzlePiece piece4;
                piece4 = new PuzzlePiece(4, 4, false);


                PuzzlePiece piece1;
                piece1 = new PuzzlePiece(1, 1, false);


                PuzzlePiece piece8;
                piece8 = new PuzzlePiece(8, 8, false);


                PuzzlePiece piece5;
                piece5 = new PuzzlePiece(5, 5, false);



                foreach (PuzzlePiece item in puzzleList)
                {
                    item.setIsInInventory(false);
                }

                levelMap = new Map(hints, puzzleList);

                for (int i = 0; i < 11; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        levelMap.mapArray[j, i] = -1;
                    }
                }

                piece7.rotateRight();
                piece7.setLocX(120);
                piece7.setLocY(0);
                puzzleList.Add(piece7);


                piece6.rotateRight();
                piece6.setLocX(0);
                piece6.setLocY(0);
                puzzleList.Add(piece6);

                piece8.rotateLeft();
                piece8.setLocX(0);
                piece8.setLocY(-60);
                puzzleList.Add(piece8);

                piece11.rotateLeft();
                piece11.flip();
                piece11.setLocX(240);
                piece11.setLocY(60);
                puzzleList.Add(piece11);


                piece4.setLocX(240);
                piece4.setLocY(180);
                puzzleList.Add(piece4);


                piece9.rotateRight();
                piece9.setLocX(-60);
                piece9.setLocY(60);
                puzzleList.Add(piece9);

                piece5.setLocX(0);
                piece5.setLocY(180);
                puzzleList.Add(piece5);

                piece1.rotateLeft();
                piece1.setLocX(300);
                piece1.setLocY(-120);
                puzzleList.Add(piece1);

                levelMap.mapArray[0, 0] = 8;
                levelMap.mapArray[0, 1] = 8;
                levelMap.mapArray[0, 2] = 6;
                levelMap.mapArray[0, 3] = 6;
                levelMap.mapArray[0, 4] = 7;
                levelMap.mapArray[0, 5] = 1;
                levelMap.mapArray[0, 6] = 1;
                levelMap.mapArray[1, 0] = 9;
                levelMap.mapArray[1, 1] = 8;
                levelMap.mapArray[1, 2] = 8;
                levelMap.mapArray[1, 3] = 6;
                levelMap.mapArray[1, 4] = 7;
                levelMap.mapArray[1, 5] = 1;
                levelMap.mapArray[1, 6] = 11;
                levelMap.mapArray[2, 0] = 9;
                levelMap.mapArray[2, 1] = 8;
                levelMap.mapArray[2, 2] = 6;
                levelMap.mapArray[2, 3] = 6;
                levelMap.mapArray[2, 4] = 7;
                levelMap.mapArray[2, 5] = 7;
                levelMap.mapArray[2, 6] = 11;
                levelMap.mapArray[3, 0] = 9;
                levelMap.mapArray[3, 1] = 9;
                levelMap.mapArray[3, 2] = 9;
                levelMap.mapArray[3, 3] = 5;
                levelMap.mapArray[3, 4] = 7;
                levelMap.mapArray[3, 5] = 4;
                levelMap.mapArray[3, 6] = 11;
                levelMap.mapArray[3, 7] = 11;
                levelMap.mapArray[4, 0] = 5;
                levelMap.mapArray[4, 1] = 5;
                levelMap.mapArray[4, 2] = 5;
                levelMap.mapArray[4, 3] = 5;
                levelMap.mapArray[4, 4] = 4;
                levelMap.mapArray[4, 5] = 4;
                levelMap.mapArray[4, 6] = 4;
                levelMap.mapArray[4, 7] = 11;
                PuzzlePiece piece2 = new PuzzlePiece(2, 2, true);
                inventoryPuzzlePieces.Add(piece2);
                PuzzlePiece piece3 = new PuzzlePiece(3, 3, true);
                inventoryPuzzlePieces.Add(piece3);
                PuzzlePiece piece12 = new PuzzlePiece(12, 12, true);
                inventoryPuzzlePieces.Add(piece12);
                PuzzlePiece piece10 = new PuzzlePiece(10, 10, true);
                inventoryPuzzlePieces.Add(piece10);


            }
            else if (levelNumber == 2) //LEVEL2
            {
                hints = null;
                puzzleList = new List<PuzzlePiece>();
                hintPuzzleList = new List<PuzzlePiece>();

                inventoryPuzzlePieces = new List<PuzzlePiece>();

                PuzzlePiece piece11;
                piece11 = new PuzzlePiece(11, 11, false);


                PuzzlePiece piece7;
                piece7 = new PuzzlePiece(7, 7, false);


                PuzzlePiece piece3;
                piece3 = new PuzzlePiece(3, 3, false);


                PuzzlePiece piece5;
                piece5 = new PuzzlePiece(5, 5, false);


                PuzzlePiece piece12;
                piece12 = new PuzzlePiece(12, 12, false);


                PuzzlePiece piece1;
                piece1 = new PuzzlePiece(1, 1, false);


                PuzzlePiece piece6;
                piece6 = new PuzzlePiece(6, 6, false);


                PuzzlePiece piece2;
                piece2 = new PuzzlePiece(2, 2, false);


                PuzzlePiece piece10;
                piece10 = new PuzzlePiece(10, 10, false);

                levelMap = new Map(hints, puzzleList);

                foreach (PuzzlePiece item in puzzleList)
                {
                    item.setIsInInventory(false);
                }

                for (int i = 0; i < 11; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        levelMap.mapArray[j, i] = -1;
                    }
                }



                piece3.rotateRight();
                piece3.flip();
                piece3.setLocX(0);
                piece3.setLocY(0);
                puzzleList.Add(piece3);

                piece12.flip();
                piece12.setLocX(-60);
                piece12.setLocY(180);
                puzzleList.Add(piece12);

                piece2.rotateRight();
                piece2.setLocX(-60);
                piece2.setLocY(0);
                puzzleList.Add(piece2);

                piece10.rotate180();
                piece10.setLocX(60);
                piece10.setLocY(60);
                puzzleList.Add(piece10);

                piece11.rotateLeft();
                piece11.flip();
                piece11.setLocX(60);
                piece11.setLocY(0);
                puzzleList.Add(piece11);

                piece7.rotate180();
                piece7.flip();
                piece7.setLocY(-120);
                piece7.setLocX(240);
                puzzleList.Add(piece7);

                piece5.rotateLeft();
                piece5.setLocX(240);
                piece5.setLocY(60);
                puzzleList.Add(piece5);

                piece1.rotate180();
                piece1.setLocX(240);
                piece1.setLocY(60);
                puzzleList.Add(piece1);

                piece6.setLocX(480);
                piece6.setLocY(0);
                puzzleList.Add(piece6);


                levelMap.mapArray[0, 0] = 3;
                levelMap.mapArray[0, 1] = 3;
                levelMap.mapArray[0, 2] = 2;
                levelMap.mapArray[0, 3] = 11;
                levelMap.mapArray[0, 4] = 7;
                levelMap.mapArray[0, 5] = 7;
                levelMap.mapArray[0, 6] = 7;
                levelMap.mapArray[0, 7] = 7;
                levelMap.mapArray[0, 8] = 6;
                levelMap.mapArray[0, 9] = 6;
                levelMap.mapArray[0, 10] = 6;
                levelMap.mapArray[1, 0] = 3;
                levelMap.mapArray[1, 1] = 2;
                levelMap.mapArray[1, 2] = 2;
                levelMap.mapArray[1, 3] = 11;
                levelMap.mapArray[1, 4] = 5;
                levelMap.mapArray[1, 5] = 5;
                levelMap.mapArray[1, 6] = 7;
                levelMap.mapArray[1, 8] = 6;
                levelMap.mapArray[1, 10] = 6;
                levelMap.mapArray[2, 0] = 3;
                levelMap.mapArray[2, 1] = 2;
                levelMap.mapArray[2, 2] = 10;
                levelMap.mapArray[2, 3] = 11;
                levelMap.mapArray[2, 4] = 11;
                levelMap.mapArray[2, 5] = 5;
                levelMap.mapArray[3, 0] = 12;
                levelMap.mapArray[3, 1] = 12;
                levelMap.mapArray[3, 2] = 10;
                levelMap.mapArray[3, 3] = 10;
                levelMap.mapArray[3, 4] = 11;
                levelMap.mapArray[3, 5] = 5;
                levelMap.mapArray[3, 6] = 1;
                levelMap.mapArray[4, 0] = 12;
                levelMap.mapArray[4, 1] = 12;
                levelMap.mapArray[4, 2] = 12;
                levelMap.mapArray[4, 3] = 10;
                levelMap.mapArray[4, 4] = 10;
                levelMap.mapArray[4, 5] = 5;
                levelMap.mapArray[4, 6] = 1;
                levelMap.mapArray[4, 7] = 1;

                PuzzlePiece piece4 = new PuzzlePiece(4, 4, true);
                inventoryPuzzlePieces.Add(piece4);
                PuzzlePiece piece8 = new PuzzlePiece(8, 8, true);
                inventoryPuzzlePieces.Add(piece8);
                PuzzlePiece piece9 = new PuzzlePiece(9, 9, true);
                inventoryPuzzlePieces.Add(piece9);

            }

            else if (levelNumber == 3) //LEVEL3
            {

                hints = null;
                puzzleList = new List<PuzzlePiece>();
                hintPuzzleList = new List<PuzzlePiece>();

                inventoryPuzzlePieces = new List<PuzzlePiece>();

                PuzzlePiece piece11;
                piece11 = new PuzzlePiece(11, 11, false);


                PuzzlePiece piece7;
                piece7 = new PuzzlePiece(7, 7, false);


                PuzzlePiece piece3;
                piece3 = new PuzzlePiece(3, 3, false);


                PuzzlePiece piece5;
                piece5 = new PuzzlePiece(5, 5, false);


                PuzzlePiece piece8;
                piece8 = new PuzzlePiece(8, 8, false);


                PuzzlePiece piece1;
                piece1 = new PuzzlePiece(1, 1, false);


                PuzzlePiece piece6;
                piece6 = new PuzzlePiece(6, 6, false);


                PuzzlePiece piece4;
                piece4 = new PuzzlePiece(4, 4, false);


                PuzzlePiece piece10;
                piece10 = new PuzzlePiece(10, 10, false);

                levelMap = new Map(hints, puzzleList);

                foreach (PuzzlePiece item in puzzleList)
                {
                    item.setIsInInventory(false);
                }

                for (int i = 0; i < 11; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        levelMap.mapArray[j, i] = -1;
                    }
                }

                piece1.rotate180();
                piece1.setLocX(-120);
                piece1.setLocY(-120);
                puzzleList.Add(piece1);

                piece7.rotate180();
                piece7.setLocX(60);
                piece7.setLocY(-120);
                puzzleList.Add(piece7);

                piece6.rotateLeft();
                piece6.setLocX(0);
                piece6.setLocY(60);
                puzzleList.Add(piece6);

                piece10.rotateRight();
                piece10.setLocX(0);
                piece10.setLocY(60);
                puzzleList.Add(piece10);

                piece5.setLocX(120);
                piece5.setLocY(180);
                puzzleList.Add(piece5);

                piece8.flip();
                piece8.rotateLeft();
                piece8.setLocX(180);
                piece8.setLocY(60);
                puzzleList.Add(piece8);

                piece11.rotateRight();
                piece11.flip();
                piece11.setLocX(300);
                piece11.setLocY(0);
                puzzleList.Add(piece11);

                piece4.rotate180();
                piece4.setLocX(300);
                piece4.setLocY(-120);
                puzzleList.Add(piece4);

                piece3.rotateLeft();
                piece3.flip();
                piece3.setLocX(240);
                piece3.setLocY(60);
                puzzleList.Add(piece3);



                levelMap.mapArray[0, 0] = 1;
                levelMap.mapArray[0, 1] = 7;
                levelMap.mapArray[0, 2] = 7;
                levelMap.mapArray[0, 3] = 7;
                levelMap.mapArray[0, 4] = 7;
                levelMap.mapArray[0, 5] = 11;
                levelMap.mapArray[0, 6] = 4;
                levelMap.mapArray[0, 7] = 4;
                levelMap.mapArray[0, 8] = 4;

                levelMap.mapArray[1, 0] = 1;
                levelMap.mapArray[1, 1] = 1;
                levelMap.mapArray[1, 2] = 7;
                levelMap.mapArray[1, 3] = 10;
                levelMap.mapArray[1, 4] = 8;
                levelMap.mapArray[1, 5] = 11;
                levelMap.mapArray[1, 6] = 11;
                levelMap.mapArray[1, 7] = 4;

                levelMap.mapArray[2, 0] = 6;
                levelMap.mapArray[2, 1] = 6;
                levelMap.mapArray[2, 2] = 10;
                levelMap.mapArray[2, 3] = 10;
                levelMap.mapArray[2, 4] = 8;
                levelMap.mapArray[2, 5] = 8;
                levelMap.mapArray[2, 6] = 11;
                levelMap.mapArray[2, 7] = 3;

                levelMap.mapArray[3, 0] = 6;
                levelMap.mapArray[3, 1] = 10;
                levelMap.mapArray[3, 2] = 10;
                levelMap.mapArray[3, 3] = 8;
                levelMap.mapArray[3, 4] = 8;
                levelMap.mapArray[3, 5] = 5;
                levelMap.mapArray[3, 6] = 11;
                levelMap.mapArray[3, 7] = 3;

                levelMap.mapArray[4, 0] = 6;
                levelMap.mapArray[4, 1] = 6;
                levelMap.mapArray[4, 2] = 5;
                levelMap.mapArray[4, 3] = 5;
                levelMap.mapArray[4, 4] = 5;
                levelMap.mapArray[4, 5] = 5;
                levelMap.mapArray[4, 6] = 3;
                levelMap.mapArray[4, 7] = 3;


                PuzzlePiece piece2 = new PuzzlePiece(2, 2, true);
                inventoryPuzzlePieces.Add(piece2);
                PuzzlePiece piece12 = new PuzzlePiece(12, 12, true);
                inventoryPuzzlePieces.Add(piece12);
                PuzzlePiece piece9 = new PuzzlePiece(9, 9, true);
                inventoryPuzzlePieces.Add(piece9);
            }


        
            if (levelNumber == 25)
             {
                 inventoryPuzzlePieces = new List<PuzzlePiece>();
                 hints = new List<Hint>();
                 bool[,] array = new bool[4, 4];
                hintPuzzleList = new List<PuzzlePiece>();
                array[0, 3] = true;

                 for (int i = 0; i < 4; i++)
                 {
                     array[1, i] = true;
                 }

                 Hint hint = new Hint(5, 1, array, 0, 3*60);
                 hints.Add(hint);
                hint.oldX = 900;
                hint.oldY = 400;

                bool[,] array2 = new bool[4, 4];
                for (int i = 0; i < 3; i++)
                {
                    array2[i, 2] = true;
                }

                for (int i = 0; i < 3; i++)
                 {
                     array2[2, i] = true;
                 }

                 Hint hint2 = new Hint(9, 2, array2, 4*60, 2*60);
                 hints.Add(hint2);
                hint2.oldX = 300;
                hint2.oldY = 500;

                puzzleList = new List<PuzzlePiece>();
                 PuzzlePiece piece11;
                 piece11 = new PuzzlePiece(11, 11, false);
                 piece11.flip();
                 piece11.rotateRight();
                piece11.setLocX(-120);
                piece11.setLocY(0);
                puzzleList.Add(piece11);

                 PuzzlePiece piece1;
                 piece1 = new PuzzlePiece(1, 1, false);
                piece1.flip();
                piece1.setLocX(-60);
                piece1.setLocY(0);
                puzzleList.Add(piece1);

                 PuzzlePiece piece10;
                 piece10 = new PuzzlePiece(10, 10, false);
                piece10.setLocX(180);
                piece10.setLocY(0);
                puzzleList.Add(piece10);

                 PuzzlePiece piece7;
                 piece7 = new PuzzlePiece(7, 7, false);
                piece7.rotate180();
                piece7.setLocX(300);
                piece7.setLocY(-120);
                puzzleList.Add(piece7);

                 PuzzlePiece piece12;
                 piece12 = new PuzzlePiece(12, 12, false);
                piece12.setLocX(480);
                piece12.setLocY(0);
                puzzleList.Add(piece12);

                 foreach (PuzzlePiece item in puzzleList)
                 {
                     item.setIsInInventory(false);
                 }

                 levelMap = new Map(hints, puzzleList);
                 levelMap.mapArray[0, 0] = 11;
                 levelMap.mapArray[0, 1] = 1;
                 levelMap.mapArray[0, 2] = 1;
                 levelMap.mapArray[0, 3] = 10;
                 levelMap.mapArray[0, 4] = 10;
                 levelMap.mapArray[0, 5] = 7;
                 levelMap.mapArray[0, 6] = 7;
                 levelMap.mapArray[0, 7] = 7;
                 levelMap.mapArray[0, 8] = 7;
                 levelMap.mapArray[0, 9] = 12;
                 levelMap.mapArray[0, 10] = 12;
                 levelMap.mapArray[1, 0] = 11;
                 levelMap.mapArray[1, 1] = 1;
                 levelMap.mapArray[1, 4] = 10;
                 levelMap.mapArray[1, 5] = 10;
                 levelMap.mapArray[1, 6] = 7;
                 levelMap.mapArray[1, 8] = 12;
                 levelMap.mapArray[1, 9] = 12;
                 levelMap.mapArray[1, 10] = 12;
                 levelMap.mapArray[2, 0] = 11;
                 levelMap.mapArray[2, 1] = 11;
                 levelMap.mapArray[2, 5] = 10;
                 levelMap.mapArray[3, 1] = 11;

                 PuzzlePiece piece3 = new PuzzlePiece(3, 3, true);
                 inventoryPuzzlePieces.Add(piece3);
                 PuzzlePiece piece2 = new PuzzlePiece(2, 2, true);
                 inventoryPuzzlePieces.Add(piece2);
                 PuzzlePiece piece4 = new PuzzlePiece(4, 4, true);
                 inventoryPuzzlePieces.Add(piece4);
                 PuzzlePiece piece5 = new PuzzlePiece(5, 5, true);
                 inventoryPuzzlePieces.Add(piece5);
                 PuzzlePiece piece6 = new PuzzlePiece(6, 6, true);
                 inventoryPuzzlePieces.Add(piece6);
  
                piece5.flip();
                hintPuzzleList.Add(piece5);
            
 
               
               
                PuzzlePiece piece9 = new PuzzlePiece(9, 9, true);
                 inventoryPuzzlePieces.Add(piece9);
                hintPuzzleList.Add(piece9);
                PuzzlePiece piece8 = new PuzzlePiece(8, 8, true);
                 inventoryPuzzlePieces.Add(piece8);


             }


         }

         /*public MapBuilder(bool isCustom)
         {
             puzzleList = new List<PuzzlePiece>();
             PuzzlePiece piece11;
             piece11 = new PuzzlePiece(11, 11, true);
             puzzleList.Add(piece11);

             PuzzlePiece piece1;
             piece1 = new PuzzlePiece(1, 1, true);
             puzzleList.Add(piece1);

             PuzzlePiece piece10;
             piece10 = new PuzzlePiece(10, 10, true);
             puzzleList.Add(piece10);

             PuzzlePiece piece7;
             piece7 = new PuzzlePiece(7, 7, true);
             puzzleList.Add(piece7);

             PuzzlePiece piece12;
             piece12 = new PuzzlePiece(12, 12, true);
             puzzleList.Add(piece12);

             PuzzlePiece piece5;
             piece5 = new PuzzlePiece(5, 5, true);
             puzzleList.Add(piece5);

             PuzzlePiece piece3;
             piece3 = new PuzzlePiece(3, 3, true);
             puzzleList.Add(piece3);

             PuzzlePiece piece9;
             piece9 = new PuzzlePiece(9, 9, true);
             puzzleList.Add(piece9);

             PuzzlePiece piece4;
             piece4 = new PuzzlePiece(4, 4, true);
             puzzleList.Add(piece4);


             PuzzlePiece piece8;
             piece8 = new PuzzlePiece(8, 8, true);
             puzzleList.Add(piece8);

             PuzzlePiece piece2;
             piece2 = new PuzzlePiece(2, 2, true);
             puzzleList.Add(piece2);
             levelMap = new Map(puzzleList);

             levelMap.mapArray[0, 0] = 4;
             levelMap.mapArray[0, 1] = 4;
             levelMap.mapArray[0, 2] = 4;
             levelMap.mapArray[0, 3] = 10;
             levelMap.mapArray[0, 4] = 7;
             levelMap.mapArray[0, 5] = 6;
             levelMap.mapArray[0, 6] = 6;
             levelMap.mapArray[0, 7] = 8;
             levelMap.mapArray[0, 8] = 8;
             levelMap.mapArray[0, 9] = 11;
             levelMap.mapArray[0, 10] = 3;
             levelMap.mapArray[1, 0] = 9;
             levelMap.mapArray[1, 1] = 4;
             levelMap.mapArray[1, 2] = 10;
             levelMap.mapArray[1, 3] = 10;
             levelMap.mapArray[1, 4] = 7;
             levelMap.mapArray[1, 5] = 6;
             levelMap.mapArray[1, 6] = 8;
             levelMap.mapArray[1, 7] = 8;
             levelMap.mapArray[1, 8] = 11;
             levelMap.mapArray[1, 9] = 11;
             levelMap.mapArray[1, 10] = 3;
             levelMap.mapArray[2, 0] = 9;
             levelMap.mapArray[2, 1] = 10;
             levelMap.mapArray[2, 2] = 10;
             levelMap.mapArray[2, 3] = 7;
             levelMap.mapArray[2, 4] = 7; 
             levelMap.mapArray[2, 5] = 6;
             levelMap.mapArray[2, 6] = 6;
             levelMap.mapArray[2, 7] = 8;
             levelMap.mapArray[2, 8] = 11;
             levelMap.mapArray[2, 9] = 3;
             levelMap.mapArray[2, 10] = 3;
             levelMap.mapArray[3, 0] = 9;
             levelMap.mapArray[3, 1] = 9;
             levelMap.mapArray[3, 2] = 9;
             levelMap.mapArray[3, 3] = 5;
             levelMap.mapArray[3, 4] = 7;
             levelMap.mapArray[3, 5] = 2;
             levelMap.mapArray[3, 6] = 2;
             levelMap.mapArray[3, 7] = 1;
             levelMap.mapArray[3, 8] = 11;
             levelMap.mapArray[3, 9] = 12;
             levelMap.mapArray[3, 10] = 12;
             levelMap.mapArray[4, 0] = 5;
             levelMap.mapArray[4, 1] = 5;
             levelMap.mapArray[4, 2] = 5;
             levelMap.mapArray[4, 3] = 5;
             levelMap.mapArray[4, 4] = 2;
             levelMap.mapArray[4, 5] = 2;
             levelMap.mapArray[4, 6] = 1;
             levelMap.mapArray[4, 7] = 1;
             levelMap.mapArray[4, 8] = 12;
             levelMap.mapArray[4, 9] = 12;
             levelMap.mapArray[4, 10] = 12;


         }*/

        public int[,] getMapArray()
        {
            int[,] mapArray = new int[5, 11];
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    mapArray[j, i] = levelMap.mapArray[j, i];
                }
            }
            return mapArray;
        }



        public Map getMap()
        {
            return levelMap;
        }
        public List<Hint> getHint()
        {
            return hints;
        }
        public Hint getIndexedHint(int index)
        {
            if (hints.Count == 0)
                return null;
            else
                return hints[index];
        }

        public int numberOfPuzzlePiece()
        {
            int i = 0;
            foreach(PuzzlePiece item in inventoryPuzzlePieces)
            {
                i++;
            }
            return i;
        }
        public List<PuzzlePiece> getInventoryPuzzlePieces()
        {
            return inventoryPuzzlePieces;
        }
        public List<PuzzlePiece> getMapPuzzlePieces()
        {
            return puzzleList;
        }
       
      /*  public void drawing(GraphicsPath gp, PuzzlePiece piece)
        {
            Sprite2 sprite = new Sprite2(piece.getLocX(), piece.getLocY(),60,piece);
            sprite.drawing(gp);

          
        }

        public void draw(Graphics g, PuzzlePiece piece)
        {
           /* Rectangle circle = new Rectangle(piece.getLocX(), piece.getLocY(), 60, 60);
            circle.X = piece.getLocX();
            circle.Y = piece.getLocY();
            gp = new GraphicsPath();
            this.drawing(gp, piece);
            g.DrawPath(piece.getColor(), gp);

            g.FillPath(piece.getBrush(), gp);

        }*/
    }
}

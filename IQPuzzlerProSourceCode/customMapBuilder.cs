using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQPuzzleProVer2
{
    public class customMapBuilder
    {
        List<PuzzlePiece> puzzleList;
        public List<PuzzlePiece> inventoryPuzzlePieces;
        public Map customMap;
        int levelNumber;
        public Map levelMap;
        int score;
        List<Hint> hints;
        GraphicsPath gp;
        int userID;
        int mapID;
        public List<PuzzlePiece> mapPieces;
       
        
    

        public customMapBuilder(int userID, int mapID)
        {
            this.userID = userID;
            this.mapID = mapID;
            mapPieces = new List<PuzzlePiece>();
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


            PuzzlePiece piece5 = new PuzzlePiece(5, 5, false);
           
            PuzzlePiece piece6 = new PuzzlePiece(6, 6, false);

            PuzzlePiece piece10 = new PuzzlePiece(10, 10, false);
          
            puzzleList = new List<PuzzlePiece>();
            piece11.rotateRight();
            piece11.flip();
            piece11.setLocX(0);
            piece11.setLocY(0);
            puzzleList.Add(piece11);

            piece5.rotateLeft();
            piece5.setLocX(540);
            piece5.setLocY(0);
            puzzleList.Add(piece5);

            
            piece6.setLocX(420);
            piece6.setLocY(60);
            puzzleList.Add(piece6);

            piece10.rotateRight();
            piece10.flip();
            piece10.setLocX(480);
            piece10.setLocY(120);
            puzzleList.Add(piece10);

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


        }

        public void createCustomMap(List<PuzzlePiece> mapArr, List<PuzzlePiece> invArr)
        {
            int count = 0;
            int count2 = 0;
            for(int i = 0; i < mapArr.Count; i++)
            {
                if(mapArr[i] != null)
                {
                    mapPieces[count] = mapArr[i];
                    count++;
                }
            }
            for (int i = 0; i < invArr.Count; i++)
            {
                if (invArr[i] != null)
                {
                    inventoryPuzzlePieces[count2] = invArr[i];
                    count2++;
                }
            }
            
            customMap = new Map(mapPieces);
            string path = @"C:\Users\Lenovo\Desktop\IQPuzzlerProVer5\IQPuzzleProVer4.txt";
            if (!File.Exists(path))
            {
                File.Create(path);
                TextWriter tw = new StreamWriter(path);
                foreach (PuzzlePiece item in mapPieces)
                {
                    tw.Write(item);

                }
                tw.WriteLine();
                foreach (PuzzlePiece item in inventoryPuzzlePieces)
                {
                    tw.Write(item);
                }
                tw.Close();
            }
            else if (File.Exists(path))
            {
                using (var tw = new StreamWriter(path, true))
                {
                    foreach (PuzzlePiece item in mapPieces)
                    {
                        tw.Write(item);

                    }
                    tw.WriteLine();
                    foreach (PuzzlePiece item in inventoryPuzzlePieces)
                    {
                        tw.Write(item);
                    }
                }
            }

        }

        public Map getCustomMap()
        {
           /* String line;
            CustomMap customMap = new CustomMap();
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(@"C: \Users\Lenovo\Desktop\IQPuzzlerProVer5\IQPuzzleProVer4.txt");

                //Read the first line of text
                customMap.customArr = sr.ReadLine();

                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the lie to console window
                    Console.WriteLine(line);
                    //Read the next line
                    line = sr.ReadLine();
                }

                //close the file
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
            */

            return customMap;
        }

        public List<PuzzlePiece> getInitialPieces()
        {
            return puzzleList;
        }
    }
}

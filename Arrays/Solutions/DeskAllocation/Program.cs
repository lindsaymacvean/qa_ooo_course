using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeskAllocation {
  class Program {
    public static string[,] deskNames;
    
    public static string[] names = 
     {"Amy","Ben","Carly","Danesha","Evy","Faroukh",
      "Greg","Heather","Ivy","Jaz","Keith","Monica",
      "Nick"
     };

    public static void Main(string[] args) {
      deskNames = new String[3,4];

      Console.WriteLine("===============================");
      AllocateAllDesks(1);
      DisplayDeskMapAlt();
      ClearTheDesks();
      Console.WriteLine("===============================");

      AllocateAllDesks(2);
      DisplayDeskMap();
      ClearTheDesks();
      Console.WriteLine("===============================");

      AllocateAllDesks(3);
      DisplayDeskMap();
      ClearTheDesks();
      Console.WriteLine("===============================");

      AllocateAllDesks(4);
      DisplayDeskMapAlt();
      ClearTheDesks();
      Console.WriteLine("===============================");
      
      
      SearchDesks("Jaz");
      SearchDesksAlt("Jaz");

      SearchDesks("Nick");
      SearchDesksAlt("Nick");

    }

    public static void AllocateAllDesks(int how) {
      string startWhere="";
      switch (how)
      {
        case 1:
          startWhere = "front left";
          break;
        case 2:
          startWhere = "front right";
          break;
        case 3:
          startWhere = "back left";
          break;
        case 4:
          startWhere = "back right";
          break;
      }
      Console.WriteLine("Allocating desks from {0}", startWhere);
      switch (how)
      {
        case 1:
          foreach (string name in names) AllocateDeskFromFrontLeft(name);
          break;
        case 2:
          foreach (string name in names) AllocateDeskFromFrontRight(name);
          break;
        case 3:
          foreach (string name in names) AllocateDeskFromBackLeft(name);
          break;
        case 4:
          foreach (string name in names) AllocateDeskFromBackRight(name);
          break;
      }
    }
    
    public static void AllocateDeskFromFrontLeft(string name) {
      bool deskAssigned = false;
      for (int row = 0; row <= deskNames.GetUpperBound(0); row++) {
        for (int col = 0; col <= deskNames.GetUpperBound(1); col++) {
          if (deskNames[row, col] == null)
          {
            deskNames[row, col] = name;
            //Console.WriteLine("Row:{0} Desk:{1} assigned to {2}",
            //   row + 1, col + 1, name);
            deskAssigned = true;
            break;
          }
        } // end of a row
        if (deskAssigned) break;
      } // end of all rows
      if (!deskAssigned)
      {
        Console.WriteLine("No desk found for {0}", name);
      }
    }
    public static void AllocateDeskFromFrontRight(string name) {
      bool deskAssigned = false;
      for (int row = 0; row <= deskNames.GetUpperBound(0); row++) {
        for (int col = deskNames.GetUpperBound(1); col >= 0; col--) {
          if (deskNames[row, col] == null)
          {
            deskNames[row, col] = name;
            //Console.WriteLine("Row:{0} Desk:{1} assigned to {2}",
            //   row + 1, col + 1, name);
            deskAssigned = true;
            break;
          }
        } // end of a row
        if (deskAssigned) break;
      } // end of all rows
      if (!deskAssigned)
      {
        Console.WriteLine("No desk found for {0}", name);
      }
    }
    public static void AllocateDeskFromBackLeft(string name) {
      bool deskAssigned = false;
      for (int row = deskNames.GetUpperBound(0); row >= 0; row--) {
        for (int col = 0; col <= deskNames.GetUpperBound(1); col++) {
          if (deskNames[row, col] == null)
          {
            deskNames[row, col] = name;
            //Console.WriteLine("Row:{0} Desk:{1} assigned to {2}",
            //   row + 1, col + 1, name);
            deskAssigned = true;
            break;
          }
        } // end of a row
        if (deskAssigned) break;
      } // end of all rows
      if (!deskAssigned)
      {
        Console.WriteLine("No desk found for {0}", name);
      }
    }
    public static void AllocateDeskFromBackRight(string name) {
      bool deskAssigned = false;
      for (int row = deskNames.GetUpperBound(0); row >= 0; row--) {
        for (int col = deskNames.GetUpperBound(1); col >= 0; col--) {
          if (deskNames[row, col] == null)
          {
            deskNames[row, col] = name;
            //Console.WriteLine("Row:{0} Desk:{1} assigned to {2}",
            //   row + 1, col + 1, name);
            deskAssigned = true;
            break;
          }
        } // end of a row
        if (deskAssigned) break;
        
      } // end of all rows
      if (!deskAssigned)
      {
        Console.WriteLine("No desk found for {0}", name);
      }
    }
    
    public static void DisplayDeskMap() {
      Console.WriteLine();
      for (int row = 0; row <= deskNames.GetUpperBound(0); row++) {
        for (int column = 0; column <= deskNames.GetUpperBound(1); column++) {
          string nextName = deskNames[row, column];
          if (nextName == null)
          {
            Console.Write("EMPTY\t");
            // continue;
          }
          else
          {
            Console.Write(nextName + "\t");
          }
        }
        Console.WriteLine();
      }
    }
    public static void DisplayDeskMapAlt() {
      Console.WriteLine();
      int count = 0;
      int rowSize = deskNames.GetUpperBound(1);
      foreach (string name in deskNames)
      {
          Console.Write("{0}\t",name == null?"EMPTY":name);
          
          if (++count > rowSize)
          {
            Console.WriteLine();
            count = 0;
          }
          
      }
    }

    public static void SearchDesks(string name) {
      bool deskFound = false;
      for (int row = 0; row <= deskNames.GetUpperBound(0); row++) {
        for (int column = 0; column <= deskNames.GetUpperBound(1); column++) {
          if (deskNames[row, column] != null && deskNames[row, column] == name)
          {
            Console.WriteLine("{0} is located at Row:{1} Column:{2}", name, row + 1, column + 1);
            deskFound = true;
            break; // out;
          }
        }
        if (deskFound) break;
        
      } // end of desks
      if (!deskFound)
      {
        Console.WriteLine("{0} has no desk", name);
      }
    }
    public static void SearchDesksAlt(string name) {
      bool found = false;
      foreach (string nameAtDesk in deskNames) {
        if (nameAtDesk != null && nameAtDesk == name)
        {
          Console.WriteLine("Found {0}", name);
          found = true;
          break;
        }
      }
      if (!found)
      {
        Console.WriteLine("{0} has no desk",name);
      }
    }

    public static void ClearTheDesks() {
      for (int row = 0; row <= deskNames.GetUpperBound(0); row++)
      {
        for (int col = 0; col <= deskNames.GetUpperBound(1); col++)
        {
          deskNames[row, col] = null;
        }
      }
    }

  }
}

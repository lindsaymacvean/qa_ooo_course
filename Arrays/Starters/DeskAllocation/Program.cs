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
     }; // 13 names!

    public static void Main(string[] args) {
      // initialise and size the array at 3 rows * 4 columns
      

      AllocateAllDesks();

      DisplayDeskMap();
   
      
      SearchDesks("Jaz");
      SearchDesks("Nick");


    }
    public static void AllocateAllDesks() {

    }

    // called from AllocateAllDesks()
    public static void AllocateDesk(string name) {
      
    }
    
    public static void DisplayDeskMap() {

    }

    public static void SearchDesks(string name) {
   
    }
 
    public static void ClearAllDesks() {

    }

  }
}

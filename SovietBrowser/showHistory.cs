﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SovietBrowser {
  public partial class showHistory : Form {
    public showHistory() {
      InitializeComponent();
      
      var path = (@"C:\Users\Public\EzClapsBrowser\History.txt");
      //looks if the history.txt file exists
      if (!File.Exists(path)) {
        //path doesnt exist yet so we create one uwu
        string root = @"C:\Users\Public\EzClapsBrowser";
        //Looks up if the Folder exists 
        if (!Directory.Exists(root)) {
          //doesnt exist so we make one based on the root directory
          Directory.CreateDirectory(root);
          //we also make a new History.txt file ( if the directory doesnt exist then the file wouldnt exist aswel ) 
          File.Create(path);
        }
      } else {
        //if both the directory and History.txt exist or been made then we can enter the folder and read / 
        //write out the file and whats inside
        string content = File.ReadAllText(path);
        txtHistory.Text = content;
        
      }
    }
  }
}



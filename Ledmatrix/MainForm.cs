using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ledmatrix{
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }
    }

    #region classes
    public class LedMatrix {
        private byte identifier;
        private byte[,] data = new byte[8, 8];

        // Constructor
        public LedMatrix(byte identifier) :
            this(identifier, null) {
        }
        public LedMatrix(byte identifier, byte[,] data) {
            this.identifier = identifier;
            if(this.data != null){
                this.data = data;
            }else{
                this.data = new byte[8, 8] {{0,0,0,0,0,0,0,0},
                                            {0,0,0,0,0,0,0,0},
                                            {0,0,0,0,0,0,0,0},
                                            {0,0,0,0,0,0,0,0},
                                            {0,0,0,0,0,0,0,0},
                                            {0,0,0,0,0,0,0,0},
                                            {0,0,0,0,0,0,0,0},
                                            {0,0,0,0,0,0,0,0}};
            }
        }
    }


    public class LedPanel {
        private byte identifier;
        private List<LedMatrix> matrixList = new List<LedMatrix>();

        // Constructor
        public LedPanel(byte identifier) :
            this(identifier, new List<LedMatrix>()) {
        }
        public LedPanel(byte identifier, List<LedMatrix> matrixList) {
            this.identifier = identifier;
            this.matrixList = matrixList;
        }
        //

    }
    #endregion
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursa4vasilev.Modules
{
    public class Simulation

    {
        private bool _isActive = false;
        public Label label;
        public void Start()
        {
           
            _isActive = true;
            Task.Run(() => BusinessLoop());
        }
        private void BusinessLoop()
        {
            while (_isActive) {
                label.Invoke(new Action(() => label.Text = "dfsdf"));
                Thread.Sleep(200);
            }
        }
        public void Stop()
        {
            _isActive = false; 
        }
        float b = 2341324;
    }
    float b = 917845;
}

using System.Windows.Forms;
using ArborGVT;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;

namespace ArborSample
{
    public partial class SampleForm : Form
    {
        private readonly ToolTip fTip;
        private bool fTipShow;

       
        public SampleForm()
        {
            InitializeComponent();
			var colors = typeof(Color).GetProperties();
			foreach(var color in colors)
			{
				comboBox3.Items.Add(color.Name);
			}
            this.fTip = new ToolTip();
            this.fTipShow = false;

            arborViewer1.EnergyDebug = true;
            arborViewer1.NodesDragging = true;
            arborViewer1.start();
        }

        private void ArborViewer1MouseMove(object sender, MouseEventArgs e)
        {
            ArborNode resNode = arborViewer1.getNodeByCoord(e.X, e.Y);

            if (resNode == null) {
                if (fTipShow) {
                    fTip.Hide(arborViewer1);
                    fTipShow = false;
                }
            } else {
                if (!fTipShow) {
                    fTip.Show(resNode.Sign, arborViewer1, e.X + 24, e.Y);
                    fTipShow = true;
                }
            }
        }

		private void button1_Click(object sender, EventArgs e)
		{
			ArborNodeEx.setColor = comboBox3.SelectedItem.ToString();
			var addnode = textBox2.Text;
			arborViewer1.doSample(addnode);
			comboBox2.Items.Add(addnode);
			comboBox1.Items.Add(addnode);

		}

		private void button2_Click(object sender, EventArgs e)
		{
			arborViewer1.doSample(comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString());
		}

		private void button3_Click(object sender, EventArgs e)
		{
			arborViewer1.ClerArea();
			comboBox1.Items.Clear();
			comboBox2.Items.Clear();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			
		}
	}
}

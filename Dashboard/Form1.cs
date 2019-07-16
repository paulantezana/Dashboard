using Dashboard.App;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class Form1 : Form
    {
        private UCAd uCAd;
        private UCAnalytics uCAnalytics;
        private UCAudience uCAudience;
        private UCBlock uCBlock;
        private UCDemand uCDemand;
        private UCGenetic uCGenetic;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnResetColor()
        {
            this.btn_add.Normalcolor = Color.Transparent;
            this.btn_analitycs.Normalcolor = Color.Transparent;
            this.btn_audience.Normalcolor = Color.Transparent;
            this.btn_block.Normalcolor = Color.Transparent;
            this.btn_demand.Normalcolor = Color.Transparent;
            this.btn_genetic.Normalcolor = Color.Transparent;
        }

        internal void togglePanelMain(string panelName)
        {
            this.btnResetColor();
            this.panel_main.Controls.Clear();
            switch (panelName)
            {
                case "ad":
                    if(this.uCAd == null)
                    {
                        this.uCAd = new UCAd();
                        this.panel_main.Controls.Add(uCAd);
                        this.uCAd.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCAd.Location = new System.Drawing.Point(0, 0);
                        this.uCAd.Name = "uCAd";
                        this.uCAd.Size = new System.Drawing.Size(250, 776);
                        this.uCAd.TabIndex = 0;
                    }
                    else
                    {
                        this.panel_main.Controls.Add(uCAd);
                    }
                    this.btn_add.Normalcolor = Color.FromArgb(15, 25, 33);
                    break;
                case "analytics":
                    if (this.uCAnalytics == null)
                    {
                        this.uCAnalytics = new UCAnalytics();
                        this.panel_main.Controls.Add(uCAnalytics);
                        this.uCAnalytics.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCAnalytics.Location = new System.Drawing.Point(0, 0);
                        this.uCAnalytics.Name = "uCAnalytics";
                        this.uCAnalytics.Size = new System.Drawing.Size(250, 776);
                        this.uCAnalytics.TabIndex = 0;
                    }
                    else
                    {
                        this.panel_main.Controls.Add(uCAnalytics);
                    }
                    this.btn_analitycs.Normalcolor = Color.FromArgb(15, 25, 33);
                    break;
                case "audience":
                    if (this.uCAudience == null)
                    {
                        this.uCAudience = new UCAudience();
                        this.panel_main.Controls.Add(uCAudience);
                        this.uCAudience.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCAudience.Location = new System.Drawing.Point(0, 0);
                        this.uCAudience.Name = "uCAudience";
                        this.uCAudience.Size = new System.Drawing.Size(250, 776);
                        this.uCAudience.TabIndex = 0;
                    }
                    else
                    {
                        this.panel_main.Controls.Add(uCAudience);
                    }
                    this.btn_audience.Normalcolor = Color.FromArgb(15, 25, 33);
                    break;
                case "block":
                    if (this.uCBlock == null)
                    {
                        this.uCBlock = new UCBlock();
                        this.panel_main.Controls.Add(uCBlock);
                        this.uCBlock.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCBlock.Location = new System.Drawing.Point(0, 0);
                        this.uCBlock.Name = "uCBlock";
                        this.uCBlock.Size = new System.Drawing.Size(250, 776);
                        this.uCBlock.TabIndex = 0;
                    }
                    else
                    {
                        this.panel_main.Controls.Add(uCBlock);
                    }
                    this.btn_block.Normalcolor = Color.FromArgb(15, 25, 33);
                    break;
                case "demand":
                    if (this.uCDemand == null)
                    {
                        this.uCDemand = new UCDemand();
                        this.panel_main.Controls.Add(uCDemand);
                        this.uCDemand.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCDemand.Location = new System.Drawing.Point(0, 0);
                        this.uCDemand.Name = "uCDemand";
                        this.uCDemand.Size = new System.Drawing.Size(250, 776);
                        this.uCDemand.TabIndex = 0;
                    }
                    else
                    {
                        this.panel_main.Controls.Add(uCDemand);
                    }
                    this.btn_demand.Normalcolor = Color.FromArgb(15, 25, 33);
                    break;
                case "genetic":
                    if (this.uCGenetic == null)
                    {
                        this.uCGenetic = new UCGenetic();
                        this.panel_main.Controls.Add(uCGenetic);
                        this.uCGenetic.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCGenetic.Location = new System.Drawing.Point(0, 0);
                        this.uCGenetic.Name = "uCGenetic";
                        this.uCGenetic.Size = new System.Drawing.Size(250, 776);
                        this.uCGenetic.TabIndex = 0;
                    }
                    else
                    {
                        this.panel_main.Controls.Add(uCGenetic);
                    }
                    this.btn_genetic.Normalcolor = Color.FromArgb(15, 25, 33);
                    break;
                default:
                    break;
            }
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            this.menu_active.Location = new Point(btn_add.Location.X, btn_add.Location.Y);
            this.togglePanelMain("ad");
        }

        private void Btn_demand_Click(object sender, EventArgs e)
        {
            this.menu_active.Location = new Point(btn_demand.Location.X, btn_demand.Location.Y);
            this.togglePanelMain("demand");
        }

        private void Btn_analitycs_Click(object sender, EventArgs e)
        {
            this.menu_active.Location = new Point(btn_analitycs.Location.X, btn_analitycs.Location.Y);
            this.togglePanelMain("analytics");
        }

        private void Btn_block_Click(object sender, EventArgs e)
        {
            this.menu_active.Location = new Point(btn_block.Location.X, btn_block.Location.Y);
            this.togglePanelMain("block");
        }

        private void Btn_genetic_Click(object sender, EventArgs e)
        {
            this.menu_active.Location = new Point(btn_genetic.Location.X, btn_genetic.Location.Y);
            this.togglePanelMain("genetic");
        }

        private void Btn_audience_Click(object sender, EventArgs e)
        {
            this.menu_active.Location = new Point(btn_audience.Location.X, btn_audience.Location.Y);
            this.togglePanelMain("audience");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.menu_active.Location = new Point(btn_demand.Location.X, btn_demand.Location.Y);
            this.togglePanelMain("demand");
        }
    }
}

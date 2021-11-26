
using System;
using System.Windows.Forms;

namespace MarkerPositionPatternMediator
{
    partial class Form1 
    {
        private MarkerMediator mediator = new MarkerMediator();
        private Button addButton;

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";
            MarkerPointer();
        }

        #endregion

        private void MarkerPointer()
        {
            this.addButton = new Button();
            this.addButton.Click += OnAddClick;
            this.addButton.Text = "Add Marker";
            this.addButton.Dock = DockStyle.Bottom;
            this.Controls.Add(this.addButton);
        }

        private void OnAddClick(object sender, EventArgs e)
        {
            var m = this.mediator.CreateMarker();
            this.Controls.Add(m);
        }
    }
}


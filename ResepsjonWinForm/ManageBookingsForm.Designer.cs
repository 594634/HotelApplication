namespace ResepsjonWinForm
{
    partial class ManageBookingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.reservationListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservation Overview";
            // 
            // reservationListView
            // 
            this.reservationListView.Location = new System.Drawing.Point(68, 99);
            this.reservationListView.Name = "reservationListView";
            this.reservationListView.Size = new System.Drawing.Size(411, 318);
            this.reservationListView.TabIndex = 1;
            this.reservationListView.UseCompatibleStateImageBehavior = false;
            this.reservationListView.SelectedIndexChanged += new System.EventHandler(this.reservationListView_SelectedIndexChanged);
            // 
            // ManageBookingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reservationListView);
            this.Controls.Add(this.label1);
            this.Name = "ManageBookingsForm";
            this.Text = "ManageBookingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListView reservationListView;
    }
}
namespace ResepsjonWinForm
{
    partial class Form1
    {
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.roomLabel = new System.Windows.Forms.Label();
            this.startdateLabel = new System.Windows.Forms.Label();
            this.enddateLabel = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.numberText = new System.Windows.Forms.TextBox();
            this.roomText = new System.Windows.Forms.TextBox();
            this.checkinLabel = new System.Windows.Forms.Label();
            this.newbookingLabel = new System.Windows.Forms.Label();
            this.checkinNumberText = new System.Windows.Forms.TextBox();
            this.phonenumberLabel = new System.Windows.Forms.Label();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.registerButton = new System.Windows.Forms.Button();
            this.checkinButton = new System.Windows.Forms.Button();
            this.manageRoomsButton = new System.Windows.Forms.Button();
            this.manageBooking = new System.Windows.Forms.Button();
            this.adminLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(39, 122);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(52, 20);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(39, 163);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(66, 20);
            this.numberLabel.TabIndex = 1;
            this.numberLabel.Text = "Number:";
            // 
            // roomLabel
            // 
            this.roomLabel.AutoSize = true;
            this.roomLabel.Location = new System.Drawing.Point(39, 206);
            this.roomLabel.Name = "roomLabel";
            this.roomLabel.Size = new System.Drawing.Size(52, 20);
            this.roomLabel.TabIndex = 2;
            this.roomLabel.Text = "Room:";
            // 
            // startdateLabel
            // 
            this.startdateLabel.AutoSize = true;
            this.startdateLabel.Location = new System.Drawing.Point(39, 250);
            this.startdateLabel.Name = "startdateLabel";
            this.startdateLabel.Size = new System.Drawing.Size(77, 20);
            this.startdateLabel.TabIndex = 3;
            this.startdateLabel.Text = "Start date:";
            this.startdateLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // enddateLabel
            // 
            this.enddateLabel.AutoSize = true;
            this.enddateLabel.Location = new System.Drawing.Point(39, 292);
            this.enddateLabel.Name = "enddateLabel";
            this.enddateLabel.Size = new System.Drawing.Size(71, 20);
            this.enddateLabel.TabIndex = 4;
            this.enddateLabel.Text = "End date:";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(126, 119);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(171, 27);
            this.nameText.TabIndex = 5;
            // 
            // numberText
            // 
            this.numberText.Location = new System.Drawing.Point(126, 160);
            this.numberText.Name = "numberText";
            this.numberText.Size = new System.Drawing.Size(171, 27);
            this.numberText.TabIndex = 6;
            // 
            // roomText
            // 
            this.roomText.Location = new System.Drawing.Point(126, 203);
            this.roomText.Name = "roomText";
            this.roomText.Size = new System.Drawing.Size(171, 27);
            this.roomText.TabIndex = 7;
            // 
            // checkinLabel
            // 
            this.checkinLabel.AutoSize = true;
            this.checkinLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkinLabel.Location = new System.Drawing.Point(419, 70);
            this.checkinLabel.Name = "checkinLabel";
            this.checkinLabel.Size = new System.Drawing.Size(100, 31);
            this.checkinLabel.TabIndex = 10;
            this.checkinLabel.Text = "Check In";
            // 
            // newbookingLabel
            // 
            this.newbookingLabel.AutoSize = true;
            this.newbookingLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newbookingLabel.Location = new System.Drawing.Point(49, 70);
            this.newbookingLabel.Name = "newbookingLabel";
            this.newbookingLabel.Size = new System.Drawing.Size(235, 31);
            this.newbookingLabel.TabIndex = 11;
            this.newbookingLabel.Text = "Register new booking";
            // 
            // checkinNumberText
            // 
            this.checkinNumberText.Location = new System.Drawing.Point(499, 119);
            this.checkinNumberText.Name = "checkinNumberText";
            this.checkinNumberText.Size = new System.Drawing.Size(171, 27);
            this.checkinNumberText.TabIndex = 13;
            // 
            // phonenumberLabel
            // 
            this.phonenumberLabel.AutoSize = true;
            this.phonenumberLabel.Location = new System.Drawing.Point(422, 122);
            this.phonenumberLabel.Name = "phonenumberLabel";
            this.phonenumberLabel.Size = new System.Drawing.Size(66, 20);
            this.phonenumberLabel.TabIndex = 12;
            this.phonenumberLabel.Text = "Number:";
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Location = new System.Drawing.Point(126, 245);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(250, 27);
            this.startDateTimePicker.TabIndex = 14;
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Location = new System.Drawing.Point(126, 287);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(250, 27);
            this.endDateTimePicker.TabIndex = 15;
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(282, 330);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(94, 29);
            this.registerButton.TabIndex = 16;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // checkinButton
            // 
            this.checkinButton.Location = new System.Drawing.Point(576, 158);
            this.checkinButton.Name = "checkinButton";
            this.checkinButton.Size = new System.Drawing.Size(94, 29);
            this.checkinButton.TabIndex = 17;
            this.checkinButton.Text = "Check In";
            this.checkinButton.UseVisualStyleBackColor = true;
            this.checkinButton.Click += new System.EventHandler(this.checkinButton_Click);
            // 
            // manageRoomsButton
            // 
            this.manageRoomsButton.Location = new System.Drawing.Point(499, 330);
            this.manageRoomsButton.Name = "manageRoomsButton";
            this.manageRoomsButton.Size = new System.Drawing.Size(171, 29);
            this.manageRoomsButton.TabIndex = 18;
            this.manageRoomsButton.Text = "Manage Rooms";
            this.manageRoomsButton.UseVisualStyleBackColor = true;
            this.manageRoomsButton.Click += new System.EventHandler(this.manageRoomsButton_Click);
            // 
            // manageBooking
            // 
            this.manageBooking.Location = new System.Drawing.Point(499, 288);
            this.manageBooking.Name = "manageBooking";
            this.manageBooking.Size = new System.Drawing.Size(171, 29);
            this.manageBooking.TabIndex = 19;
            this.manageBooking.Text = "Manage Bookings";
            this.manageBooking.UseVisualStyleBackColor = true;
            this.manageBooking.Click += new System.EventHandler(this.manageBooking_Click);
            // 
            // adminLabel
            // 
            this.adminLabel.AutoSize = true;
            this.adminLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.adminLabel.Location = new System.Drawing.Point(419, 241);
            this.adminLabel.Name = "adminLabel";
            this.adminLabel.Size = new System.Drawing.Size(166, 31);
            this.adminLabel.TabIndex = 20;
            this.adminLabel.Text = "Administration";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adminLabel);
            this.Controls.Add(this.manageBooking);
            this.Controls.Add(this.manageRoomsButton);
            this.Controls.Add(this.checkinButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.checkinNumberText);
            this.Controls.Add(this.phonenumberLabel);
            this.Controls.Add(this.newbookingLabel);
            this.Controls.Add(this.checkinLabel);
            this.Controls.Add(this.roomText);
            this.Controls.Add(this.numberText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.enddateLabel);
            this.Controls.Add(this.startdateLabel);
            this.Controls.Add(this.roomLabel);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label nameLabel;
        private Label numberLabel;
        private Label roomLabel;
        private Label startdateLabel;
        private Label enddateLabel;
        private TextBox nameText;
        private TextBox numberText;
        private TextBox roomText;
        private Label checkinLabel;
        private Label newbookingLabel;
        private TextBox checkinNumberText;
        private Label phonenumberLabel;
        private DateTimePicker startDateTimePicker;
        private DateTimePicker endDateTimePicker;
        private Button registerButton;
        private Button checkinButton;
        private Button manageRoomsButton;
        private Button manageBooking;
        private Label adminLabel;
    }
}
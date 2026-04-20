namespace DentalAppointment
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
            label1 = new Label();
            fullNameTxt = new TextBox();
            phoneNumberTxt = new TextBox();
            label2 = new Label();
            doctorCbo = new ComboBox();
            label3 = new Label();
            appointmentDtp = new DateTimePicker();
            label4 = new Label();
            officeLocationCbo = new ComboBox();
            label5 = new Label();
            confirmBtn = new Button();
            label6 = new Label();
            reasonForVisitTxt = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 39);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "Full Name";
            // 
            // fullNameTxt
            // 
            fullNameTxt.Location = new Point(160, 36);
            fullNameTxt.Name = "fullNameTxt";
            fullNameTxt.PlaceholderText = "LastName, FirstName";
            fullNameTxt.Size = new Size(212, 23);
            fullNameTxt.TabIndex = 1;
            // 
            // phoneNumberTxt
            // 
            phoneNumberTxt.Location = new Point(160, 88);
            phoneNumberTxt.Name = "phoneNumberTxt";
            phoneNumberTxt.Size = new Size(100, 23);
            phoneNumberTxt.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 91);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 3;
            label2.Text = "Phone Number";
            // 
            // doctorCbo
            // 
            doctorCbo.DropDownStyle = ComboBoxStyle.DropDownList;
            doctorCbo.FormattingEnabled = true;
            doctorCbo.Location = new Point(160, 142);
            doctorCbo.Name = "doctorCbo";
            doctorCbo.Size = new Size(121, 23);
            doctorCbo.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 145);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 5;
            label3.Text = "Doctor";
            // 
            // appointmentDtp
            // 
            appointmentDtp.Location = new Point(160, 203);
            appointmentDtp.Name = "appointmentDtp";
            appointmentDtp.Size = new Size(200, 23);
            appointmentDtp.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 209);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 7;
            label4.Text = "Appointment Date";
            // 
            // officeLocationCbo
            // 
            officeLocationCbo.DropDownStyle = ComboBoxStyle.DropDownList;
            officeLocationCbo.FormattingEnabled = true;
            officeLocationCbo.Location = new Point(160, 265);
            officeLocationCbo.Name = "officeLocationCbo";
            officeLocationCbo.Size = new Size(121, 23);
            officeLocationCbo.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 268);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 9;
            label5.Text = "Office Location";
            // 
            // confirmBtn
            // 
            confirmBtn.Location = new Point(104, 434);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(165, 75);
            confirmBtn.TabIndex = 10;
            confirmBtn.Text = "Confirm Appointment";
            confirmBtn.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 325);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 11;
            label6.Text = "Reason for Visit";
            // 
            // reasonForVisitTxt
            // 
            reasonForVisitTxt.Location = new Point(160, 322);
            reasonForVisitTxt.Multiline = true;
            reasonForVisitTxt.Name = "reasonForVisitTxt";
            reasonForVisitTxt.Size = new Size(212, 89);
            reasonForVisitTxt.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 521);
            Controls.Add(reasonForVisitTxt);
            Controls.Add(label6);
            Controls.Add(confirmBtn);
            Controls.Add(label5);
            Controls.Add(officeLocationCbo);
            Controls.Add(label4);
            Controls.Add(appointmentDtp);
            Controls.Add(label3);
            Controls.Add(doctorCbo);
            Controls.Add(label2);
            Controls.Add(phoneNumberTxt);
            Controls.Add(fullNameTxt);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Schedule Appointment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox fullNameTxt;
        private TextBox phoneNumberTxt;
        private Label label2;
        private ComboBox doctorCbo;
        private Label label3;
        private DateTimePicker appointmentDtp;
        private Label label4;
        private ComboBox officeLocationCbo;
        private Label label5;
        private Button confirmBtn;
        private Label label6;
        private TextBox reasonForVisitTxt;
    }
}

namespace MusicEFApp
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
            components = new System.ComponentModel.Container();
            userBindingSource1 = new BindingSource(components);
            userBindingSource = new BindingSource(components);
            albumBindingSource = new BindingSource(components);
            SignIn = new Button();
            emailTxt = new TextBox();
            PwdTxt = new TextBox();
            SignUp = new Button();
            NameTxt = new TextBox();
            RoleTxt = new TextBox();
            NameLb = new Label();
            label3 = new Label();
            label4 = new Label();
            Rolelb = new Label();
            ((System.ComponentModel.ISupportInitialize)userBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)albumBindingSource).BeginInit();
            SuspendLayout();
            // 
            // userBindingSource1
            // 
            userBindingSource1.DataSource = typeof(User);
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(User);
            // 
            // albumBindingSource
            // 
            albumBindingSource.DataSource = typeof(Album);
            // 
            // SignIn
            // 
            SignIn.Location = new Point(248, 324);
            SignIn.Name = "SignIn";
            SignIn.Size = new Size(94, 29);
            SignIn.TabIndex = 2;
            SignIn.Text = "Sign In";
            SignIn.UseVisualStyleBackColor = true;
            SignIn.Click += SignIn_Click;
            // 
            // emailTxt
            // 
            emailTxt.Location = new Point(350, 122);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(125, 27);
            emailTxt.TabIndex = 3;
            // 
            // PwdTxt
            // 
            PwdTxt.Location = new Point(350, 188);
            PwdTxt.Name = "PwdTxt";
            PwdTxt.Size = new Size(125, 27);
            PwdTxt.TabIndex = 4;
            // 
            // SignUp
            // 
            SignUp.Location = new Point(380, 324);
            SignUp.Name = "SignUp";
            SignUp.Size = new Size(94, 29);
            SignUp.TabIndex = 5;
            SignUp.Text = "Sign Up";
            SignUp.UseVisualStyleBackColor = true;
            SignUp.Visible = false;
            SignUp.Click += SignUp_Click;
            // 
            // NameTxt
            // 
            NameTxt.Location = new Point(350, 62);
            NameTxt.Name = "NameTxt";
            NameTxt.Size = new Size(125, 27);
            NameTxt.TabIndex = 6;
            NameTxt.Visible = false;
            // 
            // RoleTxt
            // 
            RoleTxt.Location = new Point(350, 256);
            RoleTxt.Name = "RoleTxt";
            RoleTxt.Size = new Size(125, 27);
            RoleTxt.TabIndex = 7;
            RoleTxt.Visible = false;
            // 
            // NameLb
            // 
            NameLb.AutoSize = true;
            NameLb.Location = new Point(245, 65);
            NameLb.Name = "NameLb";
            NameLb.Size = new Size(49, 20);
            NameLb.TabIndex = 8;
            NameLb.Text = "Name";
            NameLb.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(224, 191);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 10;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(248, 125);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 11;
            label4.Text = "Email";
            // 
            // Rolelb
            // 
            Rolelb.AutoSize = true;
            Rolelb.Location = new Point(255, 256);
            Rolelb.Name = "Rolelb";
            Rolelb.Size = new Size(39, 20);
            Rolelb.TabIndex = 12;
            Rolelb.Text = "Role";
            Rolelb.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Rolelb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(NameLb);
            Controls.Add(RoleTxt);
            Controls.Add(NameTxt);
            Controls.Add(SignUp);
            Controls.Add(PwdTxt);
            Controls.Add(emailTxt);
            Controls.Add(SignIn);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)userBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)albumBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource userBindingSource;
        private BindingSource albumBindingSource;
        private Button SignIn;
        private TextBox emailTxt;
        private TextBox PwdTxt;
        private Button SignUp;
        private TextBox NameTxt;
        private TextBox RoleTxt;
        private Label NameLb;
        private Label label3;
        private Label label4;
        private Label Rolelb;
        private BindingSource userBindingSource1;
    }
}
